﻿using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineshoppingStore.WebUI.Concrete
{
    public class EFDbContext:DbContext
    {

      
        public DbSet<Product> Products { get; set; }

    }
}