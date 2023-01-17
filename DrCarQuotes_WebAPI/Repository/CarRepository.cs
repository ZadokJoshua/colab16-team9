using DrCarQuotes_Data.DbContexts;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_WebAPI.Repository;

public class CarRepository : ICarRepository
{
    private readonly DrCarQuotesDbContext _context;

    public CarRepository(DrCarQuotesDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Car>> GetCars()
    {
        IEnumerable<Car> cars = await _context.Cars.ToListAsync();
        return cars;
    }
}
