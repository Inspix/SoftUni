using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Bonuses
{
    class Pill : Bonus
    {
        public Pill(string id) : base(id, 0, 0, 100)
        {
            this.Countdown = 1;
        }
    }
}
