using OOPNKatman_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNKatman_DataAccessLayer.Context
{
    public class KampContext: DbContext
    {
        // sınıf ve table ismi verilir. table ismi cogul verilir
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
    // simdi bussines katmanına da datataccess katmanını referans vermemiz lazım
}   // sonra da presantationa da bussinessi vericez
