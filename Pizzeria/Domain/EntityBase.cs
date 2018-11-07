namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EntityBase : DbContext
    {
        public Guid Id { get; set; }

        public EntityBase()
            : base("name=EntityBase")
        {
        }

        // Boolean. Manual validation data annotation.
        public void IsValid() { }

        // Errors dictionary. Crear nuevo error (throw).
        public void Error() { }
    }
}