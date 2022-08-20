//-------------------------------------------------------------
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//-------------------------------------------------------------

try
{
    //Просим пользователя ввести номер
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    //Проверяем входные данные на наличие 
    //большего размера и меняем их местами, если первый больше
    if ( inputNumberM > inputNumberN) (inputNumberM, inputNumberN) = (inputNumberN, inputNumberM);
    //Печатаем вызов
    PrintNumbers(inputNumberM, inputNumberN);
}
catch (Exception e)
{
    //Печатаем ошибку
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}



//Выводим числа
void PrintNumbers(int numM, int numN)
{
    if (numM != numN)
    {
        Console.Write(numM + ", ");
        PrintNumbers(++numM, numN);
    }
    else
    {
        Console.Write(numM);
    }
}

//Преобразуем вводимые пользователем данные в число и возвращает его
int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}
