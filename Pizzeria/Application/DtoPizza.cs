using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class DtoPizza : Pizza
    {
        public DtoPizza(Pizza pizza)
        {
            this.Name = pizza.Name;
            this.Id_Ingredient = pizza.Id_Ingredient;
            this.Id_Comment = pizza.Id_Comment;
            this.Photo = pizza.Photo;
            // Sustituir "5" por ConfigurationManager.AppSettings["Profit"]
            this.Price = pizza.Id_Ingredient.Sum(c => c.Price) + decimal.Parse("5"); ;
        }
    }
}