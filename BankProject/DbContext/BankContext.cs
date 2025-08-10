using BankProject.BankProjectmodel;
using Microsoft.EntityFrameworkCore;

namespace BankProject.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public DbSet<BankInfo> BankInfo { get; set; }
    }
}
