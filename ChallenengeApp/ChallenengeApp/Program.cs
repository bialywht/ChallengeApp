var name = "Teresa";
var gender = "F";
var age = 60;

if (gender == "F")
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age >= 30)
    {
        Console.WriteLine("Kobieta powyżej 30 lat, ale nie Ewa");
    }

}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }

}