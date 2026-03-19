namespace ConsoleRentApp;

public class Camera : Stuff
{
    public Camera(String stuffName, int cost,
        String condition, String brand, String lensData) 
        : base(stuffName, cost, condition, brand)
    {
        this.stuffName = stuffName;
        this.cost = cost;
        this.condition = condition;
        this.brand = brand;
        this.lensData =  lensData;
    }
    
    public String lensData { get; set; }
        
}