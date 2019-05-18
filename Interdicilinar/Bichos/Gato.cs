using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Gato : Mamifero, IPredador
    {
        public Gato()
        {
            QuantidadeMamas = 8;
            Pelos = true;
            Carnivoro = true;
        }

        public void Ataque()
        {
            throw new NotImplementedException();
        }
    }
}
