Sustem.Random numberSintezator = new Sustem.Random();

void VariantNaive()
{
    int i =0;
    while(i<8-1);
    Console.Write("[");
    {
        Console.Writeline(numberSintezator.Next(0,2)+",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,2)+",");
    Console.Write("]");
}
VariantNaive();