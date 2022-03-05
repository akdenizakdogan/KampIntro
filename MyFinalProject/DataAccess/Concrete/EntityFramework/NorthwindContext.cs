using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext    //DbContext Ef ile gelen basic bir sınıf.
    {
        //Context: Db tabloları ile proje classlarını bağlamak.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* optionsBuilder.UseSqlServer(@"\Server=175.45.2.12");*/  //Sql sv kullanıcaz. Nasıl baglaancagını söylemem yeterli. Basına @ koydugumda \ ı \\ algıla demek.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        } // Hangi veri tabanına baglanacagını gördün.
            public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }  // Benim Product'ımı o databasedeki Products'a bağla.
        public DbSet<Order> Orders { get; set; }


    }
    }

