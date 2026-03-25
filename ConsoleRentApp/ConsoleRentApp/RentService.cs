using System.Diagnostics;

namespace ConsoleRentApp;

public class RentService
{
    public List<User> Users = new List<User>();
    public List<Item> Items = new List<Item>();
    public List<Rent> Rents = new List<Rent>();

    public void AddSampleData()
    {
        Users.Add(new Student("Jan", "Kowalski", "s12345"));
        Users.Add(new Employee("Anna", "Nowak", "IT"));

        Items.Add(new Laptop("ThinkPad", "Lenovo", 14, 16));
        Items.Add(new Camera("EOS", "Canon", "50mm", true));
        Items.Add(new Projector("W1000", "BenQ", "1080p", 2000));
    }

    public void RentItem(string userIdPref, string itemIdPref)
    {
        User selectedUser = null;
        foreach (var u in Users)
        {
            if (u.UserId.ToString().StartsWith(userIdPref))
            {
                selectedUser = u;
            }
        }
        Item selectedItem = null;
        foreach (var i in Items)
        {
            if (i.Id.ToString().StartsWith(itemIdPref))
            {
                selectedItem = i;
            }
        }

        if (selectedUser == null || selectedItem == null)
        {
            Console.WriteLine("Błąd nie znaleziono użytkownika lub sprzętu");
            return;
        }

        if (selectedItem.Status != ItemStatus.Available)
        {
            Console.WriteLine("Błąd: Sprzęt nie jest dostępny");
            return;
        }

        int activeRentals = 0;
        foreach (var r in Rents)
        {
            if (r.Renter.UserId == selectedUser.UserId && r.IsActive)
            {
                activeRentals++;
            }
        }

        if (activeRentals >= selectedUser.MaxRentalLimit)
        {
            Console.WriteLine("Błąd: Użytkownik osiągnał limit ( " + selectedUser.MaxRentalLimit + ")");
            return;
        }
        
        selectedItem.Status = ItemStatus.Rented;
        Rents.Add(new Rent(selectedUser, selectedItem, DateTime.Now));
        Console.WriteLine("Wypożyczono ");
    }

    public void ReturnItem(string itemIdPref)
    {
        foreach (var rent in Rents)
        {
            if (rent.Item.Id.ToString().StartsWith(itemIdPref) && rent.IsActive)
            {
                rent.MarkAsReturned(DateTime.Now);
                Console.WriteLine("Sprzęt został zwrócony");

                if (rent.AdditionalCost > 0)
                {
                 Console.WriteLine("Naliczono karę za opóźnienie: " + rent.AdditionalCost + " zł");   
                }
                return;
            } 
        }
         Console.WriteLine("Nie znaleziono aktywnego wypożyczenia dla tego sprzętu");
    }
}