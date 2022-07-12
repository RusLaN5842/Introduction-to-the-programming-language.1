string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);

    int outNumber = inputNumber*inputNumber;

    Console.WriteLine(outNumber);
}

