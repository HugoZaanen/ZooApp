using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class Animal : INotifyPropertyChanged
    {
        public string Name { get; set; }
        private int _energy;

        public Animal()
        {
            Energy = 10;
        }
        public int Energy
        {
            get { return _energy; }
            set
            {
                _energy = value;

                //Check voor het raisen van een even altijd eerst of er objecten luisten naar deze event
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Energy"));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("description"));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        virtual public void Eat()
        {
            this.Energy += 25;
        }

        public abstract void UseEnergy();

        public override string ToString()
        {
            return $"{Name} {Energy}";            
        }

        public string Description => ToString();

    }
}