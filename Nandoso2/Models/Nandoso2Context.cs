using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Nandoso2.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class Nandoso2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        public class MyConfiguration : DbMigrationsConfiguration<Nandoso2Context>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
                this.AutomaticMigrationDataLossAllowed = true;
            }


            protected override void Seed(Nandoso2Context context)
            {
                var Dishes = new List<Dish>
            {
                new  Dish{ DishName = "Ribs",   Describtion = "8 Bite sized chicken on the bone.",
                    Price = 12, Special = false },
                new  Dish{ DishName = "Wings",   Describtion = "Reach new heights of enjoyment.",
                    Price = 12, Special = false },
                new  Dish{ DishName = "Livers",   Describtion = "Grilled in a garlic sauce and basted to your hearts desire.",
                    Price = 7, Special = false },
                new  Dish{ DishName = "Tenderloins",   Describtion = "So tender you'll feel it in your loins.",
                    Price = 12, Special = false },
                new  Dish{ DishName = "Thigh Fillet",   Describtion = "Get high on some thighs.",
                    Price = 12, Special = true }
     
            };
                Dishes.ForEach(s => context.Dishes.AddOrUpdate(p => p.DishName, s));
                context.SaveChanges();
            }



        }
        public Nandoso2Context() : base("name=Nandoso2Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Nandoso2Context, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<Nandoso2.Models.Dish> Dishes { get; set; }
    
    }
}
