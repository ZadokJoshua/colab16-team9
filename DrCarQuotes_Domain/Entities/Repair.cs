using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrCarQuotes_Domain.Entities;

public class Repair
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public bool Common { get; set; } = false;

    ICollection<Quote> Quotes { get; set; } = new List<Quote>();
}
