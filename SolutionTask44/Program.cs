﻿//Не используя рекурсии введите первые Nчисел Фибоначчи.
//Первые числа Фибоначчи: 0 и 1
//Fn - 1+Fn-2=Fn

Console.Write("Введите количество чисел в ряде Фибоначчи: ");
int decemalNumber = ReadDecemalNumber();
PrintAnswer(Fibonnaci(decemalNumber));

int ReadDecemalNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}
string outLine = Fibonacci(decemalNumber);
//собираем и накапливаем числа Фибоначчи
string Fibonnaci(int n)
{
    string answer = "";
    
    if (n == 2) {
        answer =  "0 1";
    } else if (n == 1) {
        answer = "0";
    } else {
        answer = "0 1";
        int fn_1 = 1;
        int fn_2 = 0;
        int fn;
        for (int i = 0; i < n - 2; i++)
        {
            fn = fn_1 + fn_2;
            answer += " " + current;
            fn = last;
            last = current;
        }
    }
    return answer;
}

void PrintAnswer(string answer){
    Console.WriteLine("Ряд Фибоначчи для заданного кол-ва чисел: " + answer);
}
