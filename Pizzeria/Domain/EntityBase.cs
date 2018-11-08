namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class EntityBase : DbContext
    {
        [Required]
        public int Id { get; set; }

        public virtual bool IsValid()
        {
            var context = new ValidationContext(this, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            var validator = Validator.TryValidateObject(this, context, results);
            return validator;
        }
    }
}