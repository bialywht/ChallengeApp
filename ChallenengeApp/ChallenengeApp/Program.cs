

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

Console.WriteLine($"Pracownik z najwyższą liczbą ocen ({bestResultEmployee.BestResult}) to {bestResultEmployee.FirstName} {bestResultEmployee.LastName}.");

