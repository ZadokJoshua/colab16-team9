using DrCarQuotes_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrCarQuotes_Data.DbContexts;

public class DrCarQuotesDbContext : DbContext
{
    public DrCarQuotesDbContext(DbContextOptions<DrCarQuotesDbContext> options) : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Mechanic> Mechanics { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    public DbSet<RepairService> RepairServices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quote>()
                    .Property(q => q.Price)
                    .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Car>().HasData(
            new Car { Id = 1, Make = "BMW", Model = "I4", Year = 2012 },
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
            new Mechanic { Id = 6, Name = "Car Doctors Auto Shop", Phone = "+1984548823", Address = "3600 Rhawn St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 7, Name = "Auto Express", Phone = "+1984548823", Address = "567 Elm St, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 8, Name = "Car Care Pro", Phone = "+1784585823", Address = "890 Main St, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 9, Name = "Car Repair Guys", Phone = "+1684580823", Address = "123 Park Ave, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 10, Name = "Master Auto Shop", Phone = "+1344588823", Address = "456 Pine St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 11, Name = "Pro Auto Repair", Phone = "+1384588223", Address = "789 Oak St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 12, Name = "Auto Repair Pro", Phone = "+1234588823", Address = "321 Maple St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 13, Name = "Auto Repair Zone", Phone = "+1984548823", Address = "912 Elm St, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 14, Name = "Auto Care Guys", Phone = "+1784585823", Address = "890 Main St, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 15, Name = "Auto Repair Pro", Phone = "+1684580823", Address = "123 Park Ave, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 16, Name = "Car Repair Pro", Phone = "+1344588823", Address = "456 Pine St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 17, Name = "Auto Repair Guys", Phone = "+1384588223", Address = "789 Oak St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 18, Name = "Auto Repair Express", Phone = "+1234588823", Address = "321 Maple St, Philadelphia, PA 19136, United States", ZipCode = "19136" },
            new Mechanic { Id = 19, Name = "Auto Repair Shop", Phone = "+1984548823", Address = "567 Elm St, Corona, NY 11368, United States", ZipCode = "20374" },
            new Mechanic { Id = 20, Name = "Auto Repair Pro", Phone = "+1784585823", Address = "890 Main St, Corona, NY 11368, United States", ZipCode = "20374" }
    );

        modelBuilder.Entity<RepairService>().HasData(
            new RepairService { Id = 1, Name = "Oil Change" },
            new RepairService { Id = 2, Name = "Brake Pads" },
            new RepairService { Id = 3, Name = "Windshield Wiper" },
            new RepairService { Id = 4, Name = "Air Filter" },
            new RepairService { Id = 5, Name = "Spark Plug" },
            new RepairService { Id = 6, Name = "Tire Change" }
            );

        Random rand = new Random();
        List<Quote> quotes = new List<Quote>();

        int id = 1;

        for (int i = 1; i <= 20; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int k = 1; k <= 6; k++)
                {
                    decimal price = 0;
                    if (k == 1) price = (decimal)rand.Next(30, 50) + (decimal)rand.NextDouble();
                    if (k == 2) price = (decimal)rand.Next(135, 260) + (decimal)rand.NextDouble();
                    if (k == 3) price = (decimal)rand.Next(20, 49) + (decimal)rand.NextDouble();
                    if (k == 4) price = (decimal)rand.Next(100, 150) + (decimal)rand.NextDouble();
                    if (k == 5) price = (decimal)rand.Next(minValue: 45, 87) + (decimal)rand.NextDouble();
                    if (k == 6) price = (decimal)rand.Next(200, 250) + (decimal)rand.NextDouble();
                    Quote quote = new Quote {
                        Id = id++,
                        MechanicId = i,
                        CarId = j,
                        RepairServiceId = k,
                        Price = price
                    };
                    quotes.Add(quote);
                }
            }
        }

        modelBuilder.Entity<Quote>().HasData(quotes);

        base.OnModelCreating(modelBuilder);
    }
}