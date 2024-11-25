using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Statuses
{
    public class Status
    {
        protected int effect;
        protected int duration;

        public int Effect
        {
            get { return effect; }
            set { effect = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Status(int effect, int duration)
        {
            this.effect = effect;
            this.duration = duration;
        }
        public Status (int effect)
        {
            this.effect = effect;
        }
        public virtual void Apply() { }
        public virtual void Use() { }
    }
}
