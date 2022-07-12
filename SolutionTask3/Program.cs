string? inputLkneOne = Console.ReadLine();

if(inputLkneOne !=null)
{

int inputNumber = int.Parse(inputLkneOne);

int startNumber = (inputNumber * -1);

string LineOutput = "0";

while (startNumber <= inputNumber)

{
    LineOutput = startNumber*(-1)+", "+LineOutput+", "+startNumber;
    startNumber++;
}

Console.WriteLine(LineOutput);
}



       

    