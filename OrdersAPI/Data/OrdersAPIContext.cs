using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace OrdersAPI.Data
{
    public class OrdersAPIContext : DbContext
    {
        public OrdersAPIContext (DbContextOptions<OrdersAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Orders> Orders { get; set; } = default!;
        public DbSet<Product> Products { get; set; }
    }
}
