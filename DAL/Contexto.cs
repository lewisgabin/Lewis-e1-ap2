using Lewis_e1_ap2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lewis_e1_ap2.DAL {
        public class Contexto : DbContext {
            public DbSet<Articulos> Articulos { get; set; }
            protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
                optionsBuilder.UseSqlite (@"Data Source=DATA\Productos.db");
            }
          
        }

    }
