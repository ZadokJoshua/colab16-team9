using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Repository;
using DrCarQuotes_WebAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/quotes")]
[ApiController]
public class QuotesController : ControllerBase
{
    private readonly IQuoteRepository _quoteRepository;

    public QuotesController(IQuoteRepository quoteRepository)
	{
        _quoteRepository = quoteRepository;
    }

    [HttpGet("get-best-quotes")]
    public async Task<IActionResult> GetBestQuotesByZipCodeAndRepairService([Required] string zipCode, [Required] int repairServiceId, [Required] int carId)
    {
        var quotes = await _quoteRepository.GetBestQuotesByZipCodeAndRepairService(zipCode, repairServiceId, carId);

        return Ok(quotes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetQuoteById(int id)
    {
        var quote = await _quoteRepository.GetQuote(id);

        if (quote is null)
        {
            return NotFound();
        }

        return Ok(quote);
    }
}
