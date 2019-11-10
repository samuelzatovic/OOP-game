using System;

namespace OOP_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Samuel = new Warrior("Samuel", 1500, 80, 50, 1.5);
            Warrior Achilles = new Warrior("Achilles", 2000, 60, 60, 2.5);

            Fight.StartFight(Samuel, Achilles);

            Console.ReadLine();
        }
    }
}
