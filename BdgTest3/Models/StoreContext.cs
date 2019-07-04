using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEjemplo.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}