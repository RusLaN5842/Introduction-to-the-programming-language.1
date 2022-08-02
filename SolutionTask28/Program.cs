//Console.Write("Введите число: ");
//введите число
//string? inputLine = Console.ReadLine();
// вещественный тип
//int inputNum = int.Parse(inputLine);
//выдаем и передаем число
//Console.WriteLine(sumNums(inputNum));
// выдающий и принимающий метод
//int sumNums(int num)
//{
    //int sum = 1;
    //for (int i = 1; i <= inputNum; i++)
    //{
      //  sum *= i;
    //}
  //  return sum;
//}

//Рекурентное решение
Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);
int t;

t = Environment.TickCount;
Console.WriteLine(sumNums(inputNum));
Console.Wrineline("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
Console.Wrineline("Simple time: {0} ms", Environment.TickCount - t);
Console.WriteLine(mulRec(inputNum));

int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}

int mulRec(int num) 
{
    if (num == 1) {
        return 1;
    } else {
        return num * mulRec(num - 1);
    }
}
