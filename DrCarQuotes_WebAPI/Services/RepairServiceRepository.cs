using DrCarQuotes_Data.DbContexts;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;

namespace DrCarQuotes_WebAPI.Services;

public class RepairServiceRepository : IRepairServiceRepository
{
    private readonly DrCarQuotesDbContext _context;

    public RepairServiceRepository(DrCarQuotesDbContext context)
    {
        _context = context;
    }

    public Task<IEnumerable<RepairService>> GetRepairServices()
    {
        
    }
}
