using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HarvardUniversity.API.ModelDTOs.StudentDTOs
{
    [DisplayName("StudentUpdate")]
    public class StudentUpdateDTO
    {
        [Required(ErrorMessage = "First name is required")]
        [StringLength(30, ErrorMessage = "First name can't be longer than 30 characters")]
        public required string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last Name can't be longer than 50 characters")]
        public required string LastName { get; set; }
        [Required(ErrorMessage = "GroupId is required")]
        public int GroupId { get; set; }
    }
}
