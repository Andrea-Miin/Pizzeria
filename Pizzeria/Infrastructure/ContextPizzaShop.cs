namespace Infrastructure
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextPizzaShop : DbContext, IContextPizzaShop
    {
        public IDbSet<Pizza> Pizza { get; set; }
        public IDbSet<Ingredient> Ingredient { get; set; }
        public IDbSet<Comment> Comment { get; set; }

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