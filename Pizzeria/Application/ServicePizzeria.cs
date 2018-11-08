using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infrastructure;

namespace Application
{
    public class ServicePizzeria : IServicePizzeria
    {
        private readonly IPizzeriaContext _context;

        public ServicePizzeria(IPizzeriaContext context)
        {
            _context = context;
        } 

        public Pizza Add(DtoPizza command)
        {
            var entity = Pizza.CreatePizza(command);
            if (!entity.IsValid())
            {
                throw new Exception("Error: Campos no validos.");
            }

            var pizza = _context.Pizzas.Add(entity);
            _context.SaveChanges();

            return pizza;
        }

        public IEnumerable<Ingredient> GetIngredients(Pizza pizza)
        {
            var listIngredients = _context.Ingredients.Where(x => x.Collection_Pizzas.Contains(pizza));
            return listIngredients;
        }
    }
}
