using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Player.Player_Classes
{
    internal class Eclipse : Player
    {
        public Eclipse(string name, int speed, int dodge, int curhp, int maxhp, List<Attack> attacks, List<Status>? status, Dictionary<string, int>? resistances, int level, int exp) : base(name, speed, dodge, curhp, maxhp, attacks, status, resistances, level, exp)
        {
            this.name = name;
            this.speed = speed;
            this.dodge = dodge;
            this.maxhp = maxhp;
            this.curhp = curhp;
            this.attacks = GetAttacks();
            this.status = status;
            this.resistances = new Dictionary<string, int>() { };
            this.level = level;
            this.exp = exp;
        }
        public List<Attack> GetAttacks()
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
                atklist.Add(AttackLibrary.EclipseAttacks[i]);
            }
            return atklist;
        }
    }
}
