using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //looping over an enum...
            foreach (Spell spell in Enum.GetValues<Spell>())
            {
                Console.WriteLine(spell);
            }
            Console.ReadKey();


            int num = 5;
            long bigNum = num;//implicit casting
            num = (int)bigNum;//explicit casting


            GameObject gObj = new GameObject(ConsoleColor.Blue, '?', 10, 5);
            gObj.Color = ConsoleColor.DarkCyan;//call the set on Color
            ConsoleColor theColor = gObj.Color;//call the get on Color
            Console.WriteLine(gObj.Color);//?? set or get? get

            Player playa = new Player("P", 100, 50, ConsoleColor.Yellow, 'P', 5, 7);

            //UPCASTING
            //  ALWAYS SAFE!
            GameObject gPlayer = playa;

            GameLoop(playa);
            Console.ReadKey();
            gObj.DrawMe();
            try
            {
                GameObject.Info();
            }
            catch (Exception)
            {
            }

            List<FantasyWeapon> items = new List<FantasyWeapon>();
            //{
            //    "map", "flashlight", "shovel"
            //};
            Inventory backpack = new Inventory(3, items);
            //try
            //{
            //    backpack.AddItem("spear");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            FantasyWeapon sting = Factory.CreateWeapon(WeaponRarity.Legendary, 100, 1000, 100000);
            int damage = sting.DoDamage(10);
            damage = sting.CastSpell(Spell.Fire);
            Console.WriteLine($"I swing sting and do {damage} damage to the rat.");

            BowWeapon bow = new BowWeapon(5, 10, WeaponRarity.Common, 1, 20, 15);
            damage = bow.CastSpell(Spell.Shrink);
            backpack.AddItem(sting);
            backpack.AddItem(bow);
            backpack.PrintInventory();

            //gObj.Symbol = '?';
            Console.ReadKey();
        }

        private static void GameLoop(Player playa)
        {
            Console.CursorVisible = false;
            Console.Clear();
            List<GameObject> gameObjects = GenerateObjects();
            gameObjects.Add(playa);//upcasting
            do
            {
                Render(gameObjects);
            } while (!MovePlayer(playa));
            Console.CursorVisible = true;
        }

        private static bool MovePlayer(Player playa)
        {
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        return true;
                    case ConsoleKey.Spacebar:
                        break;
                    case ConsoleKey.LeftArrow:
                        playa.MoveLeft();
                        return false;
                    case ConsoleKey.UpArrow:
                        playa.MoveUp();
                        return false;
                    case ConsoleKey.RightArrow:
                        playa.MoveRight();
                        return false;
                    case ConsoleKey.DownArrow:
                        playa.MoveDown();
                        return false;
                    default:
                        break;
                }
            } while (true);
        }

        private static void Render(List<GameObject> gameObjects)
        {
            foreach (var gameObject in gameObjects)
            {
                gameObject.DrawMe();
            }
#if DEBUG
            //DOWNCAST
            //  NOT SAFE!!!!
            //3 ways:
            //1) explicitly cast
            try
            {
                Player playa = (Player)gameObjects[0];
                playa.Debug();
            }
            catch (Exception)
            {
            }

            //2) use the 'as' keyword
            //   will assign NULL if the cast is invalid
            Player p2 = gameObjects[0] as Player;
            if(p2 != null)
                p2.Debug();

            //3) use pattern matching
            if (gameObjects[0] is Player p3)
                p3.Debug();

            if (gameObjects.Last() is Player p4)
                p4.Debug();
#endif

            //playa.DrawMe();
        }

        private static List<GameObject> GenerateObjects()
        {
            Random rando = new Random();
            List<GameObject> gameObjects = new List<GameObject>(20);
            for (int i = 0; i < 20; i++)
            {
                gameObjects.Add(
                    Factory.BuildGameObject((ConsoleColor)rando.Next(16),
                                            (char)rando.Next(255),
                                            rando.Next(Console.WindowWidth),
                                            rando.Next(Console.WindowHeight))
                    );
            }
            return gameObjects;
        }
    }
}
