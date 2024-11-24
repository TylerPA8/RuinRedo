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

        }
        public override void LevelUp()
        {
            this.Level++;
            //TODO method for character level up.
        }
    }
}
