string? inputOneLine = Console.ReadLine();
string? inputTwoLine = Console.ReadLine();

if (inputOneLine != null && inputTwoLine != null)
{
    int inputOneNumber = int.Parse(inputOneLine);
    int inputTwoNumber = int.Parse(inputTwoLine);
    
    if (inputOneNumber > inputTwoNumber)
    {
        Console.WriteLine(inputOneNumber);
    }
    else
    {
        Console.WriteLine(inputTwoNumber);
    }
}