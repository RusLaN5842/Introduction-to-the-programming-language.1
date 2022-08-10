//Задача №42
//Напишите программу, которая будет
//преобразовывать десятичное число в двоичное.
//Например:
//45 -> 101101
//3 -> 11
//2 -> 10


//преобразование десятизначное число в двоичное
DateTime dq = DateTime.Now;
Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()),2));
Console.WriteLine(DateTime.Now-d1);
//Разбор строчного кода
//int number = int.Parse(Console.ReadLine());
//string outLine = Convert.ToString(number,16);
//Console.WriteLine(outLine);

//d1 = DateTime.Now
//Console.Write("Введите десятичное число: ");
//int decemalNumber = ReadDecemalNumber();
//PrintAnswer(BinaryConverter(decemalNumber));
//Console.Writeline(Datetime.Now -d1);

//int ReadDecemalNumber(){
  //  return int.Parse(Console.ReadLine() ?? "");
//}

//string BinaryConverter(int num) {
    //string bin = "";
    //while(num > 0) {
        //if (num % 2 == 1) {
          //  bin = "1" + bin;
        //} else {
          //  bin = "0" + bin;            
        //}
      //  num /= 2;
    //}
  //  return bin;
//}

//void PrintAnswer(string answer){
  //  Console.WriteLine("Введенное число в двоичном виде: " + answer);
//}
