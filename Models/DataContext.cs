using Microsoft.EntityFrameworkCore;

namespace Intro;

public class PRailContext : DbContext
{
    public PRailContext(DbContextOptions<PRailContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customer { get; set; }
    public DbSet<Passenger> Passenger { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
}

public class Passenger
{
    public int PassengerId { get; set; }
    public string PassengerName { get; set; }
    public DateTime DateOfBirth { get; set; }
}