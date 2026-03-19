namespace ConsoleRentApp;

public class Projector : Stuff
{
    public Projector(String stuffName, int cost, String condition, String brand, String type) 
        : base(stuffName, cost, condition,brand)
    {
        this.stuffName = stuffName; 
        this.cost = cost;
        this.condition = condition;
        this.brand = brand;
        this.type = type;
    }
    
    public String type { get; set; }
}