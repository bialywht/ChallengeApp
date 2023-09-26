

using ChallengeApp;

Employee employee1 = new Employee("Jędrzej", "Czura", "57");
Employee employee2 = new Employee("Remigiusz", "Butkiewicz", "42");
Employee employee3 = new Employee("Edyta", "Grzywacz", "35");

employee1.AddGrade(8);
employee1.AddGrade(7);
employee1.AddGrade(9);
employee1.AddGrade(6);
employee1.AddGrade(3);
employee2.AddGrade(5);
employee2.AddGrade(1);
employee2.AddGrade(10);
employee2.AddGrade(8);
employee2.AddGrade(9);
employee3.AddGrade(9);
employee3.AddGrade(8);
employee3.AddGrade(2);
employee3.AddGrade(1);
employee3.AddGrade(3);


Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " - " + employee1.BestResult);
Console.WriteLine(employee2.FirstName + " " + employee2.LastName + " - " + employee2.BestResult);
Console.WriteLine(employee3.FirstName + " " + employee3.LastName + " - " + employee3.BestResult);


if ((employee1.BestResult > employee2.BestResult) && (employee1.BestResult > employee3.BestResult))
{
    Console.WriteLine("Pracownik z najwyższą liczbą ocen (" + employee1.BestResult + ") to " + employee1.FirstName + " " + employee1.LastName + ".");
}
else if ((employee1.BestResult > employee2.BestResult) && (employee1.BestResult < employee3.BestResult))
{
    Console.WriteLine("Pracownik z najwyższą liczbą ocen (" + employee3.BestResult + ") to " + employee3.FirstName + " " + employee3.LastName + ".");
}
else if ((employee1.BestResult < employee2.BestResult) && (employee2.BestResult > employee3.BestResult))
{
    Console.WriteLine("Pracownik z najwyższą liczbą ocen (" + employee2.BestResult + ") to " + employee2.FirstName + " " + employee2.LastName + ".");
}
else
{
    Console.WriteLine("Inne przypadki, w których nie ma jednego pracownika z najwyższą liczbą ocen.");
}