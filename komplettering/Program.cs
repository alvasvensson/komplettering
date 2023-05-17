

static string GiveMeANumberBetween(int min, int max)
{
    int i = 0;
    string result = "";
    while (i < 10)
    {
        Console.WriteLine("Skriv en siffra mellan 1 och 10");
        string text;
        text = Console.ReadLine();
        int number = int.Parse(text);
        if (number > min && number < max)
        {
            result = "Yes, thank you";
            i++;
        }
        else
        {
            result = "No, that's not what I asked for";
        }
        Console.WriteLine(result);
    }
    return result;

}

Console.WriteLine(GiveMeANumberBetween(1, 10));

Console.ReadLine();
