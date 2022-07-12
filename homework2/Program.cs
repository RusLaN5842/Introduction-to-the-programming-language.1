string? inputOneLine = Console.ReadLine();
string? inputTwoLine = Console.ReadLine();
string? inputThreeLine = Console.ReadLine();
if (inputOneLine != null && inputTwoLine != null && inputThreeLine !=null)
{
    int inputOneNumber = int.Parse(inputOneLine);
    int inputTwoNumber = int.Parse(inputTwoLine);
    int inputThreeNumber = int.Parse(inputThreeLine);
    int maxNumber = inputOneNumber;
    if (inputTwoNumber > maxNumber)
{
    maxNumber = inputTwoNumber;
}
if (inputThreeNumber > maxNumber)
{
    maxNumber = inputThreeNumber;
}
Console.WriteLine(maxNumber);
}
