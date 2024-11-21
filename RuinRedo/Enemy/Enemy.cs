using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Enemy
{
    internal class Enemy : Creature
    {
        public Enemy(string name, int speed, int dodge, int curhp, int maxhp, List<Attack> attacks, List<Status>? status, int level, int exp) : base(name, speed, dodge, curhp, maxhp, status, level, exp)
        {
            this.name = name;
            this.speed = speed;
            this.dodge = dodge;
            this.curhp = curhp;
            this.maxhp = maxhp;
            this.attacks = attacks;
            this.status = status;
            this.level = level;
            this.exp = exp;
        }

        public override void SelectTarget(List<Creature> enemies)
        {
            //TODO auto select a target
        }
        public override void SelectAttack()
        {
            //TODO auto select an appropriate attack
        }
    }
}
