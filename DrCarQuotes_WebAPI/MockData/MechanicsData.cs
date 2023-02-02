using DrCarQuotes_Domain.Entities;

namespace DrCarQuotes_WebAPI.MockData;

public class MechanicsData
{
    private readonly IEnumerable<Mechanic> _mechanics;

    public MechanicsData()
    {
        _mechanics = new List<Mechanic>()
        {
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
        };
    }
}
