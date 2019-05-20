using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animais
{
    public abstract class Reptil:Animal
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
    }
}
