using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;

namespace DrCarQuotes_WebAPI.MockData;

public class RepairServicesData : IRepairServiceRepository
{
    private readonly IEnumerable<RepairService> _repairServices;

    public RepairServicesData()
    {
        _repairServices = new List<RepairService>()
        {
            new RepairService { Id = 1, Name = "Oil Change" },
            new RepairService { Id = 2, Name = "Brake Pads" },
            new RepairService { Id = 3, Name = "Windshield Wiper" },
            new RepairService { Id = 4, Name = "Air Filter" },
            new RepairService { Id = 5, Name = "Spark Plug" },
            new RepairService { Id = 6, Name = "Tire Change" }
        };
    }

    public Task<RepairService?> GetRepairServiceByIdAsync(int repairServiceId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RepairService>> GetRepairServicesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasRepairServiceAsync(int repairServiceId)
    {
        throw new NotImplementedException();
    }
}
