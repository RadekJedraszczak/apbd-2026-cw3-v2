namespace ConsoleRentApp;

public class Rent
{
    private String rentDate;
    private String rentReturnDate;
    private String actualReturnDate;
    private int additionalCost;

    Rent(String rentDate, String rentReturnDate, String actualReturnDate, int additionalCost)
    {
        this.rentDate = rentDate;
        this.rentReturnDate = rentReturnDate;
        this.actualReturnDate = actualReturnDate;
        this.additionalCost = additionalCost; 
    }
}