namespace LineExtremes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo:");
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            int[] numbers = new int[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = int.Parse(numbersStr[i]);
            }

            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }

            Console.Write("Izhod: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == min)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == max && numbers[i] != min)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
