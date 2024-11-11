using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HarvardUniversity.API.ModelDTOs.CourseDTOs
{
    [DisplayName("CourseCreate")]
    public class CourseCreateDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters")]
        public required string Description { get; set; }
    }
}
