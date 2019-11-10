using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_game
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double MaxAttack { get; set; }
        public double MaxBlock { get; set; }
        public double MaxAttackSpeed { get; set; }

        Random rand = new Random();
        public Warrior(string name, double health, double maxAttack, double maxBlock, double maxAttackSpeed)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
            MaxAttackSpeed = maxAttackSpeed;
        }
        public double Attack()
        {
            return rand.Next(1, (int)MaxAttack);
        }
        public double Block()
        {
            return rand.Next(1, (int)MaxBlock);
        }
        public double AttackSpeed()
        {
            return rand.Next(1, (int)MaxAttackSpeed);
        }
    }
}
