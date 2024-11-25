using RuinRedo.Statuses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    internal class AttackLibrary
    { 
    public static readonly List<Attack> PhalanxAttacks = new List<Attack>();
    public static readonly List<Attack> WeaverAttacks = new List<Attack>();
    public static readonly List<Attack> EclipseAttacks = new List<Attack>();
    public static readonly List<Attack> GoblinAttacks = new List<Attack>();
    public static readonly List<Attack> GoblinMageAttacks = new List<Attack>();

        internal void InitializeAttacks()
        {
            //For targetting, 1 indicates a valid target, 0 is not available.
            //So far the statuses I need are: Bleed, Stun, Burn, Freeze, a way to mark a target (to increase or reduce damage), Poison, Concentration(?), Barrier, Fear (disadvantage, can't use forward attacks), Blind, and Movement.


            //Phalanx - Sturdy and average damage, bleeds chance, back line blaster build option
            Attack Puncture = new("Puncture", 0, 0, 0, [0, 1, 1, 1], [1, 1, 1, 1], null); //Test Puncture
            //Attack Puncture = new("Puncture", 10, 3, 8, [0, 1, 1, 1], [1, 1, 1, 1], null, 0, 0); //Basic damage, pushes target back
            Attack Skewer = new("Skewer", 10, 2, 4, [0, 0, 1, 1], [1, 1, 0, 0], null); //Bleed chance, hits target and 1 behind it.
            Attack ShieldBash = new("Shield Bash", 15, 1, 4, [0, 1, 1, 1], [1, 1, 1, 1], null); //Stun chance
            Attack Brace = new("Brace", 0, 0, 0, [0, 1, 1, 1], [1, 1, 1, 1], null); //Reduces all attacks by 1-4 damage.
            Attack Hurl = new("Hurl", 15, 1, 6, [1, 1, 1, 0], [0, 0, 1, 1], null); //Ranged backline attack, knocks target back, chance to bleed.
            Attack PointedCurse = new("Pointed Curse", 10, 1, 4, [1, 1, 1, 0], [1, 1, 1, 1], null); //Marks a target for 3 rounds, dealing an additional 1-4 damage per attacks
            Attack CursedBlast = new("Cursed Blast", 15, 1, 10, [1, 1, 1, 0], [1, 1, 1, 1], null); //Basic damage
            Attack Cover = new("Cover", 0, 0, 0, [0, 0, 0, 1], [1, 1, 1, 0], null); //Blocks next 2 attacks on ally.
            PhalanxAttacks.Add(Puncture);
            PhalanxAttacks.Add(Skewer);
            PhalanxAttacks.Add(ShieldBash);
            PhalanxAttacks.Add(Brace);
            PhalanxAttacks.Add(Hurl);
            PhalanxAttacks.Add(PointedCurse);
            PhalanxAttacks.Add(CursedBlast);
            PhalanxAttacks.Add(Cover);

            //Weaver - High damage but low hp character, status applier build option
            Attack PoisonSpray = new("Poison Spray", 20, 1, 4, [0, 0, 1, 1], [1, 1, 0, 0], null); //Small damage, builds up poison, back 1
            Attack Incinerate = new("Incinerate", 20, 2, 12, [0, 1, 1, 1], [1, 1, 1, 0], null); //High damage, chance to burn
            Attack Arc = new("Arc", 30, 1, 4, [1, 1, 1, 1], [1, 1, 1, 1], null); //On hit, chains and hits additional targets until a miss, stun chance
            Attack LightningBolt = new("Lightning Bolt", 0, 4, 16, [1, 1, 0, 0], [1, 1, 1, 1], null); //Very high damage, but unable to pick target, can hit empty space
            Attack ArcaneBolt = new("ArcaneBolt", 0, 1, 4, [1, 1, 1, 0], [1, 1, 1, 1], null); //Always hits, damage not reduced
            Attack Conduit = new("Conduit", 5, 0, 0, [1, 1, 1, 0], [1, 1, 1, 1], null); //Marks a target for 3 rounds, magic damage to target fires an Arcane Bolt at a nearby enemy
            Attack Chill = new("Chill", 15, 1, 8, [0, 1, 1, 1], [1, 1, 1, 0], null); //Applies freeze stacks
            Attack Overcharge = new("Overcharge", 0, 0, 0, [1, 1, 1, 0], [0, 1, 1, 1], null); //Attacks are rolled at advantage until hit, increases crit by +1
            WeaverAttacks.Add(PoisonSpray);
            WeaverAttacks.Add(Incinerate);
            WeaverAttacks.Add(Arc);
            WeaverAttacks.Add(LightningBolt);
            WeaverAttacks.Add(ArcaneBolt);
            WeaverAttacks.Add(Conduit);
            WeaverAttacks.Add(Chill);
            WeaverAttacks.Add(Overcharge);

            //Eclipse - Healing, buffing, and debuffing class. Low damage but high utility
            Attack Shroud = new("Shroud", 0, 1, 4, [1, 1, 1, 0], [1, 1, 1, 1], null); //Small heal and dodge bonus on ally
            Attack HealingLight = new("Healing Light", 0, 1, 4, [1, 1, 1, 0], [1, 1, 1, 1], null); //Places a beam of moonlight that heals the target in the selected slot
            Attack SilverBarrier = new("Silver Barrier", 0, 2, 12, [1, 1, 1, 0], [0, 1, 1, 1], null); //Places a barrier on the target, absorbing X damage
            Attack BlindingRing = new("Blinding Ring", 20, 0, 0, [1, 1, 1, 1], [1, 1, 1, 1], null); //Reduces the targets accuracy for 2 rounds
            Attack EmptySky = new("Empty Sky", 20, 1, 4, [1, 1, 1, 1], [1, 1, 1, 1], null); //Deals small damage and fears a target
            Attack CresentShield = new("Cresent Shield", 0, 0, 0, [1, 1, 0, 0], [0, 1, 1, 1], null); //Provides a shield equal to the targets missing hp, lasts for 1 round
            Attack SweepingBlade = new("Sweeping Blade", 20, 1, 6, [0, 0, 1, 1], [1, 1, 1, 0], null); //Damage and a chance to bleed and blind
            Attack SolarFlare = new("Solar Flare", 15, 1, 4, [1, 1, 0, 0], [0, 1, 1, 0], null); //Hits 1 target on either side, dealing damage and blinding
            EclipseAttacks.Add(Shroud);
            EclipseAttacks.Add(HealingLight);
            EclipseAttacks.Add(SilverBarrier);
            EclipseAttacks.Add(BlindingRing);
            EclipseAttacks.Add(EmptySky);
            EclipseAttacks.Add(CresentShield);
            EclipseAttacks.Add(SweepingBlade);
            EclipseAttacks.Add(SolarFlare);

            //Goblin Attacks
            Attack TaintedShank = new("Tainted Shank",15, 1, 4, [1, 1, 0, 0], [0, 0, 1, 1], null); //Weak, also deals low poison
            Attack ChokeCloud = new("Choke Cloud", 15, 0, 1, [1, 0, 0, 0], [0, 0, 0, 1], null); //Low damage, but lowers accuracy of target
            Attack Volley = new("Volley",25,  1, 6, [0, 0, 1, 1], [1, 1, 1, 0], null); //Basic damage backline hit.
            GoblinAttacks.Add(TaintedShank);
            GoblinAttacks.Add(ChokeCloud);
            GoblinAttacks.Add(Volley);

            //Goblin Mage Attacks
            Attack Infect = new("Infect", 5, 2, 8, [0, 0, 1, 1], [0, 1, 1, 1], null); //Applies a heavy poison
            GoblinMageAttacks.Add(TaintedShank);
            GoblinMageAttacks.Add(ChokeCloud);
            GoblinMageAttacks.Add(PoisonSpray);
            GoblinMageAttacks.Add(Infect);
        }
    }
}
