namespace ConsoleRentApp;

public class Rent

{
    public Guid id { get; } = Guid.NewGuid();
    public User Renter { get; }
    public Item Item { get; }
    public DateTime RentDate { get; }
    public DateTime ExpectedReturnDate { get; }
    public DateTime ActualReturnDate { get; set; }
    public double AdditionalCost { get; set; }

    public bool IsActive => ActualReturnDate == null;
    public bool IsOver(DateTime checkDate) => IsActive && checkDate > ExpectedReturnDate;
    
    public Rent(User renter, Item item, DateTime rentDate)
    {
        this.Renter = renter;
        this.Item = item;
        this.RentDate = rentDate;
        this.ExpectedReturnDate = rentDate.AddDays(RentalRules.DeafualtRentalDays);
    }
    public void MarkAsReturned(DateTime returnDate)
    {
        this.ActualReturnDate = returnDate;
        Item.Status = ItemStatus.Available;
        if (returnDate > ExpectedReturnDate)
        {
            int delayDays = (returnDate - ExpectedReturnDate).Days;
            AdditionalCost = delayDays * RentalRules.DailyDelayExtraCost;
        }
    }
}
public class RentalRules
{
    public const int StudentMaxActiveRentals = 2;
    public const int EmployeeMaxActiveRentals = 5;
    public const double DailyDelayExtraCost = 10.0;
    public const int DeafualtRentalDays = 7;
}