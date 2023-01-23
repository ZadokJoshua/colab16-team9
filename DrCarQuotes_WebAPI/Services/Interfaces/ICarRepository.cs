using DrCarQuotes_Domain.Entities;

namespace DrCarQuotes_WebAPI.Services.Interfaces;

public interface ICarRepository
{
    Task<IEnumerable<Car>> GetCarsAsync();
    Task<Car?> GetCarAsync(int carId);
    Task<bool> HasCarAsync(int carId);
}
