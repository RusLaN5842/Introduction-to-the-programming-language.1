﻿// Собрать строку с числами от а до b,a<=b
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
    result += $"{i} ";
    }

return result;
}
string NumbersRes(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRes (a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); //1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRes(1, 10)); // 1 2 3 4 5 6 7 8 9 10

