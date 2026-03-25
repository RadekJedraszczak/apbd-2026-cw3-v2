namespace ConsoleRentApp;

public class Stuff
{
    //private String itemName;
    //private int cost;
    //private String condition;

    public Stuff(String itemName, int cost, String condition,String brand)
    {
        this.itemName = itemName;
        this.cost = cost;
        this.condition = condition;
        this.brand = brand;
    }
        public String itemName { get; set; }
        public int cost { get; set; }
        public String condition { get; set; }
        public String brand { get; set; }
    }
