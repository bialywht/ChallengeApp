int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

List<string> labels = new List<string>();
labels.Add("0 => ");
labels.Add("1 => ");
labels.Add("2 => ");
labels.Add("3 => ");
labels.Add("4 => ");
labels.Add("5 => ");
labels.Add("6 => ");
labels.Add("7 => ");
labels.Add("8 => ");
labels.Add("9 => ");


int[] numbers = new int[10];


foreach (char c in letters)
{
    if (c == '0')
    {
        numbers[0] = numbers[0] + 1;
    }
    else if (c == '1') 
    {
        numbers[1] = numbers[1] + 1;
    }
    else if (c == '2')
    {
        numbers[2] = numbers[2] + 1;
    }
    else if(c == '3')
    {
        numbers[3] = numbers[3] + 1;
    }
    else if(c == '4')
    {
        numbers[4] = numbers[4] + 1;
    }
    else if (c == '5') 
    {
        numbers[5] = numbers[5] + 1;
    }    
    else if (c == '6')
    {
        numbers[6] = numbers[6] + 1;
    }
    else if (c == '7')
    {
        numbers[7] = numbers[7] + 1;
    }
    else if(c == '8')
    {
        numbers[8] = numbers[8] + 1;
    }
    else if(c == '9')
    {
        numbers[9] = numbers[9] + 1;
    }
}


Console.Write("Wyniki dla liczby: ");
Console.WriteLine(number);

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(labels[i]);
    Console.WriteLine(numbers[i]);
}


