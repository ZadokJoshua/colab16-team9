using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/cars")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly ICarRepository _carRepository;

    public CarsController(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    [HttpGet("get-all-cars")]
    public async Task<IActionResult> GetCars()
    {
        var cars = await _carRepository.GetCarsAsync();
        return Ok(cars);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCarById(int id)
    {
        var car = await _carRepository.GetCarAsync(id);

        if (car is null)
        {
            return NotFound();
        }

        return Ok(car);
    }
}
