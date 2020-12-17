using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grocery_API.Models;

namespace Grocery_API.Data
{
    public class Grocery_APIContext : DbContext
    {
        public Grocery_APIContext (DbContextOptions<Grocery_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Grocery_API.Models.Product> Product { get; set; }
    }
}
