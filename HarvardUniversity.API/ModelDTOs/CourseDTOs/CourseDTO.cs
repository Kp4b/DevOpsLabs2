using HarvardUniversity.API.ModelDTOs.GroupDTOs;
using HarvardUniversity.API.Properties;
using System.ComponentModel;

namespace HarvardUniversity.API.ModelDTOs.CourseDTOs
{
    [DisplayName("Course")]
    public class CourseDTO
    {
        public CourseDTO() { Groups = new HashSet<GroupDTO>(); }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [SwaggerIgnore]
        public IEnumerable<GroupDTO>? Groups { get; set; }
        [SwaggerIgnore]
        public IEnumerable<CourseDTO>? Courses { get; set; }
        public int? TotalCount { get; set; }
    }
}
