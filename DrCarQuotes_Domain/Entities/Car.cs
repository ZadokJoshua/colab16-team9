using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrCarQuotes_Domain.Entities;

public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Make { get; set; }

    [StringLength(50)]
    public string? Model { get; set; }

    public int Year { get; set; }

    public string? ImageUrl { get; set; }

    ICollection<Quote> Quotes { get; set; } = new List<Quote>();
}
