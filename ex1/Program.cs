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

void sortArrayLine(int[,] array, int lineNum)
{
    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (array[lineNum,i] < array[lineNum,j])
            {
                int a = array[lineNum,i];
                array[lineNum,i] = array[lineNum,j];
                array[lineNum,j] =a;
            }
        }
    }
}

void sortArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sortArrayLine(array,i);
    }
    Console.WriteLine("============================================");
}

Console.WriteLine("Введите число строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = generateArray(m, n);
printArray(array);
sortArrayLines(array);
printArray(array);