﻿string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputNumber = int.Parse(inputline);

    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "понедельник";
    dayOfWeek[1] = "вторник";
    dayOfWeek[2] = "среда";
    dayOfWeek[3] = "четверг";
    dayOfWeek[4] = "пятница";
    dayOfWeek[5] = "суббота";
    dayOfWeek[6] = "воскресенье";

    Console.WriteLine(dayOfWeek[inputNumber-1]);
}
