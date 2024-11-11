using HarvardUniversity.API.ModelDTOs.GroupDTOs;
using HarvardUniversity.API.Properties;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace HarvardUniversity.API.ModelDTOs.StudentDTOs
{
    [DisplayName("Student")]
    public class StudentDTO
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
        public int? CourseId { get; set; }
        public string? CourseName { get; set; }
        [Properties.SwaggerIgnore]
        public IEnumerable<StudentDTO>? Students { get; set; }
        public int? TotalCount { get; set; }
    }
}
