using Core_Api.DAL.ApiEntity;
using Microsoft.EntityFrameworkCore;

namespace Core_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MULUSOY\\SQLEXPRESS01;database=AspNetCorePortfolioDB_API;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
