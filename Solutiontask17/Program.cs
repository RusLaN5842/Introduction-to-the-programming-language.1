//метод считывает точки и выводит в массив
int[,] readPoint();
{
string inputLine = Console.readLine();


string coordxLine = inputLine.Substring(0,inputLine.IndexOf(";"));
coordxLine = coordxLine.Substring(coordxLine.IndexOf("=")+1);


string coordYLine = inputLine.Substring(0,inputLine.IndexOf(";")+1);
coordYLine = coordYLine.Substring(coordYLine.IndexOf("=")+1);

int coordx = int.Parse(coordxLine);
int coordx = int.Parse(coordYLine);

int[,] arrayOut = new int(1,2);
arrayOut[0,0] = coordx;
arrayOut[0,1] = coordy;
}
//Печатает номер сессии
void printQinter(int[] arreyPoint);
{
if(arrayPoint[0,0]>&&arreyPoint[0,1]>0)
Console.WriteLine("1 четверть")
}
int[] arreyPoint = readPoint;

printQinter (arreyPoint) 
