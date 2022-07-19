// Задание со *. Напишите программу, которая принимает на вход пятизначное число и проверяет, являеся ли оно прлиндромом. 

//Считываем данные консоли.
Console.Write("Введите пятизначное число для проверки является ли оно полиндромом:");
//Считываем данные консоли.
string? inputLine = Console.ReadLine();
try{
    // Парсим вход в инт
    intinput = int.Parse(inputLine);
    //Проверяем что введенное число пятизначное
    if ((inputNum > 99999)|| (inputNum < 10000)) {
        throw new ArgumentOutOfrangeException(
            "Введенное число не пятизначное!");

    }
    // Создаем новый словарь
    Dictionary < int, string > poliDict = new Dictionary<int, string>();
    //Вызываем метод генерации полиндромов
    poliDictgen (poliDict);
    //Удаляем среднюю цифру
    inputNum = (inputNum / 1000)* 100 + inputNum % 100;
    //Выполняем проверку на полиндром
    if (poliDict.ContainsKey(inputNum)){
        Console.WriteLine("Заданное число является полиндромом!");
    } 
    else {
        Console.WriteLine("Заданное число не является полиндромом");
    }

}
catch(Exception e)
//Выводим сщщбщение об ошибке

{
Console.WriteLine("Некорректный ввод.");
Console.WriteLine("Возникло исключение:" + e.Message);
Console.WriteLine("Попробуйте запустить еще раз. ");

}
//Метод добавляет 4-значные полиндромы в передний словарь
void poliDictgen(Dictionary < int, string > poliDict)
{
    int key;
    // Генерируем полиндромы в цикле - каждому двухзначному дописываем в конце его же зеркальное
    for (int i = 10; i < 100; i++)
    {
        key = i * 100 + (i % 10) * 10 + i /10;
        poliDict.Add(key, key.ToString());
    }
}