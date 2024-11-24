using RuinRedo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    internal class Creature : IDamageable, ILevelable
    {
        protected string name;
        protected int maxhp;
        protected int curhp;
        protected int speed;
        protected int dodge;
        protected List<Attack> attacks = new List<Attack>();
        protected List<Status> status = new List<Status>();
        protected Dictionary <string, int> resistances = new Dictionary <string, int>();
        protected int level;
        protected int exp;

        public string Name => name;
        public int MaxHp
        {
            get { return maxhp; }
            set { maxhp = value; }
        }
        public int CurHp
        {
            get { return curhp; }
            set { curhp = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Dodge
        {
            get { return dodge; }
            set { dodge = value; }
        }
        public List<Attack> Attacks
        {
            get { return attacks; }
            set { attacks = value; }
        }
        public List<Status> Status
        {
            get { return status; }
            set { status = value; }
        }
        public Dictionary<string, int> Resistances
        {
            get { return resistances; }
            set { resistances = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }


        public Creature(string name, int speed, int dodge, int curhp, int maxhp, List<Attack>? attacks, List<Status>? status, Dictionary <string, int>? resistances, int level, int exp)
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

        public Creature()
        {

        }


        public void TakeDamage(int dmg)
        {
            this.CurHp -= dmg;
            if (this.CurHp <= 0)
            {
                this.Die();
            }
        }

        public void Die()
        {
            //TODO die method
        }

        public virtual void Move(Creature [] ca) { }

        public virtual void Move(Creature[] ca, dirBool dB) { }

        public virtual void SelectTarget(List<Creature> enemies)
        {

        }

        public virtual void SelectAttack()
        {

        }

        public void GainExp(int exp)
        {
            this.Exp += exp;
        }

        public virtual void LevelUp()
        {
            this.Level++;
        }
    }
}
