// Написать программу Замены элементов массива
//Положительные элементы заменить на
//соответствующие отрицательные и наоборот.
//Пример
//[-4,-8.8,2]->[4,8,-8,-2]
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
// Метод инвентирует элементы массива простой
int[] ColculateTask(int[]inputArray)
{
    //объявляем буферный массив
    int[] outputArray = new int[12];
int i= 0;
while(i<12)
{
    outputArray[i]=inputArray[i]*(-1);
    i++;
}
return outputArray;
}
//Метод инвентирует элементы массива Тильда
int[] InverttArrayTilda(int[]inputArray)
{
//Буфферная переменная
int i = 0;
//Пробегаем все элементы массива
while (i < inputArray.Length)
{
    //Инвентируем элемент
    inputArray[i] = (~inputArray[i]) + 1;
    //увеличиваем инкримент
    i++;
}
//Выводим массив
return inputArray;
}


int[] bufferArray = FillingArray();
PrintInArray(bufferArray);
int[] resultArray = ColculateTask(bufferArray);
PrintInArray(resultArray);
resultArray = InverttArrayTilda(bufferArray);
PrintInArray(resultArray);