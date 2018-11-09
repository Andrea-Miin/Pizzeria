using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infrastructure
{
    public interface IContextPizzaShop : IUnitOfWork
    {
        IDbSet<Pizza> Pizza { get; set; }
        IDbSet<Ingredient> Ingredient { get; set; }
        IDbSet<Comment> Comment { get; set; }
    }
}
