namespace ConsoleRentApp;

public class Laptop : Stuff
{
    public Laptop(String itemName, int cost,
        String condition, String brand, int screenSize) 
        : base(itemName, cost ,condition,brand)
    {
        this.screenSize = screenSize;
    }
        public int screenSize{get;set;}
    

}