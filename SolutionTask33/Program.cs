// Задать массив.
//Написать программу, которая определяет, присутствует ли заданное число в массиве
//например:
//4; массив [6,7,19,345,3]-> нет
//-3; массив[6.7.19.345.3]-> да

//метод возвращает массив заполненный случайными числами от -9 до 9
int[]FillingArray()
{
//Выходной массив
    int[] outArray = new int[12];
    //Буфферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while(i < 12)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-9,10);
        //Увеличиваем инкремент
        i++;

    }
    //Возвращаем значение
    return outArray;
}

//Метод печатает массив
void PrintInArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ",");
        //Увеличиваем инкримент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

// Метод решения задачи 33 наивный
bool ColculateTask(int[]inputArray, int searchNumber)
{
    bool resultSearch = false;
   int i= 0;
while(i < 12)
{
    if(inputArray[i]==searchNumber)
    {
        resultSearch=true;
        break;
    }
    i++;
}
return resultSearch;
}



int[]buferArray = FillingArray();
PrintInArray(buferArray);
Console.WriteLine("Введите число для поиска:");
int searchNumber = int.Parse(Console.ReadLine());

Console.WriteLine(ColculateTask(buferArray,searchNumber));