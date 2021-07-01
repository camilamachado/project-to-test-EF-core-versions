using Microsoft.EntityFrameworkCore;
using School.Domain.Features.Students;

namespace School.Infra.Data.Contexts
{
    public static class SeedExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(new Student() { Id = 1, FirstName = "Camila", LastName = "Melo Machado"});
        }
    }
}
