var imie = "Maciej";
var plec = "M";
var wiek = 43;

if (plec != "M")
{
    if (wiek < 33)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Ewa, lat 33");
    }

}
else
{
    if (wiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Maciej, lat 43");
    }
}
