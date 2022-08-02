Console.Clear();
Console.Write("Введите число:");

string inputLineNumber = Console.ReadLine()??"";
Long inputNumber = Long.Parse(inputLineNumber);
DateTime timepoint = DateTime.Now;
Long VariantSimple()
{
    //Long numberLenght = 0;
    //char[] array = inputLineNumber.ToCharArray();
    //numberLenght = array.Length;
    return inputLineNumber.ToCharArray().Length;
    }
    Long VariantSimple()
    {
        Long numberLenght = 0;
        Long digits =1;
        while (digits < inputNumber)
        {
            digits = digits* 10;
            numberLenght++;
        }
        return numberLenght;
    }
Long VariantLog10()
    {
        return (Long)Math.Log10(inputNumber)+1;
    }

    Long result = 0;
    timepoint = DateTime.Now;
    result = VariantSimple();
    Console.Wrineline(result);
    Console.Writeline(DateTime.Now- timePoint);

    
    timepoint = DateTime.Now;
    result = VariantLog10();
    Console.Wrineline(result);
    Console.Writeline(DateTime.Now- timePoint);