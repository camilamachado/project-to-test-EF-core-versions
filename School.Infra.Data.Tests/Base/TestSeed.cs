using School.Domain.Features.Students;
using School.Infra.Data.Contexts;

namespace School.Infra.Data.Tests.Base
{
    /// <summary>
    /// <para>Classe semeadora do banco de dados de teste inicial.</para>
    /// <para>O intuito é utilizar essa classe no setup de antes de cada método de teste para montar o ambiente de teste.</para>
    /// <para>Obs.: os dados do banco são apagados e inseridos novamente. Entretanto, por um bug da biblioteca da Microsoft para a criação de BD em  memória,
    /// não é possível resetar valores incrementados automaticamente. Diante disso, é ncessário tomar um cuidado com relação a isso na montagem dos cenários de teste.
    /// O link para as issues da biblioteca se encontram abaixo.</para>
    /// <seealso cref="https://github.com/aspnet/EntityFrameworkCore/issues/4096"/>
    /// <seealso cref="https://github.com/aspnet/EntityFrameworkCore/issues/6872"/>
    /// </summary>
    public class TestSeed
    {
        private SchoolDbContext _context;

        public Student Student { get; private set; }

        public TestSeed(SchoolDbContext context)
        {
            _context = context;
        }

        public void RunSeed()
        {
            //Apagando e recriando o banco de dados
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            //Criação dos objetos
            Student = new Student() { Id = 2, FirstName = "Aluno", LastName = "Teste" };
            _context.Students.Add(Student);

            //Confirmando alterações
            _context.SaveChanges();
        }
    }
}
