using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuinRedo.Interfaces
{
    internal interface IDamageable
    {
        int CurHp {  get; }
        int MaxHp { get; }
        void TakeDamage() { }
    }
}
