using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infrastructure;

namespace Infrastructure
{
    public class PizzaService : IPizzaService
    {
        public IContextPizzaShop contextPizzaShop;

        public PizzaService()
        {

        }

        public Pizza Add(DtoPizza command)
        {
            var entity = Pizza.CreatePizza(command);
            if (!entity.IsValid())
            {
                throw new Exception("Error al crear la pizza. Campos no validos.");
            }

            var pizza = contextPizzaShop.Pizza.Add(entity);
            contextPizzaShop.SaveChanges();
            contextPizzaShop.Dispose();
            return pizza;
        }
    }
}
