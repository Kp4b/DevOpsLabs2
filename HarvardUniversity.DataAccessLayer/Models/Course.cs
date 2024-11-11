using System;
using System.Collections.Generic;

namespace HarvardUniversity.DataAccessLayer.Models
{
    public class Course
    {
        public Course()
        {
            Groups = new HashSet<Group>();
        }
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = null!;
        public virtual IEnumerable<Group> Groups { get; set; }
    }
}
