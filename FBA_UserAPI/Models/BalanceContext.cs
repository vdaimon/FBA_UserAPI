using FBA_UserAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FBA_UserAPI.Controllers
{
    public class BalanceContext : DbContext
    {
        public DbSet<Balance> Balances { get; set; }
        public BalanceContext(DbContextOptions<BalanceContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
