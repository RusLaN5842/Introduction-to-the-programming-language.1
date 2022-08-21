//-----------------------------------------------------------------------
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
//-----------------------------------------------------------------------

try
{
    //Просим пользователя ввести номер
    int inputNumberM = ReadNumber("Введите число M: ");
    int inputNumberN = ReadNumber("Введите число N: ");
    //Вызоваем метод вычисления и выводим его ответ
    int result = AkermanFunction(inputNumberM, inputNumberN);
    //Проверяем результат выведения
    if (result == -1)
    {
        Console.Write($"Решение функции Акермана для введенных чисел не возможно. Произойдет переполнение стека.");
    }
    else
    {
        Console.Write($"Решение функции Акермана для введенных чисел: {result}");
    }
}

catch (Exception e)
{
    //Выводим ошибку печати
    Console.WriteLine("Возникло исключение: " + e.Message);
    Console.WriteLine("Попробуйте запустить программу еще раз.");
}

//Вычисляем функцию Акермана для заданных аргументов
int AkermanFunction(int m, int n)
{
    if ((m > 4) || ((m > 3) && (n > 0))) return -1;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkermanFunction(m - 1, 1);
    return AkermanFunction(m - 1, AkermanFunction(m, n - 1));
}

//Считывает вводимые пользователем данные
int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}