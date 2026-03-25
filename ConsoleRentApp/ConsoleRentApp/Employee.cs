namespace ConsoleRentApp;

public class Employee : User
{
    private String profession;
    
    Employee(String name, String surname, String username, String password, String profession )
        : base(name, surname, username, password)
    {
        this.profession = profession;
    }
    
    public String Profession { get; set; }
}