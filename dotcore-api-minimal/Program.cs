using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.UseSwaggerUI();
    
app.MapGet("/sales", (dbContext db) =>
{
    ICollection<Sales> sales = db.Sales.ToList();

    return Results.Ok(sales);
});

app.MapGet("/sales/{id}", async (long id, dbContext db) =>
{
    Sales sales = await db.Sales.FindAsync(id);

    return Results.Ok(sales);
});

app.MapPost("/sales", async (Sales sales, dbContext db) =>
{
    await db.Sales.AddAsync(sales);

    await db.SaveChangesAsync();

    return Results.Created("/sales", sales);
});

app.MapPut("/sales", async (long id, Sales sale, dbContext db) =>
{
    db.Entry(sale).State = EntityState.Modified;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/sales", async (long id, dbContext db) =>
{
    Sales sale = await db.Sales.FindAsync(id);

    if(sale != null)
    {
        db.Sales.Remove(sale);
        await db.SaveChangesAsync();
    }

    return Results.Ok();
});

app.Run();

public class dbContext : DbContext
{    public DbSet<Sales> Sales {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=YourHost;Database=Company;User Id=YourUser;Password=YourPassword;");
}

public record Sales(long Id, DateTime DataTime, string Seller, double Price);