Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите квадрат этого числа:");
int number2 = Convert.ToInt32(Console.ReadLine());

int sqr1 = Convert.ToInt32(Math.Pow(number1, 2));
if (sqr1 == number2)
{
    Console.WriteLine("Число " + number2 + " является квадратом " + number1);
}
else 
{
    Console.WriteLine("Число " + number2 + " не является квадратом " + number1);
}
