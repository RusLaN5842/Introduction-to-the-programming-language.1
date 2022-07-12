string? inputline = Console.ReadLine();

if(inputline != null)
{
    int inputNumber = int.Parse(inputline);

    int outputNumber = inputNumber%10;

    Console.WriteLine(outputNumber);
}