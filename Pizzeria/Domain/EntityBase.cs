namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class EntityBase : DbContext
    {
        [Required]
        public Guid Id { get; set; }

        public virtual bool IsValid()
        {
            // Hay que quitar pizza
            // Si se llama al metodo IsValid() deberiamos cambiarlo por this?
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            var validator = Validator.TryValidateObject(this, context, results);
            return validator;
        }
    }
}