using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_Data.DbContexts;

public class DrCarQuotesDbContext : DbContext
{
	public DrCarQuotesDbContext(DbContextOptions<DrCarQuotesDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {



        base.OnModelCreating(modelBuilder);
    }
}
