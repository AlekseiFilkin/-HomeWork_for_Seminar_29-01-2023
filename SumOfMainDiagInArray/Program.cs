//В матрице чисел найти сумму элементов главной диагонали

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
int DiagSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
}
Console.Write("Количество строк в массиве: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
if (m == n) Console.WriteLine($"Сумма элементов главной диагонали равна {DiagSum(array)}");
else Console.WriteLine("Рассчет суммы элементов главной диагонали невозможен, т.к. матрица не квадратная.");