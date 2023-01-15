using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Repository;
using DrCarQuotes_WebAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuotesController : ControllerBase
{
    private readonly IQuoteRepository _quoteRepository;

    public QuotesController(IQuoteRepository quoteRepository)
	{
        _quoteRepository = quoteRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetQuotesByZipCodeAndRepairService(string zipCode, int repairServiceId, int carId)
    {
        var quotes = await _quoteRepository.GetQuotesByZipCodeAndRepairService(zipCode, repairServiceId, carId);

        return Ok(quotes);
    }

    [HttpGet("best")]
    public async Task<IActionResult> GetBestQuotesByZipCodeAndRepairService(string zipCode, int repairServiceId, int carId)
    {
        var quotes = await _quoteRepository.GetBestQuotesByZipCodeAndRepairService(zipCode, repairServiceId, carId);

        return Ok(quotes);
    }
}
