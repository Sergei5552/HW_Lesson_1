Console.Write("Введите первое число: ");
int oneNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число число: ");
int twoNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = oneNumber;
if (twoNumber > maxNumber) maxNumber = twoNumber;
if (threeNumber > maxNumber) maxNumber = threeNumber;

Console.WriteLine($"{maxNumber} - наибольшее число и трёх чисел" );
