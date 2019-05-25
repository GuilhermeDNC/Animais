using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Lobo : Mamifero, IPredador
    {
        public Lobo()
        {
            Peconhento = false;
            Carnivoro = true;
        }
        public override string Alimentar()
        {
            throw new NotImplementedException();
        }

        public override string Amamentar()
        {
            throw new NotImplementedException();
        }

        public string Ataque()
        {
            throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            throw new NotImplementedException();
        }

       
    }
}
