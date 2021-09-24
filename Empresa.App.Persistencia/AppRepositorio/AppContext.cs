using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class AppContex : DbContext

    {

        private const string connectionString = @"Data source=localhost\sqlexpress;Initial Catalog = grupo56;Integrated Security = True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
        
    }
}