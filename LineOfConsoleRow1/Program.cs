namespace LineOfConsoleRow1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chislo:");
            string input = Console.ReadLine();
            string[] numbersAsString = input.Split(' ');

            List<int> numbers = new List<int>();
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                int number;
                if (int.TryParse(numbersAsString[i], out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Nevalidno chislo: {numbersAsString[i]}");
                }
            }

            Console.WriteLine("Izhod:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {numbers[i]}");
            }
        }
    }
}
