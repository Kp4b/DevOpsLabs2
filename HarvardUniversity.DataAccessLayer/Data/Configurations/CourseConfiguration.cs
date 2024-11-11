using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HarvardUniversity.DataAccessLayer.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(b => b.Description)
                   .IsRequired()
                   .HasMaxLength(500);
            builder.HasMany(g => g.Groups)
                   .WithOne(c => c.Course)
                   .HasForeignKey(g => g.CourseId);

            builder.HasData
            (
                new Course
                {
                    Id = 1,
                    Name = "Society, Human Development and Health",
                    Description = @"This mission is achieved through research to identify the social and behavioral determinants of health,
                                        development and evaluation of interventions and policies leading to the improvement of population health,
                                        and the preparation of professionals and researchers who will fill leadership positions in advocacy 
                                        and public service."
                },
                    new Course
                    {
                        Id = 2,
                        Name = "Science, Technology and Management",
                        Description = @"Science and engineering technology enterprises have a great demand for managers 
                                        who are not only skilled at business, but who also understand the principles underlying the science, technology, 
                                        and engineering ventures they must manage."
                    },
                    new Course
                    {
                        Id = 3,
                        Name = "Engineering and Applied Sciences",
                        Description = @"Through the Graduate School of Arts and Sciences, prospective students apply for 
                                        doctoral and master’s degree study at the Harvard John A. Paulson School of Engineering 
                                        and Applied Sciences (SEAS). These programs lie at the interfaces of engineering, 
                                        the applied sciences (from biology to physics), and technology."
                    },
                    new Course
                    {
                        Id = 4,
                        Name = "Bioengineering",
                        Description = @"Bioengineering is inherently interdisciplinary and combines faculty and research centers from across 
                                        our campuses and Harvard teaching hospitals."
                    },
                    new Course
                    {
                        Id = 5,
                        Name = "Applied Mathematics",
                        Description = @"Applied Mathematics is an interdisciplinary field that focuses on the creation and imaginative 
                                        use of mathematical concepts to pose and solve problems over the entire gamut of the physical 
                                        and biomedical sciences and engineering, and increasingly, the social sciences and humanities."
                    },
                    new Course
                    {
                        Id = 6,
                        Name = "Computer Science",
                        Description = @"Prospective students apply through GSAS; in the online application, select “Engineering and 
                                        Applied Sciences” as your program choice and select 'PhD Computer Science' in the Area of Study menu."
                    },
                    new Course
                    {
                        Id = 7,
                        Name = "Data Science",
                        Description = @"Data Science lies at the intersection of statistical methodology, computational science, and a wide range 
                                        of application domains. The program offers strong preparation in statistical modeling, machine learning, 
                                        optimization, management and analysis of massive data sets, and data acquisition."
                    },
                    new Course
                    {
                        Id = 8,
                        Name = "Electrical Engineering",
                        Description = @"Electrical Engineering (EE) studies systems that sense, analyze, and interact with the world.
                                        Electrical engineers invent devices for sensing and actuation, design physical substrates for 
                                        computation, create algorithms for analysis and control, and expand the theory of information 
                                        processing."
                    },
                    new Course
                    {
                        Id = 9,
                        Name = "Near Eastern Languages and Civilizations",
                        Description = @"The Department of Near Eastern Languages and Civilizations (NELC) encompasses
                                        the study of ancient and modern peoples, languages, literatures, cultures, 
                                        and societies of the Near and Middle East."
                    },
                    new Course
                    {
                        Id = 10,
                        Name = "Quantum Science and Engineering",
                        Description = @"The PhD program in quantum science and engineering (QSE) lies at the interface of physics,
                                        chemistry, and engineering, providing students with exciting opportunities to explore the fundamentals, realizations, 
                                        and applications of QSE."
                    }
            );
        }
    }
}
