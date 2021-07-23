using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_Meeting_11.Models
{
    public class GoodsContext : DbContext
    {
        public GoodsContext() : base("itshopDb")
        {

        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

    public class GoodsShopInitializer : DropCreateDatabaseIfModelChanges<GoodsContext>
    {
        protected override void Seed(GoodsContext context)
        {
            Category GPU = new Category { CategoryName = "Видеокарты" };
            Category CPU = new Category { CategoryName = "Процессоры" };
            Category RAM = new Category { CategoryName = "Оперативная память" };

            Good good1 = new Good { Category = GPU, Title = "MSI PCI-Ex GeForce RTX 3080 Ti Suprim X", Price = 59999 };
            Good good2 = new Good { Category = GPU, Title = "Gigabyte RTX 3060Ti 8GB Gaming OC PRO", Price = 28088 };
            Good good3 = new Good { Category = CPU, Title = "AMD Ryzen 5 5600X", Price = 9509 };
            Good good4 = new Good { Category = CPU, Title = "Intel Core i5-10600KF", Price = 6799 };
            Good good5 = new Good { Category = CPU, Title = "AMD Ryzen 9 5950X", Price = 29696 };
            Good good6 = new Good { Category = RAM, Title = "HyperX DDR4-3200 16384MB PC4-25600 (Kit of 2x8192)", Price = 2740 };

            context.Goods.AddRange(new[] { good1, good2, good3, good4, good5, good6 });
            context.SaveChanges();
        }
    }
}