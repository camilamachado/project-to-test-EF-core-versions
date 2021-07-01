using NUnit.Framework;

namespace School.Integration.Tests.Features
{
    [TestFixture]
    public class BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void InitialSetup()
        {

        }

        /// <summary>
        /// É chamado uma vez ANTES da execução dos testes
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        /// <summary>
        /// É chamado uma vez ANTES da conclusão dos testes
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
