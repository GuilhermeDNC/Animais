using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    public abstract class Ave :Animal
    {
        private bool rapina;
        private string corPena;
        public bool Rapina
        {
            get
            {
                return rapina;
            }
            set
            {
                rapina = value;
            }
        }

        public string CorPena
        {
            get
            {
                return corPena;
            }
            set
            {
                if(value == null)
                {
                    throw new Exception("Cor invalida");
                }
                else
                {
                    corPena = value;
                }
            }
        }

        public void Ciscar() { }
    }
}
