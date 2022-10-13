using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Workshop_EF_Core.Models;

public class Room
{
    public Room()
    {
        Id = new Guid();
        Lecturer = new List<Lecturer>();
    }

    public Guid Id { get; set; }

    [Required]
    public string? Number { get; set; }

    public virtual ICollection<Lecturer> Lecturer { get; set; }
}

