using Microsoft.EntityFrameworkCore;

namespace CRUD_LocalDB.Models
{
    public class Context: DbContext
    {
        public DbSet<Airplane> Airplanes { get; set; }

        public Context(DbContextOptions<Context> options): base(options) {
            
        }
    }
}
