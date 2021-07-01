using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using School.Infra.Data.Contexts;

namespace School.Infra.Data.Tests.Base
{
    [TestFixture]
    public class BaseTest
    {
        protected SchoolDbContext Context { get; private set; }
        protected TestSeed Seeder { get; set; }

        private IConfigurationRoot _configuration;
        private string _connectionString;

        public BaseTest()
        {
            _configuration = new ConfigurationBuilder()
                                    .AddJsonFile("appsettings.json")
                                    .Build();

            _connectionString = _configuration["ConnectionString:InMemoryDatabaseName"];
        }

        [OneTimeSetUp]
        public void InitializeOneTime()
        {
            var options = new DbContextOptionsBuilder<SchoolDbContext>()
                 .UseInMemoryDatabase(_connectionString)
                 .Options;

            Context = new SchoolDbContext(options);

            Seeder = new TestSeed(Context);
        }

        [SetUp]
        public void Seed()
        {
            Seeder.RunSeed();
        }
    }
}
