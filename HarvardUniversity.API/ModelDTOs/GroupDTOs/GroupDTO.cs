using HarvardUniversity.API.ModelDTOs.CourseDTOs;
using HarvardUniversity.API.ModelDTOs.StudentDTOs;
using HarvardUniversity.API.Properties;
using System.ComponentModel;

namespace HarvardUniversity.API.ModelDTOs.GroupDTOs
{
    [DisplayName("Group")]
    public class GroupDTO
    {
        public GroupDTO() { Students = new HashSet<StudentDTO>(); }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? CourseId { get; set; }
        public string? CourseName { get; set; }
        public CourseDTO? Course { get; set; }
        [SwaggerIgnore]
        public IEnumerable<StudentDTO>? Students { get; set; }
        [SwaggerIgnore]
        public IEnumerable<GroupDTO>? Groups { get; set; }
        public int? TotalCount { get; set; }
    }
}
