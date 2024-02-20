namespace ListOfName2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi ime:");
            string input = Console.ReadLine();
            string[] names = input.Split(", ");

            for (int i = names.Length - 1; i >= 0; i--)
            {
                string[] parts = names[i].Split(' ');
                Console.WriteLine($"{parts[1]} {parts[0]}");
            }
        }
    }
}
