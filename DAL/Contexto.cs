using Microsoft.EntityFrameworkCore;

namespace Lewis_e1_ap2.DAL {
        public class Contexto : DbContext {
            protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
                optionsBuilder.UseSqlite (@"Data Source=DATA\Productos.db");
            }
          
        }

    }
