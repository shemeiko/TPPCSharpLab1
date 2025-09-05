namespace Tasks
{
    public class Task5
    {
        static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }

        public static void Run()
        {
            /* Ввести цілі додатні числа A і B. Знайти їх найбільший спільний  
            дільник (НСД), використовуючи алгоритм Евкліда : НСД (A, B) = НСД (B, A mod B), 
            якщо B ≠ 0; НСД (A, 0) =A, де "mod" означає операцію отримання остачі від ділення. */

            Console.WriteLine($"GCD 54 and 24 is: {gcd(54, 24)}");
            Console.WriteLine($"GCD 12 and 8 is: {gcd(12, 8)}");
            Console.WriteLine($"GCD 1 and 5 is: {gcd(1, 5)}");

        }
    }
}