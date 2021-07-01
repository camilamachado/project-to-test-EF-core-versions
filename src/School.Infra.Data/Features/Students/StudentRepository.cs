using School.Domain.Features.Students;
using School.Infra.Data.Contexts;
using School.Infra.Structs;
using System;
using System.Linq;

namespace School.Infra.Data.Features.Students
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolDbContext _context;

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public Result<Exception, IQueryable<Student>> GetAll()
        {
            return Result.Run(() => _context.Students.AsQueryable());
        }
    }
}
