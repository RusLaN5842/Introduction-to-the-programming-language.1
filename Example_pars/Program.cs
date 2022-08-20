//Парсинг входной строки
using System.Linq;

string text ="(1,2) (2,3) (4,5) 6,7)"
                .Replace("(","")
                .Replace(")","")
                ;

Console.WriteLine(text);
var data = text.Split("")
            //выборка элементов 
            .Select(item => item.Split(',' ))
            //Выборка элементов из текущего массива
            .Select(e=> (x:int.Parse(e[0]), y: int.Parse(e[1])))
            //ченые числа
            .Where (e=> e.x % 2==0)
            //Увеличение первой координаты
            .Select(point => (point.x * 10, point.y))
            //превращение в массив
            .ToArray();

for (int i = 0; i<data.Length; i++)
{
    Console.WriteLine(data[i]);
    
}

