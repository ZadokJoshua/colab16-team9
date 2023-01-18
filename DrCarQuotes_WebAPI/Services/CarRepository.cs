using DrCarQuotes_Data.DbContexts;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_WebAPI.Repository;

public class CarRepository : ICarRepository
{
    private readonly DrCarQuotesDbContext _context;

    public CarRepository(DrCarQuotesDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Car>> GetCarsAsync()
    {
        return await _context.Cars.ToListAsync();
    }

    public async Task<Car?> GetCarAsync(int carId)
    {
        return await _context.Cars.Where(c => c.Id == carId).FirstOrDefaultAsync();
    }
}
