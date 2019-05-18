using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Animais
{
    public abstract class Mamifero:Animal
    {
        private int quantidadeMamas;
        private bool pelos;
        private string corDoPelo;

        public int QuantidadeMamas
        {
            get
            {
                return quantidadeMamas;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Quantidade de mamas invalida");
                }
                else
                {
                    quantidadeMamas = value;
                }
            }
        }

        public bool Pelos
        {
            get
            {
                return pelos;
            }
            set
            {
                pelos = value;
            }
        }

        public string CorDoPelo
        {
            get
            {
                if (!pelos)
                {
                    throw new Exception("O animal não tem pelo");
                }
                else
                {
                    return corDoPelo;
                }
            }
            set
            {
                if(value == null)
                {
                    throw new Exception("Cor invalida");
                }
                else
                {
                    corDoPelo = value;
                }
            }
        }

        public void Amamentar()
        {

        }

    }
}
