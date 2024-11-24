using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Enemy.Goblinoids
{
    internal class Goblin : Enemy
    {
        public Goblin(string name, int speed, int dodge, int curhp, int maxhp, List<Attack> attacks, List<Status>? status, Dictionary<string, int>? resistances, int level, int exp) : base(name, speed, dodge, curhp, maxhp, attacks, status, resistances, level, exp)
        {
            this.name = name;
            this.speed = speed;
            this.dodge = dodge;
            this.maxhp = maxhp;
            this.curhp = curhp;
            this.attacks = AttackLibrary.GoblinAttacks;
            this.status = status;
            this.resistances = new Dictionary<string, int> (){ { "Move", 10 }, { "Poison", 60 } };
            this.level = level;
            this.exp = exp;
        }
    }
}
