namespace ConsoleRentApp;

public class Stuff
{
    //private String stuffName;
    //private int cost;
    //private String condition;

    public Stuff(String stuffName, int cost, String condition,String brand)
    {
        this.stuffName = stuffName;
        this.cost = cost;
        this.condition = condition;
        this.brand = brand;
    }
        public String stuffName { get; set; }
        public int cost { get; set; }
        public String condition { get; set; }
        public String brand { get; set; }
    }
