﻿using ChallengeApp;
using System.Runtime.CompilerServices;




Console.WriteLine("=====================================");
Console.WriteLine("|                                   |");
Console.WriteLine("|  Program do oceny pracowników.    |");
Console.WriteLine("|                                   |");
Console.WriteLine("|                                   |");
Console.WriteLine("=====================================");


EmployeeInFile employee1 = new EmployeeInFile();
var input = "";

employee1.AddGrade("B");


//while (true)
//{
//    Console.Write("Podaj ocenę pracownika (0-100): ");
//    input = Console.ReadLine();

//    if (input == "Z")
//    {
//        break;
//    }

//    try
//    {
//        employee1.AddGrade(input);

//        //var addedGrade = employee1.AddGrade(input);

//        //Console.WriteLine(addedGrade.ToString());
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }



//}

var statistics = employee1.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Srednia: {statistics.Average}");
Console.WriteLine($"Średnia litera: {statistics.AverageLetter}");







