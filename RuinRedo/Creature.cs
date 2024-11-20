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
        protected int ac;
        protected List<Attack> attacks = new List<Attack>();
        protected List<Status> status = new List<Status>();
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
        public int Ac
        {
            get { return ac; }
            set { ac = value; }
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


        public Creature(string name, int ac, int maxhp, int curhp, List <Attack> attacks, List<Status>? status, int level, int exp)
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
        public virtual void SelectTarget(List<Creature> enemies)
        {

        }
        public virtual void SelectAttack()
        {

        }
        public void GainExp(int e)
        {
            this.Exp += exp;
        }
        public virtual void LevelUp()
        {
            this.Level++;
        }
    }
}
