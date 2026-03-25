namespace ConsoleRentApp;

public class Camera : Stuff
{
    public Camera(String itemName, int cost,
        String condition, String brand, String lensData) 
        : base(itemName, cost, condition, brand)
    {
        this.lensData =  lensData;
    }
    
    public String lensData { get; set; }
        
}