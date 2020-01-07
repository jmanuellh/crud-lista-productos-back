using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using tienda.Models;

namespace netmvc2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> producto { get; set; }
    }
}
