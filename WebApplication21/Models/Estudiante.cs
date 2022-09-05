namespace WebApplication21.Models
{
    public class Estudiante : Entity
    {
        public string Name { get; private set; }

        public string DocumentoIdentidad { get; private set; }

        public DateTime FechaDeNacimiento { get; private set; }

        public Guid EscuelaId { get; private set; }

        public Escuela Escuela { get; private set; }

        /// <summary>
        /// for
        /// </summary>
        private Estudiante() : base()
        {

        }

        private Estudiante(Guid id, string name, string documentoIdentidad, DateTime fechaDeNacimiento, 
            Guid escuelaId) : base(id)
        {
            Name = name;
            DocumentoIdentidad = documentoIdentidad;
            FechaDeNacimiento = fechaDeNacimiento;
            EscuelaId = escuelaId;
        }

        public Estudiante Build(Guid id, string name, string documentoIdentidad, 
            DateTime fechaDeNacimiento, Guid escuelaId)
        {
            return new Estudiante(id, name, documentoIdentidad, fechaDeNacimiento, escuelaId);
        }
    }
}
