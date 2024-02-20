namespace ListEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();

            for (int i = 0; i < numberStrings.Length; i++)
            {
                int number = int.Parse(numberStrings[i]);
                numbers.Add(number);
            }

            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}
