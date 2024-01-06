

using ChallengeApp;

Employee employee1 = new Employee("Jędrzej", "Czura");
//Employee employee2 = new Employee("Remigiusz", "Butkiewicz");
//Employee employee3 = new Employee("Edyta", "Grzywacz");

employee1.AddGrade(8);
employee1.AddGrade(6);
employee1.AddGrade(9);
employee1.AddGrade("1");
employee1.AddGrade(3);
//employee2.AddGrade(5);
//employee2.AddGrade(1);
//employee2.AddGrade(10);
//employee2.AddGrade(8);
//employee2.AddGrade(9);
//employee3.AddGrade(9);
//employee3.AddGrade(8);
//employee3.AddGrade(2);
//employee3.AddGrade(1);
//employee3.AddGrade(3);
var statistics1 = employee1.GetStatisticsWithForEach();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();
var statistics4 = employee1.GetStatisticsWithWhile();


Console.WriteLine($"ForEach - min: {statistics1.Min}, max: {statistics1.Max}, average: {statistics1.Average}");
Console.WriteLine($"For - min: {statistics2.Min}, max: {statistics2.Max}, average: {statistics2.Average}");
Console.WriteLine($"DoWhile - min: {statistics3.Min}, max: {statistics3.Max}, average: {statistics3.Average}");
Console.WriteLine($"While - min: {statistics4.Min}, max: {statistics4.Max}, average: {statistics4.Average}");




List<Employee> employees = new List<Employee>() {employee1};
int bestResult = -1;
Employee bestResultEmployee = null;

foreach (Employee employee in employees)
{
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Maksymalna ocena {statistics.Max}");
    Console.WriteLine($"Minimalna ocena {statistics.Min}");
    Console.WriteLine($"Średnia ocena {statistics.Average:N2}");
    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.BestResult}");
    if (employee.BestResult > bestResult)
    {

        bestResult = (int)employee.BestResult;
        bestResultEmployee = employee;

    }

}

//Console.WriteLine($"Pracownik z najwyższą liczbą ocen ({bestResultEmployee.BestResult}) to {bestResultEmployee.FirstName} {bestResultEmployee.LastName}.");

