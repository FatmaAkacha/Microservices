﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ProductsAPI.Data
{
    public class ProductsAPIContext : DbContext
    {
        public ProductsAPIContext (DbContextOptions<ProductsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Model.Product> Product { get; set; } = default!;
    }
}
