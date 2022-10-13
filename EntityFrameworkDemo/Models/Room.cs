using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Models;

public class Room
{
    public Room()
    {
        Id = new Guid();
    }

    public Guid Id { get; set; }

    [Required]
    public string? Number { get; set; }

    [ForeignKey("LecturerId")]
    public virtual Lecturer? Lecturer { get; set; }
}