using HarvardUniversity.DataAccessLayer.Models;

namespace HarvardUniversity.API.Contracts
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IGenericRepository<Course> CourseRepository { get; }
        IGenericRepository<Group> GroupRepository { get; }
        IGenericRepository<Student> StudentRepository { get; }

        Task CompleteAsync();
    }
}
