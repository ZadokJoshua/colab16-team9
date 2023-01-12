using MechanicQuotes_Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrCarQuotes_Domain.Entities;

public class Quote
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [ForeignKey(nameof(MechanicId))]
    public int MechanicId { get; set; }
    public Mechanic? Mechanic { get; set; }

    [ForeignKey(nameof(CarId))]
    public int CarId { get; set; }
    public Car? Car { get; set; }

    [ForeignKey(nameof(RepairId))]
    public int RepairId { get; set; }
    public Repair? Repair { get; set; }
}
