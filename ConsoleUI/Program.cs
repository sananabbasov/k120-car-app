

using ConsoleUI.Models;
using ConsoleUI.Services;

Car bmw = new()
{
    Id = 1,
    Name = "X5",
    MaxFuel = 83,
    Kmpl = 12,
    Fuel = 45,
    Mileage = 0
};

Car volswagen = new()
{
    Id = 2,
    Name = "Passat CC",
    MaxFuel = 70,
    Fuel = 45,
    Kmpl = 10,
    Mileage = 12,
};

CarManager carManager = new();



Console.WriteLine("1. Herekete basla.");
Console.WriteLine("2. YDM");
Console.WriteLine("3. Serfiyyat");



while (true)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Reqem daxil edin");
    Console.ResetColor();
    int userSelection = Convert.ToInt32(Console.ReadLine());

    switch (userSelection)
    {
        case 1:
            Console.WriteLine("Gedilecek yolu daxil edin.");
            int userKm = Convert.ToInt32(Console.ReadLine());
            carManager.Start(bmw, userKm);
            break;

        case 2:

            break;

        case 3:

            break;
        case 4:
            
            break;
        default:

            break;
    }
}