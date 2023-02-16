//Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число стодбцов: ");
int n = int.Parse(Console.ReadLine() ?? "");
double[,] array = new double [m,n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j]= new Random().NextDouble ()* (10 + 10) - 10;
        Console.Write ("{0:0.#}", array[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
Console.WriteLine();