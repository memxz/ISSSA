using AvgResponseTime_net6.Middlewares;
using Microsoft.EntityFrameworkCore;
using AvgResponseTime_net6.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ResponseTracker>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// install our custom middleware
app.UseMiddleware<CycleTimer>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Stats}/{id?}");

app.Run();

