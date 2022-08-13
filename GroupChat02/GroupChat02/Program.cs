namespace GroupChat02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int age = Input.ReadInteger("What is your age? ", 1, 115);

            string make = string.Empty;
            Input.ReadString("What is the make of your car? ", ref make);

            string[] menu = new string[] { "1. Start game", "2. Show high scores", "3. Exit" };
            int selection = 0;
            while (selection != 3)
            {
                Input.ReadChoice("Choice? ", menu, out selection);

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Start game");
                        break;
                    case 2:
                        Console.WriteLine("Show high scores");
                        break;
                }
            }
        }


    }
}