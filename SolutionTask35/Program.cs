//Задать одномерный массив из 123 случайных чисел
//Найти количество элементов массива, значения
//которых лежат в отрезке [10,99].
//например:
//Пример для массива из 5, а не 123 элементов. В своем решении
// сделайе для 123
//[5,18,123,6,2]->1
//[1,2,3,6,2]->0
//[10,11,12,13,14]->5
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
// Метод решения задачи 35 наивный
int ColculateTask(int[]inputArray, int downBorder, int upBorder)
{
    int resultCount = 0;
   int i= 0;
while(i < inputArray.Length)
{
    if(inputArray[i]>=downBorder&&inputArray[i]<=upBorder)
    {
        Console.WriteLine(inputArray[i]+"");
        resultCount++;
    }
    i++;
}
return resultCount;
}

int[] buferArray = FillingArray();
PrintInArray(buferArray);
Console.WriteLine(ColculateTask(buferArray,10,99));