using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Features.Students;

namespace School.Infra.Data.Features.Students
{
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
			builder.ToTable("Students");

			builder.HasKey(sc => sc.Id);
		}
    }
}
