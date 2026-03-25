namespace ConsoleRentApp;

public abstract class User
{
    public Guid UserId { get; } = Guid.NewGuid();
    public String name;
    public String surname;
    
    public abstract int MaxRentalLimit { get; }

    public User(String name, String surname)
    {
        this.name = name;
        this.surname = surname;
    }

    public override string ToString()
    {
        return $"[{UserId.ToString().Substring(0,8)}] {name} {surname} ({GetType().Name})";
    }
}
public class Student : User
{
    public String sNumber { get; set; }
    public override int MaxRentalLimit => RentalRules.StudentMaxActiveRentals;

    public Student(String name, String surname, String sNumber)
        : base(name, surname)
    {
        this.sNumber = sNumber;
    }
}

public class Employee : User
{
    public String Department { get; set; }
    public override int MaxRentalLimit => RentalRules.EmployeeMaxActiveRentals;
    
    public Employee(String name, String surname, String department)
        : base(name, surname)
    {
        this.Department = department;
    }
    
    
}