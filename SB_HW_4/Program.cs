Console.Write("Введите количество строк в матрице: ");
int line = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в матрице: ");
int coloumn = int.Parse(Console.ReadLine());

int sum = 0;
Random random = new Random();

int[,] matrix = new int[line, coloumn];

for (int i = 0; i < line; i++)
{
    for (int j = 0; j < coloumn; j++)
    {
        matrix[i, j] = random.Next(10);
        Console.Write($"{matrix[i, j]} ");
        sum += matrix[i, j];

    }
    Console.WriteLine();
}
Console.WriteLine($"Cумма элементов массива равна: {sum}");