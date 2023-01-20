int[,,] generateArray(int m, int n, int l)
{
    int[,,] arr = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                arr[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
    return arr;
}

void printArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{(arr[i, j, k])} " + (i, j, k) + " ; ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите число строк матрицы ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов матрицы ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину матрицы ");
int l = Convert.ToInt32(Console.ReadLine());
int[,,] arr = generateArray(m, n, l);
printArray(arr);