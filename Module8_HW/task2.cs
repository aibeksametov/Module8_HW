using System;

public class Program
{
    static void Main()
    {
        double heatingRate = 10; 
        double waterRate = 5; 
        double gasRate = 7; 
        double repairRate = 3; 

        double roomArea = 100; 
        int numberOfResidents = 4;
        string season = "Winter"; 
        bool veteranOfLabor = true;
        bool warVeteran = false; 

        double heatingCost = roomArea * heatingRate;
        double waterCost = numberOfResidents * waterRate;
        double gasCost = numberOfResidents * gasRate;
        double repairCost = roomArea * repairRate;

        if (season == "Winter")
        {
            heatingCost *= 1.2; 
        }

        double totalCost = heatingCost + waterCost + gasCost + repairCost;

        if (veteranOfLabor)
        {
            totalCost *= 0.7; 
        }

        if (warVeteran)
        {
            totalCost *= 0.5; 
        }

        Console.WriteLine("Type of payment\tAccrued\tThe total discount\tTotal");
        Console.WriteLine($"Heating\t{heatingCost:C}\t-\t{heatingCost:C}");
        Console.WriteLine($"Water\t\t{waterCost:C}\t-\t{waterCost:C}");
        Console.WriteLine($"Gas\t\t{gasCost:C}\t-\t{gasCost:C}");
        Console.WriteLine($"Repair\t\t{repairCost:C}\t-\t{repairCost:C}");
        Console.WriteLine($"Total Cost\t\t{totalCost:C}");
    }
}
