using System;
using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HarvardUniversity.DataAccessLayer.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Group");
            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(10);
            builder.HasMany(s => s.Students)
                   .WithOne(g => g.Group)
                   .HasForeignKey(s => s.GroupId);

            builder.HasData
            (
                new Group
                {
                    Id = 1,
                    Name = "SE-01",
                    CourseId = 1
                },
                    new Group
                    {
                        Id = 2,
                        Name = "SE-02",
                        CourseId = 3
                    },
                    new Group
                    {
                        Id = 3,
                        Name = "SE-08",
                        CourseId = 8
                    },
                    new Group
                    {
                        Id = 4,
                        Name = "JB-01",
                        CourseId = 2
                    },
                    new Group
                    {
                        Id = 5,
                        Name = "DC-23",
                        CourseId = 6
                    },
                    new Group
                    {
                        Id = 6,
                        Name = "DE-15",
                        CourseId = 7
                    },
                    new Group
                    {
                        Id = 7,
                        Name = "SX-02",
                        CourseId = 5
                    },
                    new Group
                    {
                        Id = 8,
                        Name = "SX-02",
                        CourseId = 9
                    },
                    new Group
                    {
                        Id = 9,
                        Name = "FQ-14",
                        CourseId = 3
                    },
                    new Group
                    {
                        Id = 10,
                        Name = "SR-01",
                        CourseId = 4
                    },
                    new Group
                    {
                        Id = 11,
                        Name = "SM-03",
                        CourseId = 6
                    }
            );
        }
    }
}
