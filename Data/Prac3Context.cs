using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prac3.Models;

namespace Prac3.Data
{
    public class Prac3Context : DbContext
    {
        public Prac3Context (DbContextOptions<Prac3Context> options)
            : base(options)
        {
        }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Descuentos> Descuentos { get; set; }
        public DbSet<Bonos> Bonos { get; set; }

    }
}
