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
    employee1.AddGrade(input);
}

var statistics = employee1.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Srednia: {statistics.Average}");
Console.WriteLine($"Średnia litera: {statistics.AverageLetter}");





//List<Employee> employees = new List<Employee>() {employee1};
//int bestResult = -1;
//Employee bestResultEmployee = null;


//var statistics = employee1.GetStatistics();
//Console.WriteLine($"Maksymalna ocena {statistics.Max}");
//Console.WriteLine($"Minimalna ocena {statistics.Min}");
//Console.WriteLine($"Średnia ocena {statistics.Average:N2}");
//Console.WriteLine($"Średnia litera {statistics.AverageLetter}");
//Console.WriteLine($"{employee1.FirstName} {employee1.LastName} {employee1.BestResult}");


//Console.WriteLine($"Pracownik z najwyższą liczbą ocen ({bestResultEmployee.BestResult}) to {bestResultEmployee.FirstName} {bestResultEmployee.LastName}.");

