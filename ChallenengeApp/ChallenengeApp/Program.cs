using ChallengeApp;
using System.Runtime.CompilerServices;




Console.WriteLine("=====================================");
Console.WriteLine("|                                   |");
Console.WriteLine("|  Program do oceny pracowników.    |");
Console.WriteLine("|                                   |");
Console.WriteLine("|                                   |");
Console.WriteLine("=====================================");


//EmployeeInFile employee1 = new EmployeeInFile();
EmployeeInMemory employee = new EmployeeInMemory();
employee.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano ocenę");
}

employee.AddGrade('a');




//while (true)
//{
//    Console.Write("Podaj ocenę pracownika (0-100): ");
//    var input = Console.ReadLine();

//    if (input == "Z")
//    {
//        break;
//    }

//    try
//    {
//        employee2.AddGrade(input);

//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }



//}

//var statistics = employee2.GetStatistics();
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Srednia: {statistics.Average}");
//Console.WriteLine($"Średnia litera: {statistics.AverageLetter}");







