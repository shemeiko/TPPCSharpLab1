namespace Tasks {
    public class Task1
    {
        public static void Run()
        {
            /* Ввести три числа A, B, C. Вивести середнє з них (тобто число, 
            розташоване між найменшим і найбільшим). Якщо користувач введе числа 
            так, що серед них не можна буде визначити середнє — вивести відповідне 
            повідомлення. */

            Console.Write("Enter number for A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number for B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number for C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if ((a < b && b < c) || (a > b && b > c))
            {
                Console.WriteLine(b);
            }
            else if ((b > a && a > c) || (b > a && a > c)) 
            {
                Console.WriteLine(a);
            }
            else if ((c < b && a < c) || (c > b && c < a))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Imposible to find an average number!");
            }
        }
    }
};