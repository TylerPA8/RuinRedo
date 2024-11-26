using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Enemy
{
    internal class Enemy : Creature
    {
        public Enemy(string name, int speed, int dodge, int curhp, int maxhp, List<Attack> attacks, List<Status>? status, Dictionary<string, int>? resistances, int level, int exp) : base(name, speed, dodge, curhp, maxhp, attacks, status, resistances, level, exp)
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


        public override void SelectAttack()
        {
            //TODO auto select an appropriate attack
        }
        

        public override void SelectTarget(List<Creature> enemies)
        {
            //TODO auto select a target
        }


        public override void Move(Creature[] party, dirBool db)
        {
            int dir = 0;
            if ((db == dirBool.Left) && Array.IndexOf(party, this) != 0)
                dir = -1;
            else if ((db == dirBool.Right) && Array.IndexOf(party, this) != 3)
                dir = 1;
            var oldIndex = Array.IndexOf(party, this);
            int newIndex = oldIndex + dir;
            Creature swap = party[newIndex];
            party[newIndex] = this;
            party[oldIndex] = swap;
        }
    }
}
