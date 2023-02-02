using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;

namespace DrCarQuotes_WebAPI.MockData;

public class QuotesData : IQuoteRepository
{
    private readonly IEnumerable<Quote> _quotes;

    public QuotesData()
    {
        _quotes = CreateQuotes();
    }

    public Task<IEnumerable<Quote>> GetBestQuotesByZipCodeAndRepairService(string zipCode, int repairServiceId, int carId)
    {
        throw new NotImplementedException();
    }

    public Task<Quote?> GetQuote(int quoteId)
    {
        throw new NotImplementedException();
    }

    private IList<Quote> CreateQuotes()
    {
        Random rand = new Random();
        IList<Quote> quotes = new List<Quote>();

        int id = 1;

        for (int i = 1; i <= 20; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int k = 1; k <= 6; k++)
                {
                    decimal price = 0;
                    if (k == 1) price = rand.Next(30, 50) + (decimal)rand.NextDouble();
                    if (k == 2) price = rand.Next(135, 260) + (decimal)rand.NextDouble();
                    if (k == 3) price = rand.Next(20, 49) + (decimal)rand.NextDouble();
                    if (k == 4) price = rand.Next(100, 150) + (decimal)rand.NextDouble();
                    if (k == 5) price = rand.Next(minValue: 45, 87) + (decimal)rand.NextDouble();
                    if (k == 6) price = rand.Next(200, 250) + (decimal)rand.NextDouble();
                    Quote quote = new Quote
                    {
                        Id = id++,
                        MechanicId = i,
                        CarId = j,
                        RepairServiceId = k,
                        Price = price
                    };
                    quotes.Add(quote);
                }
            }
        }

        return quotes;
    }
}
