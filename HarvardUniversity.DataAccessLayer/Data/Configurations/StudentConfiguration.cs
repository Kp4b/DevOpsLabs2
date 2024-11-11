using System;
using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HarvardUniversity.DataAccessLayer.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.Property(b => b.FirstName)
                   .IsRequired()
                   .HasMaxLength(30);
            builder.Property(b => b.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            // Students Data for 200 people.
            string[] name = {"Gary", "Kane", "Some", "Luke", "Piter", "Jane", "Smith", "Jon", "Snow", "Endy",
                                 "Leo", "Messy", "Joy", "Kail", "Andrue", "Marko", "Roberto", "Kirk", "Alex",
                                 "Sterling", "Sheva", "Mark", "Rick", "Sanchez", "Homer", "Marge", "Rodrigez"
                            };
            var studentCount = 200;
            var rnd = new Random();
            var min = 0;
            var max = name.Length;
            var groupsLength = 11; //11 groups have to seed.
            var students = new Student[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                students[i] = new Student
                {
                    Id = i + 1,
                    FirstName = name[rnd.Next(min, max)],
                    LastName = name[rnd.Next(min, max)],
                    GroupId = rnd.Next(1, groupsLength + 1)
                };
            }

            builder.HasData(students);
        }
    }
}
