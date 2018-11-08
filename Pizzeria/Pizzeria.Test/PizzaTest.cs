using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Pizzeria.Test
{
    [TestClass]
    public class PizzaTest
    {
        [TestMethod]
        public void Price_NegativeResult()
        {
            var pizza = new Pizza();
            var price = pizza.Price();

            Assert.IsTrue(price < 0);
        }
        [TestMethod]
        public void CreatePizza_NullValues(DtoPizza dtoPizza)
        {
            var pizza = Pizza.CreatePizza(dtoPizza);

            Assert.IsNull(pizza.Name);
            Assert.IsNull(pizza.Photo);
            Assert.IsNull(pizza.Id_Ingredient);
        }
    }
}
