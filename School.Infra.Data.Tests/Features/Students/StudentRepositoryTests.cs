using FluentAssertions;
using NUnit.Framework;
using School.Infra.Data.Features.Students;
using School.Infra.Data.Tests.Base;
using System.Linq;

namespace School.Infra.Data.Tests.Features.Students
{
    [TestFixture]
    public class StudentRepositoryTests : BaseTest
    {
        private StudentRepository _repository;

        [SetUp]
        public void Initialize()
        {
            _repository = new StudentRepository(Context);
        }

        [Test]
        public void GetAll()
        {
            //Action
            var result = _repository.GetAll();

            //Assert
            result.IsSuccess.Should().BeTrue();
            result.Success.ToList().Should().NotBeNull();
            result.Success.ToList().Should().HaveCount(Context.Students.Count());
        }
    }
}
