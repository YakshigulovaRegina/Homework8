int[,] generateArray(int m1, int n1)
{
    int[,] arr = new int[m1, n1];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            arr[i, j] = new Random().Next(1, 20);
        }
    }
    return arr;
}


void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{(arr[i, j])} ; ");
        }
        Console.WriteLine();
    }
}

int[,] multArrays(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(0) != arr2.GetLength(1))
    {
        Console.WriteLine("Невозможно перемножить матрицы");
    }
    else
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    arr3[i, j] += arr1[i, k] * arr2[k, j];
                }

            }
        }
    }
    return arr3;
}

Console.WriteLine("Введите число строк матрицы 1 ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы 1");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк матрицы 2 ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы 2 ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] arr1 = generateArray(m1, n1);
int[,] arr2 = generateArray(m2, n2);
printArray(arr1);
Console.WriteLine("======================");
printArray(arr2);
Console.WriteLine("======================");
int[,] arr3 = multArrays(arr1, arr2);
printArray(arr3);