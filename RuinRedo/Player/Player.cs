using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Player
{
    internal class Player : Creature
    {
        public Player (string name, int ac, int maxhp, int curhp, List<Attack> attacks, List<Status>? status, int level, int exp) : base(name, ac, maxhp, curhp, status, level, exp) 
        {
            this.name = name;
            this.ac = ac;
            this.maxhp = maxhp;
            this.curhp = curhp;
            this.attacks = attacks;
            this.status = status;
            this.level = level;
            this.exp = exp;
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
