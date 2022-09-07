using WebApplication21.Data;
using WebApplication21.Models;

namespace WebApplication21.Services
{
    public class EscuelaServices
    {
        private readonly IRepository repository;

        public EscuelaServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Escuela escuela)
        {
            if (escuela is null)
                throw new Exception("escula es nula");

            await this.repository.Save(escuela);
            await this.repository.Commit();
        }

        public async Task<List<Escuela>> GetAllEscuelas()
        {
            return await this.repository.GetAll<Escuela>();
        }
    }
}
