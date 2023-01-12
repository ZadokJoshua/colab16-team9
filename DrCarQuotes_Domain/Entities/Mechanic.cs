﻿using DrCarQuotes_Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechanicQuotes_Domain.Entities;

public class Mechanic
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(15)]
    public string? Phone { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [StringLength(10)]
    public string? ZipCode { get; set; }
    ICollection<Quote> Quotes { get; set; } = new List<Quote>();
}
