string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputOneNumber = int.Parse(inputline);


if  (inputOneNumber % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
}

