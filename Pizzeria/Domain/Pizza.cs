using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Pizza : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Ingredient> Id_Ingredient { get; set; }
        public ICollection<Comment> Id_Comment { get; set; }
        [Required]
        public byte[] Photo { get; set; }

        public decimal Price()
        {
            return this.Id_Ingredient.Sum(c => c.Price) + decimal.Parse("5");
        }

        public static Pizza CreatePizza (DtoPizza dtoPizza)
        {
            var pizza = new Pizza()
            {
                Name = dtoPizza.Name,
                Photo = dtoPizza.Photo,
                Id_Ingredient = dtoPizza.Id_Ingredient
            };

            return pizza;
        }
    }
}