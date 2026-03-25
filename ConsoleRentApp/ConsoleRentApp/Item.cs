namespace ConsoleRentApp;

public abstract class Item
{
    public Guid Id { get; } = Guid.NewGuid();
    public String Name { get; set; }
    public String Brand { get; set; }
    public ItemStatus Status{ get; set;} = ItemStatus.Available;
    
    
    public Item(String Name, String Brand)
    {
        this.Name = Name;
        this.Brand = Brand;
    }

    public override string ToString()
    {
        return $"[{Id.ToString().Substring(0, 8)}] {Name} ({Brand}) - Status: {Status}";
    }
}

public enum ItemStatus
{
    Available, Rented, Unavailable
}

public class Camera : Item
{
    public String LensType {get; set;}
    public bool withFlash {get; set;}

    public Camera(String name, String brand, String lensType, bool withFlash): base(name, brand)
    {
        this.LensType = lensType;
        this.withFlash = withFlash;
    }
}

public class Projector : Item
{
    public String Resolution { get; set; }
    public int LensType { get; set; }

    public Projector(String name, String brand, String resolution, int lensType) : base(name, brand)
    {
        this.Resolution = resolution;
        this.LensType = lensType;
    }
}

public class Laptop : Item
{
    public int screenSize{get;set;}
    public int ramSizeGb{get;set;}
    public Laptop(String name, String brand, int screenSize, int ramSizeGb) 
        : base(name,brand)
    {
        this.screenSize = screenSize;
        this.ramSizeGb = ramSizeGb;
    }
}