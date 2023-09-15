int[] grades = new int[1];
List<string> daysOfWeek = new List<string>();
daysOfWeek.Add("poniedziałek");
daysOfWeek.Add("wtorek");
daysOfWeek.Add("środa");
daysOfWeek.Add("czwartek");
daysOfWeek.Add("piątek");
daysOfWeek.Add("sobota");
daysOfWeek.Add("niedziela");

//Console.WriteLine(daysOfWeek[3]);

List<string> months = new List<string>{ "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
//Console.WriteLine(months[5]);

foreach(string day in daysOfWeek)
{
    Console.WriteLine(day);
}

foreach (string month in months)
{
    Console.WriteLine(month);
}

