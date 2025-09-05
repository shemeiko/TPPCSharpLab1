namespace Tasks
{
    public class Task5
    {
        static int GCD(int a, int b)
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
            Console.Write("[GCD] Enter number1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("[GCD] Enter number2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"GCD {a} and {b} is {GCD(a, b)}");
        }
    }
}