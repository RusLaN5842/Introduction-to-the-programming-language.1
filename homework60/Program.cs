//----------------------------------------------------------------------
//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
//  Массив размером 2 x 2 x 2
//----------------------------------------------------------------------

// Создаемп еременную генератора случайных чисел
System.Random numberSintezator = new Random();

// Создаем постоянную переменную для размера массива
const int arrayDimnesion1 = 2;
const int arrayDimnesion2 = 2;
const int arrayDimnesion3 = 2;

try
{
    //Вызываем метод генерации массива и сохраните его в новой переменной
    int[,,] array = Get3DArray(arrayDimnesion1, arrayDimnesion2, arrayDimnesion3);
    //  Печать массива вызовов
    Print3DArray(array, "Сгенерирован трехмерный массив: ");
    //Вызов метода сортировки строк массива
}
catch (Exception e)
{
    //Печатаем ошибку
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//генерируем двумерный целочисленный массив
int[,,] Get3DArray(int dim1, int dim2, int dim3)
{
    //список для проверки значений записи
    List<int> usedValues = new List<int>(8);
    //переменную массива int
    int[,,] array = new int[dim1, dim2, dim3];
    //Переход по всем элементам массива
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                while (true)
                {
                    //Генерируем номер для каждого элемента
                    array[i, j, k] = numberSintezator.Next(0, 100);
                    //если нет повтора то вызываем while
                    if (!usedValues.Contains(array[i, j, k])) break;
                }
                //Добавляем новый элемент в список
                usedValues.Add(array[i, j, k]);
            }
        }
    }
    return array;
}

//печатаем
void Print3DArray(int[,,] array, string text)
{
    Console.WriteLine(text);
    //Создаем переменные для чисел №1, №2, №3
    int dim1 = array.GetLength(0);
    
    int dim2 = array.GetLength(1);
   
    int dim3 = array.GetLength(2);
    //Проходим по всем элементам массива
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                //Печатаем текущий элемент
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})\t");
            }
        
            Console.WriteLine();
        }
    }
}