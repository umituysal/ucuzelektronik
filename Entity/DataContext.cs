using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        {
           
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders  { get; set; }
        
        public DbSet<OrderLine> OrderLines { get; set; }

        public System.Data.Entity.DbSet<Abc.MvcWebUI.Entity.About> Abouts { get; set; }

        public System.Data.Entity.DbSet<Abc.MvcWebUI.Entity.Contact> Contacts { get; set; }
    }
}