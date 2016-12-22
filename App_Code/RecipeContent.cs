namespace Assignment4
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RecipeContent : DbContext
    {
        public RecipeContent()
          : base("name=RecipeContext")
        {
        }

        public virtual DbSet<Breakfast> Breakfasts { get; set; }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Dinner> Dinners { get; set; }
        public virtual DbSet<Lunch> Lunches { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
