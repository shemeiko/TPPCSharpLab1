using System;

namespace Tasks
{
    public class Task4
    {
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; ++i)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        public static void Run()
        {
            /* Здійснити введення послідовності цілих чисел в кількості не 
            меншому двох. Обчислити суму тих з них, порядкові номери яких  прості 5 
            числа. Послідовність потенційно необмежена, закінченням послідовності 
            служить число 0. */

            int sum = 0;
            int count = 0;
            int val;

            do
            {
                Console.Write($"Enter element[{count + 1}]: ");
                val = Convert.ToInt32(Console.ReadLine());
                count++;

                if (IsPrime(count))
                    sum += val;

            } while (val != 0 || count < 2);
            Console.WriteLine($"Sum of odds index elements is {sum}");
        }
    }
}