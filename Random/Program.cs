using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Who wants a new hobby?");
        string name = Console.ReadLine();

        string[] hobbies = {
            "Footballplayer",
            "Cashier",
            "Hockeyplayer",
            "Driver",
            "Deliveryperson",
            "Busdriver"
        };

        Random rand = new Random();
        var hobby = rand.Next(0, hobbies.Length);

        Console.WriteLine($"{name} is now a {hobbies[hobby]}");
    }
}



