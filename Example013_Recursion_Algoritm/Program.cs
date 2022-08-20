//string[,] table = new string[2,5];
    //Strig.Empty
    //table [0,0] table[0,1] table[0,2] table [0,4]
    //table[1,0] table[1,1] table[1,2] table [,4]
//table[1,2]="Слово";

//for (int rows = 0; rows < length; rows++)
//{
    //for (int columns = 0; columns < length; columns++)
    //{
    //    Console.WriteLine($"-{table[rows, colums]}-");

  //  }
//}
    // Вывод матрицы чисел или прямоугольная таблица чисел 3 строки и 4 столбца




void PrintArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
        for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10]
        }
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

//int[,] matrix = new int [3,4];
//PrintArray(matrix);