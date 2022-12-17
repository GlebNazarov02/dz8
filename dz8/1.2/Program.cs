void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine();
    }

}

int[,] MassNums(int s1, int s2, int from, int to)
{
    int[,] arr = new int[s1, s2];
    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void Maximum(int[,] arr)
{
    int stroka = 0;
    int summa = 0;
    int summa1 = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0;k < column - 1;k++)
            {
                summa1 += arr[i,k];
            }
        }
        if (summa1 > summa)
        {
            summa = summa1;
            stroka = i;
        }
        summa1 = 0;
    }
    Console.WriteLine($"Наибольшая строка = {stroka+1}");
}

int[,] arr1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));

Print(arr1);
Maximum(arr1);
