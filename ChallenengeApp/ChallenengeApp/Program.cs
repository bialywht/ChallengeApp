using ChallengeApp;




Console.WriteLine("=====================================");
Console.WriteLine("|                                   |");
Console.WriteLine("|  Program do oceny pracowników.    |");
Console.WriteLine("|                                   |");
Console.WriteLine("|                                   |");
Console.WriteLine("=====================================");


Employee employee1 = new Employee();
var input = "";



while(true)
{
    Console.Write("Podaj ocenę pracownika (0-100): ");
    input = Console.ReadLine();

    if (input == "Z")
    {
        break;
    }

    try
    {
        employee1.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }



}

var statistics = employee1.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Srednia: {statistics.Average}");
Console.WriteLine($"Średnia litera: {statistics.AverageLetter}");







