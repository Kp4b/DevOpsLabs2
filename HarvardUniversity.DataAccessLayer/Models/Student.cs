using System;


namespace HarvardUniversity.DataAccessLayer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;
    }
}
