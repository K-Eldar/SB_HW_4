Console.WriteLine("Введите максимальное число диапазона");
int max = int.Parse(Console.ReadLine());

Random rand = new Random();

var number = rand.Next(0, max);
Console.Write("Введите загаданное программой число: ");

while (true)
{
 
    string userNumb = (Console.ReadLine());
    {
        if (string.IsNullOrEmpty(userNumb))
        {
            Console.Write($"Спасибо за игру. \nЗагаданное число: { number} ");
            break;
        }

        else if (int.Parse(userNumb) == number)
        {
            Console.Write("Поздравляем! Вы угадали число ");
        }
        else if (int.Parse(userNumb) > number)
        {
            Console.Write("Введеное вами число больше загаданного. Попробуйте еще раз:  ");
        }
        else if (int.Parse(userNumb) < number)
        {
            Console.Write("Введеное вами число меньше загаданного. Попробуйте еще раз:  ");
        }
    }
    
}


   