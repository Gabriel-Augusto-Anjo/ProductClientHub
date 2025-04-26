using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entites;

namespace ProductClientHub.API.infrastructure
{
    public class ProductClientHubDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = default!;

        public DbSet<Product> Products { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\PROGRAMAÇÃO\\WorkSpace\\SQlite\\1737062251373-attachment.octet-stream");
        }
    }
}
