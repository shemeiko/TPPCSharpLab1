using System;

namespace Tasks
{
    public class Task3
    {
        public static void Run()
        {
            /* Ввести ціле число 0N . Знайти значення виразу 1.1 - 1.2 + 1.3 - ... 
            (N доданків, знаки чергуються). Умовний оператор не використовувати. */

            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("ERROR: N should be greater than 0");
                return;
            }

            double sum = 0;
            double val = 1.1;
            int sign = 1;
            for (; n > 0; n--)
            {
                sum += sign * val;
                val += 0.1;
                sign = -sign;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}