using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class Ingredient : EntityBase
    {

        public Ingredient()
        {
            this.Collection_Pizzas = new HashSet<Pizza>();
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ICollection<Pizza> Collection_Pizzas { get; set; }

    }
}
