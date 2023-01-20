using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrCarQuotes_Domain.Entities;

public class RepairService
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    ICollection<Quote> Quotes { get; set; } = new List<Quote>();
}
