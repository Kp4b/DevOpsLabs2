using AutoMapper;
using HarvardUniversity.API.Contracts;
using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using HarvardUniversity.API.ModelDTOs.StudentDTOs;
using Swashbuckle.AspNetCore.Annotations;
using HarvardUniversity.API.Properties.SwaggerResponseExamples;
using HarvardUniversity.LoggerService;
using HarvardUniversity.API.ModelDTOs.GroupDTOs;

namespace HarvardUniversity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [SwaggerOperationFilter(typeof(GroupExamples))]
    public class GroupsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapResult;
        private readonly ILoggerManager _logger;

        public GroupsController(IUnitOfWork unitOfWork, IMapper mapRes, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _mapResult = mapRes;
            _logger = logger;
        }

        /// <summary>
        /// Returns the list of groups with group`s total count in DB by params.
        /// </summary>
        /// <param name="name" example="SE-01">The name for search. Returns all groups if none.</param>
        /// <param name="startIndex">The start index to take from DB, useful for paging. 0 if none.</param>
        /// <param name="takeCount">The take count from DB, useful for paging. MaxInt if none.</param>
        /// <returns>Returns the list of groups in range with serching group`s total count.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Groups
        ///     Get /api/Groups?name=GroupName
        ///     Get /api/Groups?startIndex=2
        ///     Get /api/Groups?name=GroupName&amp;startIndex=5&amp;takeCount=14
        ///
        /// </remarks>
        /// <response code="200">Returns the list of groups with group`s total count.</response>
        /// <response code="404">If no group was found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GroupDTO>> GetGroupsAsync([FromQuery] string? name,
                                                                 [FromQuery(Name = "startIndex")] int startIndex,
                                                                 [FromQuery(Name = "takeCount")] int takeCount)
        {
            startIndex = startIndex < 0 ? 0 : startIndex;
            takeCount = takeCount <= 0 ? int.MaxValue : takeCount;

            try
            {
                var groupsWithTotalCount = await _unitOfWork.GroupRepository
                                                 .GetAllWithTotalCountAsync(startIndex, takeCount,
                                                                            orderBy: query => query.OrderBy(g => g.Name),
                                                                            filter: String.IsNullOrWhiteSpace(name)
                                                                                          ? null
                                                                                          : g => g.Name.Contains(name),
                                                                            select: g => new Group
                                                                            {
                                                                                Id = g.Id,
                                                                                Name = g.Name,
                                                                                CourseId = g.CourseId,
                                                                                Course = new Course
                                                                                {
                                                                                    Id = g.Course.Id,
                                                                                    Name = g.Course.Name
                                                                                }
                                                                            });
                _logger.LogInfo($"Returned filtered groups from database.");

                if (groupsWithTotalCount.TotalCount == 0)
                    return NotFound();

                var groupDTO = new GroupDTO
                {
                    Students = null,
                    Groups = groupsWithTotalCount.Entities.Select(g => new GroupDTO
                    {
                        Id = g.Id,
                        Name = g.Name,
                        CourseId = g.CourseId,
                        CourseName = g.Course.Name,
                        Students = null
                    }).ToList(),
                    TotalCount = groupsWithTotalCount.TotalCount
                };
                return Ok(groupDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetGroupsAsync action: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Returns group by required id parameter.
        /// </summary>
        /// <param name="id" example="3">The group`s id for search.</param>
        /// <returns>Returns the group if exist.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Groups/2
        ///
        /// </remarks>
        /// <response code="200">Returns the group with searching id.</response>
        /// <response code="404">If group with such id wasn`t found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [Route("{id}")]
        [ActionName(nameof(GetByIdAsync))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GroupDTO>> GetByIdAsync(int id)
        {
            try
            {
                var group = await _unitOfWork.GroupRepository.GetByIDAsync(id);
                if (group == null)
                {
                    _logger.LogError($"Group with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned group with id: {id}");
                    var result = new GroupDTO
                    {
                        Id = group.Id,
                        Name = group.Name,
                        CourseId = group.CourseId,
                        Students = null
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
        /// Returns group`s details by required id parameter.
        /// </summary>
        /// <param name="id" example="3">The group`s id for search.</param>
        /// <returns>Returns the group`s details info if exist.</returns>
        /// <remarks>
        /// Sample requests:
        ///
        ///     Get /api/Groups/Details/3
        ///
        /// </remarks>
        /// <response code="200">Returns the group`s details info with searching id.</response>
        /// <response code="404">If group with such id wasn`t found.</response>
        /// <response code="400">For error responses.</response>
        [HttpGet]
        [Route("Details/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GroupDTO>> GetDetailsAsync(int id)
        {
            try
            {
                var group = (await _unitOfWork.GroupRepository.GetAsync(filter: g => g.Id == id,
                                                                        select: g => new Group
                                                                        {
                                                                            Id = g.Id,
                                                                            Name = g.Name,
                                                                            CourseId = g.CourseId,
                                                                            Course = new Course
                                                                            {
                                                                                Id = g.Course.Id,
                                                                                Name = g.Course.Name
                                                                            },
                                                                            Students = g.Students.OrderBy(s => s.LastName).ToList()
                                                                        })).FirstOrDefault();
                if (group == null)
                {
                    _logger.LogError($"Group with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned group with details for id: {id}");
                    return Ok(new GroupDTO
                    {
                        Id = group.Id,
                        Name = group.Name,
                        CourseId = group.CourseId,
                        CourseName = group.Course.Name,
                        Students = group.Students.Select(s => new StudentDTO
                        {
                            Id = s.Id,
                            FirstName = s.FirstName,
                            LastName = s.LastName
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
        /// Creates a group.
        /// </summary>
        /// <param name="groupCreateDTO"></param>
        /// <returns>A newly created Group</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST
        ///     {
        ///        "name": "GR-1",
        ///        "courseId": 1
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created group</response>
        /// <response code="400">If have any error</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<GroupDTO>> CreateAsync([FromBody] GroupCreateDTO groupCreateDTO)
        {
            try
            {
                if (groupCreateDTO == null)
                {
                    _logger.LogError("Group object sent from client is null.");
                    return BadRequest("Group object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid group object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var group = _mapResult.Map<Group>(groupCreateDTO);
                await _unitOfWork.GroupRepository.CreateAsync(group);
                await _unitOfWork.CompleteAsync();
                var groupDTO = new GroupDTO
                {
                    Id = group.Id,
                    Name = group.Name,
                    CourseId = group.CourseId,
                    Students = null
                };
                return CreatedAtAction(nameof(GetByIdAsync), new { id = group.Id }, groupDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateAsync action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }

        /// <summary>
        /// Update a group.
        /// </summary>
        /// <param name="id" example="3">The group`s id for change.</param>
        /// <param name="groupUpdateDTO"></param>
        /// <returns>The updated Group</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Groups/3
        ///     body
        ///     {
        ///        "name": "GR-1",
        ///        "courseId": 1
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the updated group</response>
        /// <response code="404">If group with such id not found</response>
        /// <response code="400">If have any error</response>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<GroupDTO>> UpdateAsync(int id, [FromBody] GroupUpdateDTO groupUpdateDTO)
        {
            try
            {
                if (groupUpdateDTO == null)
                {
                    _logger.LogError("Group object sent from client is null.");
                    return BadRequest("Group object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid group object sent from client.");
                    return BadRequest("Invalid group object");
                }

                var group = await _unitOfWork.GroupRepository.GetByIDAsync(id);
                if (group == null)
                {
                    _logger.LogError($"Group with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _mapResult.Map(groupUpdateDTO, group);
                await _unitOfWork.GroupRepository.UpdateAsync(group);
                await _unitOfWork.CompleteAsync();
                var groupDTO = new GroupDTO
                {
                    Id = group.Id,
                    Name = group.Name,
                    CourseId = group.CourseId,
                    Students = null
                };
                return CreatedAtAction(nameof(GetByIdAsync), new { id = groupDTO.Id }, groupDTO);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateAsync action: {ex.Message}");
                return BadRequest("Internal server error");
            }
        }

        /// <summary>
        /// Delete a group.
        /// </summary>
        /// <param name="id" example="3">The group`s id for delete.</param>
        /// <returns>No content responce</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Groups/3
        ///
        /// </remarks>
        /// <response code="204">Returns NoContent responce if success</response>
        /// <response code="404">If group with such id not found</response>
        /// <response code="400">If have any error</response>
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var group = await _unitOfWork.GroupRepository.GetByIDAsync(id);
                if (group == null)
                {
                    _logger.LogError($"Group with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                await _unitOfWork.GroupRepository.DeleteAsync(id);
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
