using DrCarQuotes_Domain.Entities;
using DrCarQuotes_WebAPI.Services.Interfaces;

namespace DrCarQuotes_WebAPI.MockData;

public class CarsData
{
    private readonly List<Car> _cars;

    public CarsData()
    {
        _cars = new List<Car>()
        {
            new Car { Id = 1, Make = "BMW", Model = "I4", Year = 2012, ImageUrl = "https://i.ibb.co/1f1H4Kh/bmw-i4.png" },
            new Car { Id = 2, Make = "Audi", Model = "A6", Year = 2005, ImageUrl = "https://i.ibb.co/rFfRJ32/audi-a4.png" },
            new Car { Id = 3, Make = "Fiat", Model = "500x", Year = 2020, ImageUrl = "https://i.ibb.co/d2ngH6z/fiat-500.png" },
            new Car { Id = 4, Make = "Toyota", Model = "Hilux", Year = 2015, ImageUrl = "https://i.ibb.co/31YRJsq/toyota-hilux.png" },
            new Car { Id = 5, Make = "Acura", Model = "Enclave", Year = 2020, ImageUrl = "https://i.ibb.co/tMsWsB6/acura-enclave.png" },
            new Car { Id = 6, Make = "GMC", Model = "Canyon", Year = 2020, ImageUrl = "https://i.ibb.co/PMHXsCZ/gmc-cayon.png" },
            new Car { Id = 7, Make = "Ford", Model = "Edge", Year = 2016, ImageUrl = "https://i.ibb.co/L9q23ZB/ford-escape.png" },
            new Car { Id = 8, Make = "Ford", Model = "Escape", Year = 2021, ImageUrl = "https://i.ibb.co/L9q23ZB/ford-escape.png" },
            new Car { Id = 9, Make = "Audi", Model = "A4", Year = 2020, ImageUrl = "https://i.ibb.co/rFfRJ32/audi-a4.png" },
            new Car { Id = 10, Make = "Chevrolet", Model = "Cruze", Year = 2019, ImageUrl = "https://i.ibb.co/CWNhbHd/chev-cruze.png" }
        };
    }


}
