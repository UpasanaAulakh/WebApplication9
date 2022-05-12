using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class ApplicationDbContext:DbContext
    {


        public DbSet<categary>Categaries { get; set; }
        public DbSet<product> products { get; set; }

    }
}