namespace WebApplication21.Models
{
    public class Escuela : Entity
    {
        public string Name { get; private set; }

        public string Direccion { get; private set; }

        public string Tipo { get; private set; }

        public List<Estudiante> Estudiantes { get; private set; }

        /// <summary>
        /// for ef
        /// </summary>
        private Escuela() : base()
        {

        }

        private Escuela(Guid id, string name, string direccion, string tipo):base(id)
        {
            Name = name;
            Direccion = direccion;
            Tipo = tipo;
        }

        public Escuela Build(Guid id, string name, string direccion, string tipo)
        {
            return new Escuela(id, name, direccion, tipo);
        }
    }
}
