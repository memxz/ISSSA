using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Institution.Models;

public class Room
{
    public Room()
    {
        Id = new Guid();
        Lecturer = new List<Lecturer>();
    }
    [Column]
    public Guid Id { get; set; }

    [Required]
    public string? Number { get; set; }

    public virtual ICollection<Lecturer> Lecturer { get; set; }
}

