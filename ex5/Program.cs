/**
* Метод вывода массива в консоль.
*/
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
/**
* Метод заполнения массива нулями.
*/
int[,] generateEmptyArr(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = 0;
        }
    }
    return arr;
}

/**
* Метод заполнения массива по спирали. 
*
* Вывод после каждой итерации реализован для проверки корректности заполнения массива.
*/
int[,] generateBySpiral(int[,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int z = n % 2 == 0 ? n / 2 : n / 2 + 1;
    for (int k = 0; k < z; k++)
    {
        for (int j = k; j < n - k; j++)
        {
            arr[k, j] = new Random().Next(1, 10);
        }
        Console.WriteLine($"===== После заполнения '" + (k + 1) + "' строки ========");
        printArray(arr);
        Console.WriteLine("========================================================");
        Console.WriteLine();
        for (int i = k + 1; i < m - k; i++)
        {
            arr[i, n - k - 1] = new Random().Next(1, 10);
        }
        Console.WriteLine($"===== После заполнения '" + (n - k) + "' столбца ========");
        printArray(arr);
        Console.WriteLine("========================================================");
        Console.WriteLine();
        for (int j = n - 2 - k; j >= k; j--)
        {
            arr[m - k - 1, j] = new Random().Next(1, 10);
        }
        Console.WriteLine($"===== После заполнения '" + (m - k) + "' строки ========");
        printArray(arr);
        Console.WriteLine("========================================================");
        Console.WriteLine();
        for (int i = m - 2 - k; i >= k + 1; i--)
        {
            arr[i, k] = new Random().Next(1, 10);
        }
        Console.WriteLine($"===== После заполнения '" + (k + 1) + "' столбца ========");
        printArray(arr);
        Console.WriteLine("========================================================");
        Console.WriteLine();
    }
    return arr;
}

Console.WriteLine("Введите число строк матрицы ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = generateEmptyArr(m, n);
generateBySpiral(arr);
Console.WriteLine("=============== Итоговый массив ================");
printArray(arr);
Console.WriteLine("================================================");