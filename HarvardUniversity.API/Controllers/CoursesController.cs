using AutoMapper;
using HarvardUniversity.API.Contracts;
using HarvardUniversity.API.ModelDTOs.CourseDTOs;
using HarvardUniversity.API.ModelDTOs.GroupDTOs;
using HarvardUniversity.API.Properties.SwaggerResponseExamples;
using HarvardUniversity.DataAccessLayer.Models;
using HarvardUniversity.LoggerService;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HarvardUniversity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [SwaggerOperationFilter(typeof(CourseExamples))]
    public class CoursesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapResult;
        private readonly ILoggerManager _logger;

        public CoursesController(IUnitOfWork unitOfWork, IMapper mapRes, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _mapResult = mapRes;
            _logger = logger;
        }

        /// <summary>
        /// Returns the list of courses with course`s total count in DB by params.
        /// </summary>
        /// <param name="name" example="Bioengineering">The name for search. Returns all courses if none.</param>
        /// <param name="startIndex">The start index to take from DB, useful for paging. 0 if none.</param>
        /// <param name="takeCount">The take count from DB, useful for paging. MaxInt if none.</param>
        /// <returns>Returns the list of courses in range with serching course`s total count.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Courses
        ///     Get /api/Courses?name=CourseName
        ///     Get /api/Courses?startIndex=2
        ///     Get /api/Courses?name=CourseName&amp;startIndex=5&amp;takeCount=14
        ///
        /// </remarks>
        /// <response code="200">Returns the list of courses with course`s total count.</response>
        /// <response code="404">If no course was found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CourseDTO>> GetCoursesAsync([FromQuery] string? name,
                                                                   [FromQuery(Name = "startIndex")] int startIndex,
                                                                   [FromQuery(Name = "takeCount")] int takeCount)
        {
            startIndex = startIndex < 0 ? 0 : startIndex;
            takeCount = takeCount <= 0 ? int.MaxValue : takeCount;

            try
            {
                var coursesWithTotalCount = await _unitOfWork.CourseRepository
                                                  .GetAllWithTotalCountAsync(startIndex, takeCount,
                                                                             orderBy: query => query.OrderBy(c => c.Name),
                                                                             filter: String.IsNullOrWhiteSpace(name)
                                                                                           ? null
                                                                                           : c => c.Name.Contains(name),
                                                                             select: c => new Course
                                                                             {
                                                                                 Id = c.Id,
                                                                                 Name = c.Name,
                                                                                 Description = c.Description
                                                                             });
                _logger.LogInfo($"Returned filtered courses from database.");

                if (coursesWithTotalCount.TotalCount == 0)
                    return NotFound();

                var courseDTO = new CourseDTO
                {
                    Groups = null,
                    Courses = coursesWithTotalCount.Entities.Select(c => new CourseDTO
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description,
                        Groups = null
                    }).ToList(),
                    TotalCount = coursesWithTotalCount.TotalCount
                };
                return Ok(courseDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetCoursesAsync action: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns course by required id parameter.
        /// </summary>
        /// <param name="id" example="3">The course`s id for search.</param>
        /// <returns>Returns the course if exist.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Courses/2
        ///
        /// </remarks>
        /// <response code="200">Returns the course with searching id.</response>
        /// <response code="404">If course with such id wasn`t found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [Route("{id}")]
        [ActionName(nameof(GetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CourseDTO>> GetByIdAsync(int id)
        {
            try
            {
                var course = await _unitOfWork.CourseRepository.GetByIDAsync(id);
                if (course == null)
                {
                    _logger.LogError($"Course with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned course with id: {id}");
                    var result = new CourseDTO
                    {
                        Id = course.Id,
                        Name = course.Name,
                        Description = course.Description,
                        Groups = null
                    };
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetByIdAsync action: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns course`s details by required id parameter.
        /// </summary>
        /// <param name="id" example="3">The course`s id for search.</param>
        /// <returns>Returns the course`s details info if exist.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Courses/Details/3
        ///
        /// </remarks>
        /// <response code="200">Returns the course`s details info with searching id.</response>
        /// <response code="404">If course with such id wasn`t found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [Route("Details/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CourseDTO>> GetDetailsAsync(int id)
        {
            try
            {
                var course = (await _unitOfWork.CourseRepository.GetAsync(filter: c => c.Id == id,
                                                                          select: c => new Course
                                                                          {
                                                                              Id = c.Id,
                                                                              Name = c.Name,
                                                                              Description = c.Description,
                                                                              Groups = c.Groups.OrderBy(g => g.Name).ToList()
                                                                          })).FirstOrDefault();
                if (course == null)
                {
                    _logger.LogError($"Course with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned course with details for id: {id}");
                    return Ok(new CourseDTO
                    {
                        Id = course.Id,
                        Name = course.Name,
                        Description = course.Description,
                        Groups = course.Groups.Select(g => new GroupDTO
                        {
                            Id = g.Id,
                            Name = g.Name,
                            Students = null
                        }).ToList()
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetDetailsAsync action: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Creates a course.
        /// </summary>
        /// <param name="courseCreateDTO"></param>
        /// <returns>A newly created Course</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST
        ///     {
        ///        "name": "New Course",
        ///        "Description": "New wonderful course!"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created course</response>
        /// <response code="400">If have any error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CourseDTO>> CreateAsync([FromBody] CourseCreateDTO courseCreateDTO)
        {
            try
            {
                if (courseCreateDTO == null)
                {
                    _logger.LogError("Course object sent from client is null.");
                    return BadRequest("Course object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid course object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var course = _mapResult.Map<Course>(courseCreateDTO);
                await _unitOfWork.CourseRepository.CreateAsync(course);
                await _unitOfWork.CompleteAsync();
                var courseDTO = new CourseDTO
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description,
                    Groups = null
                };
                return CreatedAtAction(nameof(GetByIdAsync), new { id = courseDTO.Id }, courseDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateAsync action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }

        /// <summary>
        /// Update a course.
        /// </summary>
        /// <param name="id" example="3">The course`s id for change.</param>
        /// <param name="courseUpdateDTO"></param>
        /// <returns>The updated Course</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Courses/3
        ///     body
        ///     {
        ///        "name": "Changed course",
        ///        "Description": "Course was changed."
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the updated course</response>
        /// <response code="404">If course with such id not found</response>
        /// <response code="400">If have any error</response>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CourseDTO>> UpdateAsync(int id, [FromBody] CourseUpdateDTO courseUpdateDTO)
        {
            try
            {
                if (courseUpdateDTO == null)
                {
                    _logger.LogError("Course object sent from client is null.");
                    return BadRequest("Course object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid course object sent from client.");
                    return BadRequest("Invalid group object");
                }

                var course = await _unitOfWork.CourseRepository.GetByIDAsync(id);
                if (course == null)
                {
                    _logger.LogError($"Course with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _mapResult.Map(courseUpdateDTO, course);
                await _unitOfWork.CourseRepository.UpdateAsync(course);
                await _unitOfWork.CompleteAsync();
                var courseDTO = new CourseDTO
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description,
                    Groups = null
                };
                return CreatedAtAction(nameof(GetByIdAsync), new { id = courseDTO.Id }, courseDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateAsync action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }

        /// <summary>
        /// Delete a course.
        /// </summary>
        /// <param name="id" example="3">The course`s id for delete.</param>
        /// <returns>No content responce</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Courses/3
        ///
        /// </remarks>
        /// <response code="204">Returns NoContent responce if success</response>
        /// <response code="404">If course with such id not found</response>
        /// <response code="400">If have any error</response>
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var course = await _unitOfWork.CourseRepository.GetByIDAsync(id);
                if (course == null)
                {
                    _logger.LogError($"Course with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                await _unitOfWork.CourseRepository.DeleteAsync(id);
                await _unitOfWork.CompleteAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteAsync action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }
    }
}
