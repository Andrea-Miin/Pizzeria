using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Infrastructure
{
    public class ContextPizzaShop : DbContext, IContextPizzaShop
    {
        public IDbSet<Pizza> Pizzas { get; set; }
        public IDbSet<Ingredient> Ingredients { get; set; }
        public IDbSet<Comment> Comments { get; set; }

        public ContextPizzaShop()
            : base("name=ContextPizzaShop")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>()
                        .HasMany<Ingredient>(x => x.Collection_Ingredient)
                        .WithMany(y => y.Collection_Pizzas)
                        .Map(xy =>
                        {
                            xy.MapLeftKey("Pizza_Id");
                            xy.MapRightKey("Ingredient_Id");
                            xy.ToTable("PizzaIngredients");
                        });

            modelBuilder.Entity<Pizza>()
                        .HasMany<Comment>(x => x.Collection_Comment)
                        .WithRequired(y => y.Pizza)
                        .HasForeignKey<int>(y => y.Id_Pizza);
        }

        int IUnitOfWork.SaveChanges()
        {
            return this.SaveChanges();
        }
    }
}
