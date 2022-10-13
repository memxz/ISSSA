using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkDemo.Models;

public class Lecturer
{
    public Lecturer()
    {
        Id = new Guid();
        Class = new List<Class>();
    }

    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Email { get; set; }

    public virtual Room? Room { get; set; }
    public virtual ICollection<Class> Class { get; set; }
}