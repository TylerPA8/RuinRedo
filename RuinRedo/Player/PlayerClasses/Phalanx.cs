using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Player.PlayerClasses
{
    internal class Phalanx : Player
    {
        public Phalanx(string name, int ac, int maxhp, int curhp, List <Attack> attacks, List<Status>? status, int level, int exp) : base(name, ac, maxhp, curhp, attacks, status, level, exp)
        {
            this.name = name;
            this.ac = ac;
            this.maxhp = maxhp;
            this.curhp = curhp;
            this.attacks = GetAttacks();
            this.status = status;
            this.level = level;
            this.exp = exp;
        }
        public List <Attack> GetAttacks()
        {
            Random rnd = new Random();
            List<Attack> atklist = new List<Attack>();
            List<int> temp = new List<int>();
            while (temp.Count != 4)
            {
                int i = Convert.ToInt32(rnd.Next(0, 8));
                if (!temp.Contains(i))
                {
                    temp.Add(i);
                }
            }
            temp.Sort();
            foreach (int i in temp)
            {
                atklist.Add(AttackLibrary.PhalanxAttacks[i]);
            }
            return atklist;
        }
    }
}
