namespace ConsoleRentApp;

public class Laptop : Stuff
{
    public Laptop(String stuffName, int cost,
        String condition, String brand, int screenSize) 
        : base(stuffName, cost ,condition,brand)
    {
        this.stuffName = stuffName;
        this.cost = cost;
        this.condition = condition;
        this.brand = brand;
        this.screenSize = screenSize;
    }
        public int screenSize{get;set;}
    

}