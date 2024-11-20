using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Interfaces
{
    internal interface ILevelable
    {
        int Level { get; }
        int Exp { get; }
        void LevelUp() { }
        void GainExp() { }
    }
}
