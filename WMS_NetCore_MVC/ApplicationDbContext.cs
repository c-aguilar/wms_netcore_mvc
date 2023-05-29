using Microsoft.EntityFrameworkCore;
using WMS_NetCore_MVC.Models;

namespace WMS_NetCore_MVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Partnumber> Partnumbers { get; set; }
    }
}
