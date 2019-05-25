using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Tartaruga : Reptil, IAquatico,IOviparo
    {

        public Tartaruga()
        {
            Peconhento = false;
            Carnivoro = true;
            TemCasco = true;
            TemEscamas = true;
        }
        public bool ViveEmAgua { get => true;  }
        public bool Mergulho { get => true; }
        public bool AguaDoce { get => false;  }

        public override string Alimentar()
        {
            throw new NotImplementedException();
        }

        public override string Botar()
        {
            throw new NotImplementedException();
        }

        public override string Chocar()
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
