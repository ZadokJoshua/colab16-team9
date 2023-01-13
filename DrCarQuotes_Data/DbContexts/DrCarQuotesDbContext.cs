using DrCarQuotes_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_Data.DbContexts;

public class DrCarQuotesDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Mechanic> Mechanics { get; set; }
    public DbSet<RepairService> RepairServices { get; set; }
    public DbSet<Quote> Quotes { get; set; }

    public DrCarQuotesDbContext(DbContextOptions<DrCarQuotesDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(
            new Car{ Id = 1, Make = "BMW", Model = "I4", Year = 2012},
            new Car { Id = 2, Make = "Audi", Model = "A6", Year = 2005 },
            new Car { Id = 3, Make = "Fiat", Model = "500x", Year = 2020 },
            new Car { Id = 4, Make = "Toyota", Model = "Hilux", Year = 2015 },
            new Car { Id = 5, Make = "Acura", Model = "Enclave", Year = 2020 },
            new Car { Id = 6, Make = "GMC", Model = "Canyon", Year = 2020 },
            new Car { Id = 7, Make = "Ford", Model = "Edge", Year = 2016 },
            new Car { Id = 8, Make = "Ford", Model = "Escape", Year = 2021 },
            new Car { Id = 9, Make = "Audi", Model = "A4", Year = 2020 },
            new Car { Id = 10, Make = "Chevrolet", Model = "Cruze", Year = 2019 });

        modelBuilder.Entity<Mechanic>().HasData(
            new Mechanic { Id = 1, Name = "Sam Auto Shop", Phone = "+1234588823", Address = "127-4 Willets Point Blvd, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 2, Name = "Repair Guys", Phone = "+1384588223", Address = "724 State Rd., Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 3, Name = "Automotive Brothers", Phone = "+1344588823", Address = "520 Florida Ave NE, Washington, DC 20002, United States", ZipCode = "20002" },
            new Mechanic { Id = 4, Name = "Hill Auto Repair", Phone = "+1684580823", Address = "261 Shirlington Rd, Arlington, VA 22206, United States", ZipCode = "22206" },
            new Mechanic { Id = 5, Name = "A & Y Auto Masters", Phone = "+1784585823", Address = "143 Build America Dr, Woodbridge, VA 22191, United States", ZipCode = "22191" },
            new Mechanic { Id = 6, Name = "Car Doctors Auto Shop", Phone = "+1984548823", Address = "3600 Rhawn St, Philadelphia, PA 19136, United States", ZipCode = "19136" });

        modelBuilder.Entity<RepairService>().HasData(
            new RepairService { Id = 1, Name = "Engine Air Filter" },
            new RepairService { Id = 2, Name = "Fuel Pump - Replace" },
            new RepairService { Id = 3, Name = "Brake Pads" },
            new RepairService { Id = 4, Name = "Break Rotors" },
            new RepairService { Id = 5, Name = "Rotate Tires" },
            new RepairService { Id = 6, Name = "Patch Tires" },
            new RepairService { Id = 7, Name = "Flush Brake Fluid" },
            new RepairService { Id = 8, Name = "Wiper blades" },
            new RepairService { Id = 9, Name = "Replace Timing Belt" },
            new RepairService { Id = 10, Name = "Flush Differential Fluid " },
            new RepairService { Id = 11, Name = "Oil Change" },
            new RepairService { Id = 12, Name = "Tire Pressure Sensor" },
            new RepairService { Id = 13, Name = "Replace Water Pump" },
            new RepairService { Id = 14, Name = "Replace Battery" },
            new RepairService { Id = 15, Name = "Flush Coolant" },
            new RepairService { Id = 16, Name = "Replace Spark Plugs" },
            new RepairService { Id = 17, Name = "Flush Transmission Fluid" },
            new RepairService { Id = 18, Name = "Replace Engine Belt" },
            new RepairService { Id = 19, Name = "Align Wheels" },
            new RepairService { Id = 20, Name = "Replace Cabin Air Filter" });

        base.OnModelCreating(modelBuilder);
    }
}
