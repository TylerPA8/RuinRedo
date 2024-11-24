using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Statuses
{
    internal class Push : Status
    {
        Creature[] enemies = new Creature[4];
        public Push (int effect) : base (effect) { }
        public void Use(Creature target)
        {
            Random rnd = new Random();
            if (target.Resistances.ContainsKey("Move"))
            {
                int resist = rnd.Next(1, 101);
                if (resist > target.Resistances["Move"])
                {
                    target.Move(this.enemies, dirBool.Right);
                }
            }

        }
    }
}
