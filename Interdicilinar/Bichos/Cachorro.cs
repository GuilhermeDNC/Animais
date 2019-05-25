using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Cachorro : Mamifero,IPredador
    {

        public Cachorro()
        {
            Carnivoro = true;
            Peconhento = false;
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
            return "";
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
