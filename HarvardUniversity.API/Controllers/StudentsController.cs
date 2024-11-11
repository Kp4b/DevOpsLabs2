using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using HarvardUniversity.API.Contracts;
using HarvardUniversity.API.ModelDTOs.StudentDTOs;
using AutoMapper;
using Swashbuckle.AspNetCore.Annotations;
using HarvardUniversity.API.Properties.SwaggerResponseExamples;
using HarvardUniversity.LoggerService;

namespace HarvardUniversity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [SwaggerOperationFilter(typeof(StudentExamples))]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapResult;
        private readonly ILoggerManager _logger;

        public StudentsController(IUnitOfWork unitOfWork, IMapper mapRes, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _mapResult = mapRes;
            _logger = logger;
        }

        /// <summary>
        /// Returns the list of students with student`s total count in DB by params.
        /// </summary>
        /// <param name="lastName" example="Snow">The last name for search. Returns all students if none.</param>
        /// <param name="startIndex">The start index to take from DB, useful for paging. 0 if none.</param>
        /// <param name="takeCount">The take count from DB, useful for paging. MaxInt if none.</param>
        /// <returns>Returns the list of students in range with serching student`s total count.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Students
        ///     Get /api/Students?lastName=SomeName
        ///     Get /api/Students?startIndex=2
        ///     Get /api/Students?lastName=SomeName&amp;startIndex=5&amp;takeCount=14
        ///
        /// </remarks>
        /// <response code="200">Returns the list of students with student`s total count.</response>
        /// <response code="404">If no student was found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentDTO>> GetStudentsAsync([FromQuery] string? lastName,
                                                                     [FromQuery(Name = "startIndex")] int startIndex,
                                                                     [FromQuery(Name = "takeCount")] int takeCount)
        {
            startIndex = startIndex < 0 ? 0 : startIndex;
            takeCount = takeCount <= 0 ? int.MaxValue : takeCount;

            try
            {
                var studentsWithTotalCount = await _unitOfWork.StudentRepository
                                                   .GetAllWithTotalCountAsync(startIndex, takeCount,
                                                                              orderBy: query => query.OrderBy(s => s.LastName),
                                                                              filter: String.IsNullOrWhiteSpace(lastName)
                                                                                        ? null
                                                                                        : s => s.LastName.Contains(lastName),
                                                                              select: s => new Student
                                                                              {
                                                                                  Id = s.Id,
                                                                                  FirstName = s.FirstName,
                                                                                  LastName = s.LastName,
                                                                                  GroupId = s.GroupId,
                                                                                  Group = new Group
                                                                                  {
                                                                                      Id = s.GroupId,
                                                                                      Name = s.Group.Name
                                                                                  }
                                                                              });
                _logger.LogInfo($"Returned filtered students from database.");

                if (studentsWithTotalCount.TotalCount == 0)
                    return NotFound();

                var studentDTO = new StudentDTO
                {
                    Students = studentsWithTotalCount.Entities.Select(s => new StudentDTO
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        GroupId = s.GroupId,
                        GroupName = s.Group.Name
                    }).ToList(),
                    TotalCount = studentsWithTotalCount.TotalCount
                };
                return Ok(studentDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetStudentsAsync action: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns student by required id parameter.
        /// </summary>
        /// <param name="id" example="3">The student`s id for search.</param>
        /// <returns>Returns the student if exist.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Students/2
        ///
        /// </remarks>
        /// <response code="200">Returns the student with searching id.</response>
        /// <response code="404">If student with such id wasn`t found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [Route("{id}")]
        [ActionName(nameof(GetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentDTO>> GetByIdAsync(int id)
        {
            try
            {
                var student = await _unitOfWork.StudentRepository.GetByIDAsync(id);
                if (student == null)
                {
                    _logger.LogError($"Student with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned student with id: {id}");
                    var result = new StudentDTO
                    {
                        Id = student.Id,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        GroupId = student.GroupId
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
        /// Returns student details by required id parameter.
        /// </summary>
        /// <param name="id" example="3">The student`s id for search.</param>
        /// <returns>Returns the student`s details info if exist.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Students/Details/3
        ///
        /// </remarks>
        /// <response code="200">Returns the student`s details info with searching id.</response>
        /// <response code="404">If student with such id wasn`t found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [Route("Details/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentDTO>> GetDetailsAsync(int id)
        {
            try
            {
                var student = (await _unitOfWork.StudentRepository.GetAsync(filter: s => s.Id == id,
                                                                            select: s => new Student
                                                                            {
                                                                                Id = s.Id,
                                                                                FirstName = s.FirstName,
                                                                                LastName = s.LastName,
                                                                                GroupId = s.GroupId,
                                                                                Group = new Group
                                                                                {
                                                                                    Id = s.GroupId,
                                                                                    Name = s.Group.Name,
                                                                                    CourseId = s.Group.CourseId,
                                                                                    Course = new Course { Name = s.Group.Course.Name }
                                                                                }
                                                                            })).FirstOrDefault();
                if (student == null)
                {
                    _logger.LogError($"Student with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned student with details for id: {id}");
                    return Ok(new StudentDTO
                    {
                        Id = student.Id,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        GroupId = student.GroupId,
                        GroupName = student.Group.Name,
                        CourseId = student.Group.CourseId,
                        CourseName = student.Group.Course.Name
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
        /// Creates a student.
        /// </summary>
        /// <param name="studentCreateDTO"></param>
        /// <returns>A newly created Student</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST
        ///     {
        ///        "firstName": "Jhon",
        ///        "lastName": "Snow",
        ///        "groupId": 1
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created student</response>
        /// <response code="400">If have any error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<StudentDTO>> CreateAsync([FromBody] StudentCreateDTO studentCreateDTO)
        {
            try
            {
                if (studentCreateDTO == null)
                {
                    _logger.LogError("Student object sent from client is null.");
                    return BadRequest("Student object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid student object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var student = _mapResult.Map<Student>(studentCreateDTO);
                await _unitOfWork.StudentRepository.CreateAsync(student);
                await _unitOfWork.CompleteAsync();
                var studentDTO = new StudentDTO
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    GroupId = student.GroupId
                };
                return CreatedAtAction(nameof(GetByIdAsync), new { id = studentDTO.Id }, studentDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateStudent action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }

        /// <summary>
        /// Update a student.
        /// </summary>
        /// <param name="id" example="3">The student`s id for change.</param>
        /// <param name="studentUpdateDTO"></param>
        /// <returns>A updated Student</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Students/3
        ///     body
        ///     {
        ///        "firstName": "Jhon",
        ///        "lastName": "Snow",
        ///        "groupId": 1
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the updated student</response>
        /// <response code="404">If student with such id not found</response>
        /// <response code="400">If have any error</response>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<StudentDTO>> UpdateAsync(int id, [FromBody] StudentUpdateDTO studentUpdateDTO)
        {
            try
            {
                if (studentUpdateDTO == null)
                {
                    _logger.LogError("Student object sent from client is null.");
                    return BadRequest("Student object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid student object sent from client.");
                    return BadRequest("Invalid student object");
                }

                var student = await _unitOfWork.StudentRepository.GetByIDAsync(id);
                if (student == null)
                {
                    _logger.LogError($"Student with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                // Don't use!!!
                // student = _mapResult.Map<Student>(studentUpdateDTO);
                // it returns DbTracking error!!!
                _mapResult.Map(studentUpdateDTO, student);
                await _unitOfWork.StudentRepository.UpdateAsync(student);
                await _unitOfWork.CompleteAsync();
                var studentDTO = new StudentDTO
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    GroupId = student.GroupId
                };
                return CreatedAtAction(nameof(GetByIdAsync), new { id = studentDTO.Id }, studentDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateStudent action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }

        /// <summary>
        /// Delete a student.
        /// </summary>
        /// <param name="id" example="3">The student`s id for delete.</param>
        /// <returns>No content responce</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Students/3
        ///
        /// </remarks>
        /// <response code="204">Returns NoContent responce if success</response>
        /// <response code="404">If student with such id not found</response>
        /// <response code="400">If have any error</response>
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var student = await _unitOfWork.StudentRepository.GetByIDAsync(id);
                if (student == null)
                {
                    _logger.LogError($"Student with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                await _unitOfWork.StudentRepository.DeleteAsync(id);
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