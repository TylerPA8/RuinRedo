using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    public class Combat
    {

        public static void CombatFlow(Creature[] players, Creature[] enemies)
        {
            bool combatIsActive = true;
            var initiative = Initiative(players, enemies);
            while (combatIsActive)
            {
                foreach (var c in initiative)
                {

                }
                initiative = Initiative(players, enemies);
            }
        }
        public static List<KeyValuePair<Creature, int>> Initiative(Creature[] players, Creature[] enemies)
        {
            List<KeyValuePair<Creature, int>> initiativeTracker = new();
            foreach (Creature p in players)
            {
                if (p.CurHp > 0)
                    initiativeTracker.Add(new KeyValuePair<Creature, int>(p, Utilities.Roll(p.Speed)));
            }
            foreach (Creature e in enemies)
            {
                if (e.CurHp > 0)
                    initiativeTracker.Add(new KeyValuePair<Creature, int>(e, Utilities.Roll(e.Speed)));
            }
            initiativeTracker.Sort((x,y) => y.Value.CompareTo(x.Value));
            return initiativeTracker;
        }
    }
}
