namespace GroupChat03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> comics = File.ReadAllText("inputFile.csv").Split(',').ToList();

            foreach(string comic in comics)
                Console.WriteLine(comic);

            Console.WriteLine("----------BUBBLE SORTED---------");
        }
    }
}