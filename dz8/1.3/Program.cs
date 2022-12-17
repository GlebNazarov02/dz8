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
int[,] MultiplyMatrix(int[,] mass1, int[,] mass2)
{
    int row = mass1.GetLength(0);
    int column = mass1.GetLength(1);
    int row1 = mass2.GetLength(0);
    int column1 = mass2.GetLength(1);
    int[,] multy = new int[row, column1];
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column1; j++)
            {
                int sum = 0;
                for (int k = 0; k < column; k++)
                {
                    sum += mass1[i, k] * mass2[k, j];
                }
                multy[i, j] = sum;
            }
        }
    }
    return multy;
}
int[,] arr1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr1);
int[,] arr2 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));

Print(arr2);
Console.WriteLine();
int[,] arrsum = MultiplyMatrix(arr1,arr2);
Print(arrsum);