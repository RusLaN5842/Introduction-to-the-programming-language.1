// Задайте массив из 12 элементов, Заполненный случайными числами из промежутка [-9,9].
//Найдите сумму отрицательных и положительных элементов массива.
//например:
//В массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//Сумма положительных чисел равна 29, сумма отрицательных равна -20.
int posetivSum = 0;
int negativSum = 0;
//метод возвращает массив заполненный случайными числами от -9 до 9
int[]fillingArray();
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Буфферная переменная
    int i = 0;
    //Выходной массив
    int[] outArray = new int[12000000];
    
    //Цикл заполнения массива
    while(i < 12000000)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-9,10);
        //Увеличиваем инкремент
        i++;

    }
    //Возвращаем значение
    return outArray;
}
// Метод подсчета положительных и отрицательных значений
void ColculateTask(int[]outArray)
{
int i= 0;
while(i<12000000)
{
    if(outArray[i]>0)
    {
        posetivSum+=outArray[i];
    }
    else
    {
        negativSum+=outArray[i];
    }
    i++;
}
}
//выводим результат на консоль
void PrintResult()
{
Console.WriteLine(posetivSum);
Console.WriteLine(posetivSum);
}

//Метод печатает массив
void PrintInArray(int[]inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while(i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ",");
        //Увеличиваем инкримент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

//метод решения задачи 31 наивный
void VariantNaive()
{


int[]bufferArray = fillingArray();
//PrintInArray(bufferArray);
ColculateTask(bufferArray);
PrintResult();
}

//Метод Решения Задачи 31 простой
void VariantSimple()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Буферные переменные
    int i = 0;
    int buf = 0;
    //Цикл Заполнения массива
    while(i < 12)
    {
        //Получаем новое значение
        buf = numberSintezator.Next(-9,9);
        Console.Write(buf + "");
        //Накапливаем результат
        if (buf >= 0)
        {
            //Элемент положительный
            posetivSum += buf;
        }
        else
        {
           //Элемент отрицаттельный
           negativSum += buf;

        }
        //Увеличиваем инкримент
        i++;
    }
   // Console.WriteLine();
//Выводим сумму положительных значений
Console.WriteLine(posetivSum);
//Вводим сумму отрицательных значений
Console.WriteLine(negativSum);
}

int t;
t = Environment.TickCount;
//Вариант 1
VariantNaive();
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
//Вариант 2
VariantSimple();
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);
//Результат Кирилла
//Sustem.Random numberSintezator = new Random();

// int[] array = getArray(12);
//Console.WriteLine("Сумма положительных элементов:" + calcPositive(array, true));
//Console.WriteLine("Сумма отрицательных элементов:" + calcPositive(array, false));

//int[] getAray(int num)
//{
  //  int[] array = new int[num];
    //int i= 0;
    //Console.Write("Сгенерирован массив:");
    //while(i < array.Length - 1)
    //{
      //  array[i] = numberSintezator.Next(-9,10);
       // Console.Write(array[i] + ""); // Для проверки
        //i++;
    //}
   // Console.WriteLine();
  //  return array;
//}
//int calcPositive(int[] array, bool isPositive)
//{
  //  int i = 0;
   // int sum = 0;
    //while(i < array.Length - 1)
    //{
      //  if(isPositive && array[i] < 0)
        //{
          //  sum +=array[i];
        //}
        //else if (!isPositive && array[i] < 0)
        //{
          //  sum += array[i];
        //}
        //i++;
    //}
    //return sum;
//}