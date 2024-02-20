namespace LineSumOfReversedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                int number = int.Parse(numbers[i]);
                sum += ReverseNumber(number);
            }

            Console.Write(sum == ReverseNumber(sum) ? sum.ToString() : "Oburnato chislo e: " + sum);
        }

        static int ReverseNumber(int number)
        {
            int reversed = 0;

            while (number != 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return reversed;
        }
    }
    }
}
