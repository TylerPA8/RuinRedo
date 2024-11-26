using RuinRedo.Player.Player_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    internal class Utilities
    {
        internal static void DisplayCreature(Creature c)
        {
            Console.Write($"{c.Name}\nHp: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{c.CurHp}/{c.MaxHp}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($" Speed: {c.Speed} Dodge: {c.Dodge}\nAttacks: ");
            foreach (Attack a in c.Attacks)
                if (a == c.Attacks[c.Attacks.Count-1])
                    Console.Write($"{a.AttackName}");
                else
                    Console.Write($"{a.AttackName}, ");
            Console.WriteLine($"\n\n");
        }
        internal static int Roll() 
        { 
            Random rnd = new Random();
            return rnd.Next(1, 101); 
        }
        internal static int Roll(int mod)
        {
            Random rnd = new Random();
            return (rnd.Next(1, 101)+ mod);
        }

    }
}
