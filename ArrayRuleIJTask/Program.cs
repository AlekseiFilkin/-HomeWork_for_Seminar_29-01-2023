//Задать двумерный массив следующим правилом: Aₘₙ = m+n

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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
Console.Write("Bведите количество строк: ");
int i = int.Parse(Console.ReadLine() ?? "");
Console.Write("Bведите количество столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[i, j];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();