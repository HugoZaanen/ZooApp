using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Elephant : Animal
    {

        public override void Eat()
        {
            Energy += 50;
        }

        public override void UseEnergy()
        {
            Energy -= 10;
        }
    }
}
