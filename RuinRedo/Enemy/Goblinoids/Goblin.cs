using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Enemy.Goblinoids
{
    internal class Goblin : Enemy
    {
        public Goblin(string name, int speed, int dodge, int curhp, int maxhp, List<Attack> attacks, List<Status>? status, int level, int exp) : base(name, speed, dodge, curhp, maxhp, attacks, status, level, exp)
        {
            this.name = name;
            this.speed = speed;
            this.dodge = dodge;
            this.maxhp = maxhp;
            this.curhp = curhp;
            this.attacks = AttackLibrary.GoblinAttacks;
            this.status = status;
            this.level = level;
            this.exp = exp;
        }
    }
}
