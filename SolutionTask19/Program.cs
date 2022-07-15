int coordXPointA;
int coordXPointA;
int coordXPointB;
int coordXPointB;
void readDataOfPoint()
{
Console.WrineLine("Введите координаты Х в точке А");
int coordXPointA = int.Parse(Console.readLine());
Console.WrineLine("Введите координаты Y в точке А");
int coordXPointA = int.Parse(Console.readLine());

Console.WrineLine("Введите координаты Y в точке B");
int coordXPointB = int.Parse(Console.readLine());
Console.WrineLine("Введите координаты Y в точке B");
int coordXPointB = int.Parse(Console.readLine());

}

//Вычисляет расстояние между точками А и В
void conculateLengthAB()
{
    int LeghtAB = Math.Sqrt(Math.Pow((coordXPointA-coordXPointB),2)+ Math.Pow((coordXPointA-coordXPointB),2));
}



readDataOfPoint();
conculateLengthAB();


Console.Writeline(LengtAB);