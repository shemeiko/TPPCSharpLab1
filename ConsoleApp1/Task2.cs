namespace Tasks
{
    public class Task2
    {
        public static void Run()
        {
            /* Для натурального числа N вивести фразу "ми знайшли N грибів в 
            лісі", погодивши закінчення слова "гриб" з числом N. Звернути увагу на 
            особливе узгодження у разі коли 1<К<30. */

            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string str = "ми знайшли {0} {1} в лісі";
            int lastTwoNums = n % 100;
            int lastNum = n % 10;

            string ending = lastNum switch
            {
                1 when lastTwoNums >= 11 && lastTwoNums <= 14 => "грибів",
                2 or 3 or 4 when lastTwoNums <= 12 || lastTwoNums >= 14 => "гриби",
                1 => "гриб",
                _ => "грибів",
            };

            Console.WriteLine(string.Format(str, n, ending));
        }
    }
};