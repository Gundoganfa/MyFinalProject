using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context nesnesi DB tabloları ile Proje Class'larını bağlamak/ilişkilendirmek için kullanılır.
    public class NorthwindContext:DbContext //DbContext EntityFramework paketi ile birlikte geliyor.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=175.45.2.12"); //@ varsa \ işareti text olarak kullanılabilir.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); //@ varsa \ işareti text olarak kullanılabilir.
            // SQL server adresi; veritabanı adı; username/password
        }
                 
        // Benim hangi Class'ım tablodaki hangi alana denk geliyor
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
