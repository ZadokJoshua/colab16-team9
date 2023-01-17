using DrCarQuotes_Domain.Entities;

namespace DrCarQuotes_WebAPI.Repository.Interfaces;

public interface ICarRepository
{
    Task<IEnumerable<Car>> GetCars();
}
