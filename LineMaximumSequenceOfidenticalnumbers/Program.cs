namespace LineMaximumSequenceOfidenticalnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi chislo:");
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            int[] numbers = new int[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = int.Parse(numbersStr[i]);
            }

            int currentStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestStart = currentStart;
                        bestLength = currentLength;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
            }

            Console.Write("Nai-dulga poredica ot chisla: ");
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
