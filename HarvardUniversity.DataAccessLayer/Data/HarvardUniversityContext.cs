using Microsoft.EntityFrameworkCore;
using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Azure.Identity;


namespace HarvardUniversity.DataAccessLayer.Data
{
    public class HarvardUniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        public HarvardUniversityContext(DbContextOptions<HarvardUniversityContext> options) : base(options) { }

        public HarvardUniversityContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Configurations.CourseConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.GroupConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.StudentConfiguration());
        }
    }

    public class HarvardUniversityContextFactory : IDesignTimeDbContextFactory<HarvardUniversityContext>
    {
        public HarvardUniversityContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../HarvardUniversity.API/appsettings.json")
                .AddAzureKeyVault(new Uri("https://HarvardUniversityKV.vault.azure.net/"), new DefaultAzureCredential())
                .Build();
            var builder = new DbContextOptionsBuilder<HarvardUniversityContext>();
            var connectionString = configuration["DefaultConnection"];
            builder.UseSqlServer(connectionString);
            return new HarvardUniversityContext(builder.Options);
        }
    }
}
