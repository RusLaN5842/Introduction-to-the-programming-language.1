
//Задача №39
//Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на
//первом месте, а первый - на последнем и т.д.)
//Например:
//[1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
//Комментарий: эту задачу можно решить 2 способами: 1)
//менять числа местами в исходном массиве; 2) создать
//новый массив и в него записать перевёрнутый исходный
//массив по элементам.
//метод возвращает массив заполненный случайными числами 
int[]FillingArray(int arrayLength)
{
//Выходной массив
    int[] outArray = new int [arrayLength];
    //Буфферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while(i <  arrayLength)
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

int[] ReversNewArray(int[] inputArray)
{
    int[] ReverseNewArray(int[] array){
    int length = array.Length;
    int[] newArray = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        newArray[length - 1 - i] = array[i];

    }

    return newArray;
}


}
int[] testArray = FillingArray(17);
PrintIntArray(testArray);
int[] reverseNewArray = ReverseNewArray(testArray);
PrintInArray(reversedrray);