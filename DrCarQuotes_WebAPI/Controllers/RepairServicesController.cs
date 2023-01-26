using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/repairservices")]
[ApiController]
[Produces("application/json")]
public class RepairServicesController : ControllerBase
{
    private readonly IRepairServiceRepository _repairServiceRepository;

    public RepairServicesController(IRepairServiceRepository repairServiceRepository)
	{
        _repairServiceRepository = repairServiceRepository;
    }

    /// <summary>
    /// Get all available repair services
    /// </summary>
    /// <returns></returns>
    [HttpGet("get-all-repairservices")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(IEnumerable<RepairService>))]
    public async Task<IActionResult> GetRepairServices()
    {
        var repairServices = await _repairServiceRepository.GetRepairServicesAsync();
        return Ok(repairServices);
    }

    /// <summary>
    /// Get a repair service by id
    /// </summary>
    /// <param name="id"></param>
    /// <response code ="200">Returns the requested repair service.</response>
    [HttpGet("{id}")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    [SwaggerResponse(StatusCodes.Status200OK, Type = typeof(RepairService))]
    [SwaggerResponse(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetRepairServiceById(int id)
    {
        var repairService = await _repairServiceRepository.GetRepairServiceByIdAsync(id);
        return Ok(repairService);
    }
}
