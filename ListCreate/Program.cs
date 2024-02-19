namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete spisuk ot colors> //Done// za end!");
            List<string> colorList = new List<string>();
            string input = Console.ReadLine();
            while(input != "Done")
            {
                //mush in colorList
                colorList.Add(input);
                input = Console.ReadLine();
            }
            for (int i = 0; i < colorList.Count; i++)
            {
                Console.WriteLine(colorList[i]);
            }


             Console.WriteLine("Koi element da iztriesh 0-" + (colorList.Count - 1 + " ? "));
            int index = int.Parse(Console.ReadLine());

            colorList.RemoveAt(index);

            colorList[0] = "Rozovo";

            foreach (string chervenoKvadratche in colorList)
            {
                Console.WriteLine(chervenoKvadratche);
            }




        }
    }
}
