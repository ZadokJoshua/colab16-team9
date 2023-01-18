using DrCarQuotes_Domain.Entities;

namespace DrCarQuotes_WebAPI.Services.Interfaces;

public interface IQuoteRepository
{
    Task<IEnumerable<Quote>> GetBestQuotesByZipCodeAndRepairService(string zipCode, int repairServiceId, int carId);

    Task<Quote?> GetQuote(int quoteId);
}
