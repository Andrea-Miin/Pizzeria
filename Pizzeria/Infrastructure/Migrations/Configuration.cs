namespace Infrastructure.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.ContextPizzaShop>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infrastructure.ContextPizzaShop context)
        {
            if (!context.Ingredient.Any())
            {
                context.Ingredient.AddOrUpdate
                (
                    new Domain.Ingredient { Name = "Masa", Price = 0.5M },
                    new Domain.Ingredient { Name = "Queso", Price = 0.4M },
                    new Domain.Ingredient { Name = "Tomate", Price = 0.2M },
                    new Domain.Ingredient { Name = "Piña", Price = 0.3M }
                );
            }
        }
    }
}
