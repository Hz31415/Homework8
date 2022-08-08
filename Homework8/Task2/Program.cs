Dictionary<string, string> tBook = new Dictionary<string, string>();

while (true)
{
    string key;
    string value;
    string inputString;
    Console.WriteLine("Please type the telephone number");
    inputString = Console.ReadLine();

    if (inputString == "\n")
    {
        break;
    }

    key = inputString;

    Console.WriteLine("Please type full name");
    inputString = Console.ReadLine();
    value = inputString;

    tBook.Add(key, value);
}

while (true)
{
    Console.WriteLine("Search number:");
    string inputString = Console.ReadLine();
    if (inputString == "\n")
    {
        break;
    }

    if (tBook.ContainsKey(inputString))
    {
        Console.WriteLine($"{inputString} - {tBook[inputString]}");
    }
}
