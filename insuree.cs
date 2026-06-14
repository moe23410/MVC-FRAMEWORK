using System;

public class Class1
{
	public Class1()
	{
	}
}
public class Insuree
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int CarYear { get; set; }
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public bool DUI { get; set; }
    public int SpeedingTickets { get; set; }
    public bool CoverageType { get; set; } // true = Full, false = Liability
    public decimal Quote { get; set; }
}
using System.Data.Entity;

public class InsuranceContext : DbContext
{
    public DbSet<Insuree> Insurees { get; set; }
}
static void Main(string[] args)
{
    using (var db = new InsuranceContext())
    {
        var newInsuree = new Insuree();

        Console.WriteLine("Enter First Name:");
        newInsuree.FirstName = Console.ReadLine();

        // ... Continue collecting all other fields (CarYear, DUI, etc.) ...

        // Insert your calculation logic here (exactly as you wrote it previously)
        decimal baseQuote = 50m;
        // ... calculation steps ...
        newInsuree.Quote = baseQuote;

        // Save to Database
        db.Insurees.Add(newInsuree);
        db.SaveChanges();

        Console.WriteLine($"Quote generated successfully! Total: {newInsuree.Quote:C}");
    }
}

