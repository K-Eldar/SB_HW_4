Console.Write("Введите длину последовательности: ");
int longArray = int.Parse(Console.ReadLine());

int[] Array = new int[longArray];

int min = int.MaxValue;

for (int i = 0; i < longArray; i++)
{
    Console.Write($"Введите целое число из вашей последовательности. Число #{1 + i}: "); ;
    Array[i] = int.Parse(Console.ReadLine());
    if (min > Array[i])
    {
        min = Array[i];
    }
}
Console.WriteLine($"Наименьшее число из последовательности: {min}");
Console.ReadLine();