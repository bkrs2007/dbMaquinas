using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dbMaquinas.Models;

namespace dbMaquinas.Data
{
    public class dbContext : DbContext
    {
        public dbContext (DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public DbSet<dbMaquinas.Models.CadClientes> CadClientes { get; set; } = default!;

        public DbSet<dbMaquinas.Models.CadMaquinas> CadMaquinas { get; set; } = default!;

        public DbSet<dbMaquinas.Models.Inventario> Inventario { get; set; } = default!;
    }
}
