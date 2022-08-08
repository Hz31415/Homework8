
List<int> list= new List<int>();
Random random= new Random();

for (int i = 0; i < 100; i++)
{
    list.Add(random.Next(0, 100));
}

foreach (int item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n\n\n");

for (int i = 0; i < list.Count; i++)
{
    if (list[i] > 25 && list[i] < 50)
    { 
        list.RemoveAt(i--);
    }
}

foreach (int item in list)
{
    Console.WriteLine(item);
}