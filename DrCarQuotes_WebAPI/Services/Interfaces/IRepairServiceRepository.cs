using DrCarQuotes_Domain.Entities;

namespace DrCarQuotes_WebAPI.Services.Interfaces;

public interface IRepairServiceRepository
{
    Task<IEnumerable<RepairService>> GetRepairServicesAsync();
    Task<RepairService?> GetRepairServiceByIdAsync(int repairServiceId);
    Task<bool> HasRepairServiceAsync(int repairServiceId);
}
