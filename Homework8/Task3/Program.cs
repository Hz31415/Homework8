using System.Collections.Generic;

HashSet<int> hashSet = new HashSet<int>();

while (true)
{
    Console.WriteLine("Insert number");
    string inputString = Console.ReadLine();

    if (inputString == "\n" || inputString == null)
    {
        break;
    }

    int inputNum = int.Parse(inputString);
    if (hashSet.Contains(inputNum))
    {
        Console.WriteLine("This number is already inserted");
    }
    else
    {
        hashSet.Add(inputNum);
        Console.WriteLine("Your number saved successfully");
    }
}
