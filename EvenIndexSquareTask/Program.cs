//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}
void GhangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] *= array[i, j];
        }

    }
}
Console.Write("Bведите количество строк: ");
int i = int.Parse(Console.ReadLine() ?? "");
Console.Write("Bведите количество столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "");
int[,] matrix = new int[i, j];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
GhangeArray(matrix);
PrintArray(matrix);