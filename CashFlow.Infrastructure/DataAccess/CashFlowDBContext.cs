using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

public class CashFlowDBContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflowfb;User=root;Password=root;";
        var serverVersion = new MySqlServerVersion(new Version(9, 0, 1)); // Adjust version as needed
        
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}