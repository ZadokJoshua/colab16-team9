using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/cars")]
[ApiController]
[Produces("application/json")]
public class CarsController : ControllerBase
{
    private readonly ICarRepository _carRepository;

    public CarsController(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    /// <summary>
    /// Get all cars
    /// </summary>        
    /// <returns>An IActionResult</returns>
    /// <response code ="200">Returns all cars in the database.</response>
    [HttpGet("get-all-cars")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(IEnumerable<Car>))]
    public async Task<IActionResult> GetCars()
    {
        var cars = await _carRepository.GetCarsAsync();
        return Ok(cars);
    }

    /// <summary>
    /// Get a car by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>An IActionResult</returns>
    /// <response code ="200">Returns the requested car.</response>
    [HttpGet("{id}")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(Car))]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
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
