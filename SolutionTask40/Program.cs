//Задача №40
//Напишите программу, которая принимает на вход
//три числа и проверяет, может ли существовать
//треугольник с сторонами такой длины.
int sideA=0;
int sideB=0;
int sideC=0;

ReadSides();
bool res = TestTriangle(sideA,sideB,sideC);
PrintAnswer(res);

void ReadSides()
{
Console.Write("Введите число 1: ");
int sideA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число 2: ");
int sideB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число 3: ");
int sideC = int.Parse(Console.ReadLine() ?? "");

}
bool TestTriangle(int num1,int num2, int num3)
{
    bool answer = ((num1 + num2 > num3) 
    && (num2 + num3 > num1) 
    && (num1 + num3 > num2)) ? true : false;
    //perem = (условие)? значение1: значение 2;
    return answer;
}
void PrintAnswer(bool answer);


