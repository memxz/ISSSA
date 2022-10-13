using System;
using System.ComponentModel.DataAnnotations;

namespace Workshop_EF_Core.Models;

public class Course
{
    public Course()
    {
        Id = new Guid();
        Class = new List<Class>();
    }

    public Guid Id { get; set; }

    [Required]
    public string? Code { get; set; }

    [Required]
    public string? Title { get; set; }

    public virtual ICollection<Class> Class { get; set; }
}

