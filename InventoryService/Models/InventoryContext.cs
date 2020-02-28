using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Models
{
    public class InventoryContext : DbContext
    {

        public InventoryContext (DbContextOptions<InventoryContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
    }
}
