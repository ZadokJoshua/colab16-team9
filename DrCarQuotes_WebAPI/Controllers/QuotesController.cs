using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/quotes")]
[ApiController]
[Produces("application/json")]
public class QuotesController : ControllerBase
{
    private readonly IQuoteRepository _quoteRepository;
    private readonly ICarRepository _carRepository;
    private readonly IRepairServiceRepository _repairServiceRepository;

    public QuotesController(IQuoteRepository quoteRepository, ICarRepository carRepository, IRepairServiceRepository repairServiceRepository)
	{
        _quoteRepository = quoteRepository;
        _carRepository = carRepository;
        _repairServiceRepository = repairServiceRepository;
    }

    /// <summary>
    /// Get 3 nearby mechanics with the best prices for a service
    /// </summary>        
    /// <param name="zipCode"></param>
    /// <param name="repairServiceId"></param>
    /// <param name="carId"></param>
    /// <returns>An IActionResult</returns>
    /// <response code ="200">Returns 3 nearby mechanics with the best prices.</response>
    [HttpGet("get-best-quotes")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(IEnumerable<Quote>))]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetBestQuotesByZipCodeAndRepairService([Required] string zipCode, [Required] int repairServiceId, [Required] int carId)
    {
        if (!await _repairServiceRepository.HasRepairServiceAsync(repairServiceId))
        {
            return NotFound("Repair Service Not Found");
        }

        if (!await _carRepository.HasCarAsync(carId))
        {
            return NotFound("Car Not Found");
        }

        var quotes = await _quoteRepository.GetBestQuotesByZipCodeAndRepairService(zipCode, repairServiceId, carId);

        return Ok(quotes);
    }


    /// <summary>
    /// Get a quote by Id
    /// </summary>
    /// <param name="id"></param>
    /// <response code ="200">Returns a single quote.</response>
    [HttpGet("{id}")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(Quote))]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetQuoteById(int id)
    {
        var quote = await _quoteRepository.GetQuote(id);

        if (quote is null)
        {
            return NotFound();
        }

        return Ok(quote);
    }
}
