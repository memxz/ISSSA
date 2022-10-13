using System;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using DigiShop.Models;

namespace DigiShop.Infrastructure;

public class MyDbContext : DbContext
{
    /*protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        string db_conn = @"Server=localhost;Database=ShoppingCartDB;User ID=sa;Password=root";
        opt.UseLazyLoadingProxies().UseSqlServer(db_conn);
    }*/
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    { }

    public DbSet<Product> Product { get; set; }
    public DbSet<Cart> Cart { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Customer> Customer { get; set; }
}

