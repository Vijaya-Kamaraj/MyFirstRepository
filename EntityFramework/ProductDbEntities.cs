﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework
{
    public class ProductDbEntities:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbEntities() : base("name=connection1")
        {

        }
    }
}
