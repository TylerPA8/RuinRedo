using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Player
{
    internal class Player : Creature
    {
        public Player (string name, int speed, int dodge, int curhp, int maxhp, List<Attack> attacks, List<Status>? status, Dictionary<string, int>? resistances, int level, int exp) : base(name, speed, dodge, curhp, maxhp, attacks, status, resistances, level, exp) 
        {
            this.name = name;
            this.speed = speed;
            this.dodge = dodge;
            this.curhp = curhp;
            this.maxhp = maxhp;
            this.attacks = attacks;
            this.status = status;
            this.resistances = resistances;
            this.level = level;
            this.exp = exp;
        }
        public override void Move(Creature[] party)
        {
            Console.WriteLine("1. Left or 2. Right");
            int dir = 0;
            int choice = Convert.ToInt32(Console.ReadLine());
            if ((choice == 1) && Array.IndexOf(party, this) != 0)
                dir = -1;
            else if ((choice == 0) && Array.IndexOf(party, this) != 3)
                dir = 1;
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                Move(party);
            }
            var oldIndex = Array.IndexOf(party, this);
            int newIndex = oldIndex + dir;
            Creature swap = party[newIndex];
            party[newIndex] = this;
            party[oldIndex] = swap;
        }

        public override void SelectTarget(List<Creature> enemies)
        {


        }
        public override void SelectAttack()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            (int left, int top) = Console.GetCursorPosition();
            var selectedOption = 0;
            var decorator = $"✅ \u001b[31m";
            ConsoleKeyInfo key;
            bool isSelected = false;

            List<string> atkNames = new List<string>();
            foreach (Attack a in this.Attacks)
            {
                atkNames.Add(a.AttackName);
            }

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                for (int i = 0; i < atkNames.Count; i++)
                {
                    Console.Write($"{(selectedOption == i ? decorator : "   ")}{atkNames[i]}\u001b[0m");
                }

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        selectedOption = selectedOption == 0 ? atkNames.Count - 1 : selectedOption - 1;
                        break;

                    case ConsoleKey.RightArrow:
                        selectedOption = selectedOption == atkNames.Count - 1 ? 0 : selectedOption + 1;
                        break;

                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }

            Console.WriteLine($"\n{decorator}You selected {atkNames[selectedOption]}");
            Console.ReadLine();
        }
        public override void LevelUp()
        {
            this.Level++;
            //TODO method for character level up.
        }
    }
}
