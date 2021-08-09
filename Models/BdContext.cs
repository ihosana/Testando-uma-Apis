using Microsoft.EntityFrameworkCore;
namespace test_api.Models
{
    public class BdContext : DbContext
    {   
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=Delivery;Uid=root;Pwd=;");
        }
        public DbSet Pratos {get; set;}
        public DbSet Pedidos {get; set;}
    }
    
}
