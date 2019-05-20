using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animais
{
    public abstract class Ave :Animal
    {
        private string corPena;
    
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

        public bool Rapina { get; set; }

        public void Ciscar() { }
    }
}
