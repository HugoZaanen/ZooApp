using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Lion : Animal
    {
        public override void UseEnergy()
        {
            Energy -= 5;
        }
    }
}
