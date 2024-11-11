using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HarvardUniversity.API.ModelDTOs.GroupDTOs
{
    [DisplayName("GroupUpdate")]
    public class GroupUpdateDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "CourseId is required")]
        public int CourseId { get; set; }
    }
}
