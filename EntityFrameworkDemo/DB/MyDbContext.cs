using System;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkDemo.Models;

namespace EntityFrameworkDemo;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        string db_conn = @"Server=localhost;Database=EntityFrameworkDemoDB;User ID=sa;Password=SQLServer@2019!";
        opt.UseLazyLoadingProxies().UseSqlServer(db_conn);
    }

    public DbSet<Course>? Course { get; set; }
    public DbSet<Class>? Class { get; set; }
    public DbSet<Lecturer>? Lecturer { get; set; }
    public DbSet<Room>? Room { get; set; }
}

