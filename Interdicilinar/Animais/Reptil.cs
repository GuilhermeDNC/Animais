using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    public abstract class Reptil:Animal,IOviparo
    {
        private bool temEscamas;
        private bool temCasco;

        public bool TemEscamas
        {
            get
            {
                return temEscamas;
            }
            set
            {
                temEscamas = value;
            }
        }

        public bool TemCasco
        {
            get
            {
                return temCasco;
            }
            set
            {
                temCasco = value;
            }
        }

        public abstract string Botar();



        public abstract string Chocar();
       
    }
}
