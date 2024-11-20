﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo
{
    internal class Status
    {
        protected string statusName;
        protected List <Creatures> effectTargets;
        protected int effectNumber;        
        protected int effectDuration;

        public string StatusName
        {
            get { return statusName; }
            set { statusName = value; }
        }
        public int EffectNumber
        {
            get { return effectNumber; }
            set { effectNumber = value; }
        }
        public List <Creatures> EffectTargets
        {
            get { return effectTargets; }
            set { effectTargets = value; }
        }
        public int EffectDuration
        {
            get { return effectDuration; }
            set { effectDuration = value; }
        }

        public Status(string statusName, List <Creatures> effectTargets, int effectNumber, int effectDuration)
        {
            this.statusName = statusName;
            this.effectTargets = effectTargets;
            this.effectNumber = effectNumber;
            this.effectDuration = effectDuration;
        }
    }
}