using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    internal class Attack
    {
        protected string attackName;
        protected int accuracy;
        protected int minDmg;
        protected int maxDmg;
        protected List<int> atkPosition;
        protected List<int> targetPosition;
        protected List<Status> statuses;
        protected int statusDuration;
        protected int statusAmount;

        public string AttackName
        {
            get { return attackName; }
            set { attackName = value; }
        }
        public int Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }
        public int MinDmg
        {
            get { return minDmg; }
            set { minDmg = value; }
        }
        public int MaxDmg
        {
            get { return maxDmg; }
            set { maxDmg = value; }
        }
        public List<int> AtkPosition
        {
            get { return atkPosition; }
            set { atkPosition = value; }
        }
        public List<int> TargetPosition
        {
            get { return targetPosition; }
            set { targetPosition = value; }
        }
        public List<Status> Statuses
        {
            get { return statuses; }
            set { statuses = value; }
        }


        public Attack(string AttackName, int Accuracy, int MinDmg, int MaxDmg, List<int> AtkPosition, List<int> TargetPosition, List <Status> Statuses)
        {
            this.attackName = AttackName;
            this.minDmg = MinDmg;
            this.maxDmg = MaxDmg;
            this.atkPosition = AtkPosition;
            this.targetPosition = TargetPosition;
            this.statuses = Statuses;

        }
    }
}
