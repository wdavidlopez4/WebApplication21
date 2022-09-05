namespace WebApplication21.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        //for EF
        protected Entity()
        {

        }

        protected Entity(Guid id)
        {
            Id = id;
        }
    }
}
