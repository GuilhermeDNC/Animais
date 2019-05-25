using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Pinguin : Ave, IAquatico,IOviparo
    {

        public Pinguin()
        {
            Peconhento = false;
            Carnivoro = true;
            Rapina = false;
        }
        public bool ViveEmAgua { get => false ;  }
        public bool Mergulho { get => true;  }
        public bool AguaDoce { get => false;  }

        public override string Alimentar()
        {
            throw new NotImplementedException();
        }

        public string Botar()
        {
            throw new NotImplementedException();
        }

        public string Chocar()
        {
            throw new NotImplementedException();
        }

        public override void Ciscar()
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
