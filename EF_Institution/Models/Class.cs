using System;
namespace EF_Institution.Models;

public class Class
{
    public Class()
    {
        Id = new Guid();
    }

    public Guid Id { get; set; }

    public DateTime? Date { get; set; }

    public virtual Course? Course { get; set; }
    public virtual Lecturer? Lecturer { get; set; }
}