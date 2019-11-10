using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_game
{
    class Fight
    {

        public static void StartFight(Warrior warriorA, Warrior warriorB)
        {
            while (true)
            {
                if (GetAttackResult(warriorA, warriorB) == false)
                {

                    Console.WriteLine("Game over!");
                    break;
                }
                if (GetAttackResult(warriorB, warriorA) == false)
                {
                    break;
                }
            }
        }
        public static bool GetAttackResult(Warrior warrior1, Warrior warrior2)
        {
            double warr1Attack = warrior1.Attack();
            double warr1AS = warrior1.AttackSpeed();
            double warr2Block = warrior2.Block();
            double DmgWarr2 = (warr1Attack * warr1AS) - warr2Block;


            if (DmgWarr2 > 0)
            {
                warrior2.Health = warrior2.Health - DmgWarr2;
            }
            else DmgWarr2 = 0;
            Console.WriteLine("{0} Attacks {1} and deals {2} damage!", warrior1.Name, warrior2.Name, DmgWarr2);
            Console.WriteLine("{0} has {1} health.", warrior2.Name, warrior2.Health);
            if (warrior2.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} has won the fight!", warrior2.Name, warrior1.Name);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
