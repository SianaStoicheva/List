namespace ListOfNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi ime:");
            string input = Console.ReadLine();
            string[] names = input.Split(' ');

            List<string> namesList = new List<string>(names);

            namesList.Reverse();


            Console.WriteLine(string.Join("; ", namesList));
        }
    }
}
