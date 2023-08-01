// Console.WriteLine("Введите число:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите квадрат этого числа:");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int sqr1 = Convert.ToInt32(Math.Pow(number1, 2));
// if (sqr1 == number2)
// {
//     Console.WriteLine("Число " + number2 + " является квадратом " + number1);
// }
// else 
// {
//     Console.WriteLine("Число " + number2 + " не является квадратом " + number1);
// }
// -------------------------
// int Fibbo(int pos)
// {
//     if (pos == 1 || pos == 2)
//     {
//         return 1;
//     }
//     return Fibbo(pos - 1) + Fibbo(pos - 2);
// }

// System.Console.WriteLine(Fibbo(6));
// ----------------------------
// int Sum(int num)
// {
//     int result = 0;
//     for(int i = 1; i <= num; i++)
//     {
//         result += i;
//     }
//     return result;
// }

// System.Console.WriteLine(Sum(3));
// -------------------

// List<int> PrimeNum(int numbers)
// {
//     List<int> primeNumbers = new List<int>();
//     for (int i = 2; i <= numbers; i++)
//     {
//         bool notPrime = false;
//         for (int j = 2; j <= Math.Sqrt(i); j++)        
//         {
//             if (i % j == 0)
//             {
//                 notPrime = true;
//                 break;
//             }
//         }
//         if (notPrime == false) primeNumbers.Add(i);
//     }
//     return primeNumbers;
// }
// List<int> primes = PrimeNum(100);
// System.Console.WriteLine(primes.Count + "\n" + string.Join(", ", primes));
// -------------

int outputFirst = 0;
int outputLast = 0;
int tmp;
for (int i = 1; i < 8; i++)
{
    if (i == 1 || i == 2)
    {
        outputFirst = 1;
        outputLast = 1;
    }
    else
    {
        tmp = outputFirst;
        outputFirst = outputFirst + outputLast;
        outputLast = tmp;
    }
    System.Console.WriteLine(outputFirst);
}
