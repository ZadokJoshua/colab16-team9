using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrCarQuotes_WebAPI.Controllers;

[Route("api/repairservices")]
[ApiController]
public class RepairServicesController : ControllerBase
{
    private readonly IRepairServiceRepository _repairServiceRepository;

    public RepairServicesController(IRepairServiceRepository repairServiceRepository)
	{
        _repairServiceRepository = repairServiceRepository;
    }

    [HttpGet("get-all-repairservices")]
    [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Any)]
    public async Task<IActionResult> GetRepairServices()
    {
        var repairServices = await _repairServiceRepository.GetRepairServicesAsync();
        return Ok(repairServices);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRepairServiceById(int id)
    {
        var repairService = await _repairServiceRepository.GetRepairServiceByIdAsync(id);
        return Ok(repairService);
    }
}
