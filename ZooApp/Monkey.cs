using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Monkey : Animal
    {
        //private new int Energy { get; set; } = 20;
        public Monkey()
        {
            Energy = 20;
        }

        public override void Eat()
        {
            Energy += 10; 
        }

        public override void UseEnergy()
        {
            Energy -= 2;
        }
    }
}