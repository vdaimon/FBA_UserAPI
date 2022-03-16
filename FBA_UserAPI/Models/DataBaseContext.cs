using FBA_UserAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FBA_UserAPI.Controllers
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Balance> Balances { get; set; }
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
