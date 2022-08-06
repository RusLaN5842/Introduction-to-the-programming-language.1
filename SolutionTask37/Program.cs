//Найти произведение пар чисел в одномерном массиве
//Парой считаем первый и последний элемент
//второй и предпоследний итд.
//Результат записать в новом массиве
//Например:
//[1 2 3 4 5]-> 5 8 3
//[6 7 3 6]->36 21
//метод возвращает массив заполненный случайными числами 
int[]FillingArray()
{
//Выходной массив
    int[] outArray = new int[123];
    //Буфферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while(i < 123)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-1000,1000);
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
// Метод решения задачи 37 наивный
int[] ColculateTask(int[]inputArray)
{
int[] resultArray = new int[inputArray.Length/2+1];
int i =0;

while(i<resultArray.Length)
{
    resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];

    i++;
}


return resultArray;
}

int[] buferArray = FillingArray();
PrintInArray(buferArray);
int[] resultArray = ColculateTask(buferArray);
PrintInArray(resultArray);