using WebApplication21.Data;
using WebApplication21.Models;

namespace WebApplication21.Services
{
    public class EstudianteServices
    {
        private readonly IRepository repository;

        public EstudianteServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Estudiante estudiante)
        {
            await this.repository.Save(estudiante);
            await this.repository.Commit();
        }

    }
}
