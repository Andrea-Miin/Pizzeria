using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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

        public Pizza()
        {
            Id_Ingredient = new HashSet<Ingredient>();
            Id_Comment = new HashSet<Comment>();
        }

        public decimal Price()
        {
            return Id_Ingredient.Sum(c => c.Price) + decimal.Parse(ConfigurationManager.AppSettings["profit"]);
        }

        public static Pizza CreatePizza(DtoPizza dtoPizza)
        {
            return new Pizza()
            {
                Name = dtoPizza.Name,
                Photo = dtoPizza.Photo,
                Id_Ingredient = dtoPizza.Id_Ingredient
            };
        }
    }
}
