using System;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using EF_Institution.Models;

namespace EF_Institution;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        string db_conn = @"Server=localhost;Database=ShoppingCartDB;User ID=sa;Password=root";
        opt.UseLazyLoadingProxies().UseSqlServer(db_conn);
    }

    public DbSet<Course>? Course { get; set; }
    public DbSet<Class>? Class { get; set; }
    public DbSet<Lecturer>? Lecturer { get; set; }
    public DbSet<Room>? Room { get; set; }
}

