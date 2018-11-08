using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Domain
{
    public class Pizza : EntityBase
    {
        public Pizza()
        {
            this.Collection_Ingredient = new HashSet<Ingredient>();
            this.Collection_Comment = new HashSet<Comment>();
        }

        [Required]
        public string Name { get; set; }
        public ICollection<Ingredient> Collection_Ingredient { get; set; }
        public ICollection<Comment> Collection_Comment { get; set; }
        [Required]
        public byte[] Photo { get; set; }

        public decimal Price()
        {
            decimal total = this.Collection_Ingredient.Sum(c => c.Price) + decimal.Parse(ConfigurationManager.AppSettings["profit"]);
            return total;
        }

        public static Pizza CreatePizza(DtoPizza dtoPizza)
        {
            var pizza = new Pizza()
            {
                Name = dtoPizza.Name,
                Photo = dtoPizza.Photo,
                Collection_Ingredient = dtoPizza.Collection_Ingredient
            };

            return pizza;
        }
    }
}