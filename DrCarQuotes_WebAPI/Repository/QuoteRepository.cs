using DrCarQuotes_Data.DbContexts;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_WebAPI.Repository;

public class QuoteRepository : IQuoteRepository
{
    private readonly DrCarQuotesDbContext _context;

    public QuoteRepository(DrCarQuotesDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Quote>> GetBestQuotesByZipCodeAndRepairService(string zipCode, int repairServiceId, int carId)
    {
        // Get quote for a repair service that a mechanic offers. If the mechanic's zip-code is similar to the parameter, return the quote.
        var quotes = await _context.Quotes.Include(q => q.Mechanic)
            .Where(q => q.Mechanic.ZipCode == zipCode && q.RepairServiceId == repairServiceId && q.CarId == carId)
            .OrderBy(q => q.Price)
            .Take(3)
            .ToListAsync();

        return quotes;
    }

    public async Task<Quote?> GetQuote(int id)
    {
        var quote = await _context.Quotes
            .Include(q => q.Car)
            .Include(q => q.Mechanic)
            .Include(q => q.Repair)
            .FirstOrDefaultAsync(q => q.Id == id);

        return quote;
    }
}
