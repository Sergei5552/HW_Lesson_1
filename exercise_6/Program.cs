Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"{number} - это чётное число");
}

else
{
     Console.Write($"{number} - это нечётное число");
}
