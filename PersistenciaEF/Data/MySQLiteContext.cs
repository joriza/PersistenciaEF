using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersistenciaEF.Models;

namespace PersistenciaEF.Data
{
    public class MySQLiteContext : DbContext
    {
        public MySQLiteContext (DbContextOptions<MySQLiteContext> options)
            : base(options)
        {
        }

        public DbSet<PersistenciaEF.Models.Car> Car { get; set; }
    }
}
