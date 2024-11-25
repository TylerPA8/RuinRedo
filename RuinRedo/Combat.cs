using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    public class Combat
    {
        public Dictionary<Creature, int> initiativeTracker = new();
        Creature[] players;
        Creature[] enemies;


        public Combat(Creature[] players, Creature[] enemies)
        {
            this.players = players;
            this.enemies = enemies;
        }
        public Dictionary<Creature, int> Initiative(Creature[] players, Creature[] enemies)
        {
            return initiativeTracker;
        }
    }
}
