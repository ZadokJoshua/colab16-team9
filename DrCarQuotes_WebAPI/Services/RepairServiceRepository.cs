﻿using DrCarQuotes_Data.DbContexts;
using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_WebAPI.Services;

public class RepairServiceRepository : IRepairServiceRepository
{
    private readonly DrCarQuotesDbContext _context;

    public RepairServiceRepository(DrCarQuotesDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RepairService>> GetRepairServicesAsync()
    {
        return await _context.RepairServices.ToListAsync();
    }
}
