string? inputLkneOne = Console.ReadLine();

if(inputLkneOne !=null)
{

int inputNumber = int.Parse(inputLkneOne);

int startNumber = 2;

string LineOutput = "";

while (startNumber <= inputNumber)

{
    LineOutput = LineOutput + ", " + startNumber;
    startNumber = startNumber + 2;
}

Console.WriteLine(LineOutput);
}



       

    