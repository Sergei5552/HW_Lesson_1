Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
while (evenNumber < userNumber)
{
    Console.Write($"{evenNumber}, ");
    evenNumber += 2;
}
