Console.Write("Введите первое число: ");
int oneNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число число: ");
int twoNumber = Convert.ToInt32(Console.ReadLine());

if (oneNumber > twoNumber)
{
    Console.WriteLine($"{oneNumber} больше чем {twoNumber}");
} 
else if (oneNumber < twoNumber)
{
    Console.WriteLine($"{twoNumber} больше чем {oneNumber}");
}
else
{
    Console.WriteLine($"{oneNumber} и {twoNumber} -");
}