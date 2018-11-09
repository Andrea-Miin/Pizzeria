using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application;
using Domain;
using Infrastructure;

namespace Pizzeria.Controllers
{
    public class PizzeriaController : ApiController
    {
        private readonly IServicePizzeria _servicePizzeria;

        public PizzeriaController(IServicePizzeria servicePizzeria)
        {
            _servicePizzeria = servicePizzeria;
        }

        public IHttpActionResult GetAllPizzas()
        {
            IList<Pizza> pizzas = null;

            // recoger datos

            if (pizzas.Count == 0)
            {
                return NotFound();
            }

            return Ok(pizzas);
        }

        public IHttpActionResult PostPizzas(Pizza pizza)
        {
            if (!EntityBase.IsValid())
            {
                return BadRequest("Datos incorrectos");
            }

            // introducir datos

            return Ok();
        }
    }
}
