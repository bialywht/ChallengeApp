var name = "Ewa";
var gender = "F";
var age = 30;

if (gender == "F")
{

    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age >= 30 && age < 33 || age > 33)
    {
        Console.WriteLine("Kobieta powyżej 30 lat, niebędąca 33-letnią Ewą");
    }
    else
    {
        if (name == "Ewa")
        {
            Console.WriteLine("Ewa, lat 33");
        }
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