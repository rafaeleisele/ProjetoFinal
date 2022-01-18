using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Models

{
    public class ProjetoFinalContext : DbContext
    {
        public ProjetoFinalContext (DbContextOptions<ProjetoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
