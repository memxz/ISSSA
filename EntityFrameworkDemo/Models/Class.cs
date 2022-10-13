using System;
namespace EntityFrameworkDemo.Models;

public class Class
{
    public Class()
    {
        Id = new Guid();
        Lecturer = new List<Lecturer>();
    }

    public Guid Id { get; set; }

    public DateTime? Date { get; set; }
    public float? Price { get; set; }

    public virtual Course? Course { get; set; }
    public virtual ICollection<Lecturer> Lecturer { get; set; }
}