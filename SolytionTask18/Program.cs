string? inputline = Console.ReadLine();

void printAnswer(int Number)

{


    if(Number==1) Console.WriteLine("Допустимо: x>0, y>0");
    if(Number==2) Console.WriteLine("Допустимо: x<0, y>0");
    if(Number==3) Console.WriteLine("Допустимо: x<0, y<0");
    if(Number==4) Console.WriteLine("Допустимо: x>0, y<0");

}

string? inputLine = Console.ReadLine();

if(inputLine !=null)
{
      
      int inputNumber = int.Parse(inputline);

printAnswer(inputNumber);
}
