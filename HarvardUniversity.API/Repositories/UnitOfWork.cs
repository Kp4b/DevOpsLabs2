using HarvardUniversity.API.Contracts;
using HarvardUniversity.DataAccessLayer.Data;
using HarvardUniversity.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HarvardUniversity.API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed = false;
        private HarvardUniversityContext _context;
        private IGenericRepository<Course>? _courseRepository;
        private IGenericRepository<Group>? _groupRepository;
        private IGenericRepository<Student>? _studentRepository;

        public UnitOfWork(HarvardUniversityContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IGenericRepository<Course> CourseRepository => _courseRepository ??= new GenericRepository<Course>(_context);

        public IGenericRepository<Group> GroupRepository => _groupRepository ??= new GenericRepository<Group>(_context);

        public IGenericRepository<Student> StudentRepository => _studentRepository ??= new GenericRepository<Student>(_context);

        public async Task CompleteAsync() => await _context.SaveChangesAsync();

        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);

            // Take this object off the finalization queue to prevent 
            // finalization code for this object from executing a second time.
            GC.SuppressFinalize(this);
        }

        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    await _context.DisposeAsync();
                }
                _disposed = true;
            }
        }
    }
}