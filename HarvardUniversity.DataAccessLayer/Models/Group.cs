using System;
using System.Collections.Generic;


namespace HarvardUniversity.DataAccessLayer.Models
{
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public virtual IEnumerable<Student> Students { get; set; }
    }
}
