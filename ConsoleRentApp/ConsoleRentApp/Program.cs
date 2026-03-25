namespace ConsoleRentApp;

class Program
{
    static void Main(string[] args)
    {
        RentService rentService = new RentService();
        rentService.AddSampleData();

        while (true)
        {
            Console.WriteLine("===== Wypożyczalnie sprzętu =====");
            Console.WriteLine("1. Wyświetl dostępny sprzęt");
            Console.WriteLine("2. Wypożycz sprzęt");
            Console.WriteLine("3. Zwróć sprzęt");
            Console.WriteLine("4. Użytkownicy");
            Console.WriteLine("0. Wyjście");
            Console.WriteLine("Wybierz opcję: ");
            
            String choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Sprzęt: ");
                foreach (var item in rentService.Items)
                {
                    String Id = item.Id.ToString();
                    Console.WriteLine($"ID: {Id} | {item.Name} ({item.Brand}) | Status: {item.Status}");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Użytkownicy: ");
                foreach (var user in rentService.Users)
                {
                    string shortId = user.UserId.ToString();
                    Console.WriteLine($"ID: {shortId} | Limit: {user.MaxRentalLimit}");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Podaj Id użytkownika: ");
                string uId = Console.ReadLine();
                Console.WriteLine("Podaj Id sprzętu: ");
                string iId = Console.ReadLine();
                
                rentService.RentItem(uId, iId);
            }
            else if (choice == "3")
            {
                Console.WriteLine("Podaj id zwracanego sprzętu: ");
                string rId = Console.ReadLine();
                
                rentService.ReturnItem(rId);
            }
            else if (choice == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Nieznana opcja");
            }
        }
    }
}