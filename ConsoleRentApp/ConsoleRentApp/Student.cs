namespace ConsoleRentApp;

public class Student : User
{
    private String sNumber;
    
    Student(String name, String surname, String username, String password, String sNumber)
        : base(name, surname, username, password)
    {
        this.sNumber = sNumber;
    }
    
    public String SNumber { get; set; }
}