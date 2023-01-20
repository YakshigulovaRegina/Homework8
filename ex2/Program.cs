int[,] generateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{(array[i, j])} ; ");
        }
        Console.WriteLine();
    }
}

int getSumElementsLine(int[,] array, int linenum)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[linenum, j];
    }
    Console.WriteLine($"Сумма элементов '" + (linenum + 1) + "' строки " + sum);
    return sum;
}

void lineWhereMinSum(int[,] array)
{
    int minSumlineNum = 0;
    int min = getSumElementsLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = getSumElementsLine(array, i);
        if (min > sum)
        {
            min = sum;
            minSumlineNum = i;
        }
    }
    Console.WriteLine("===================================================");
    Console.WriteLine("Сумма строки с минимальным значением " + min);
    Console.WriteLine($"Номер строки с минимальной суммой " + (minSumlineNum + 1));
    Console.WriteLine("===================================================");
}

Console.WriteLine("Введите число строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = generateArray(m, n);
printArray(array);
lineWhereMinSum(array);

