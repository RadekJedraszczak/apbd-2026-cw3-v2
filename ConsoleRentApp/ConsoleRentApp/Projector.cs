namespace ConsoleRentApp;

public class Projector : Stuff
{
    public Projector(String itemName, int cost, String condition, String brand, String type) 
        : base(itemName, cost, condition,brand)
    {
        
        this.type = type;
    }
    
    public String type { get; set; }
}