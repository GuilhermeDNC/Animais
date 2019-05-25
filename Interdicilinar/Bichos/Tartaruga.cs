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
            return @"../../imagens-animais/tartaruga/tartarugaAlimentando.jpg";
        }

        public override string Botar()
        {
            return @"../../imagens-animais/tartaruga/tartarugaBotando.jpg";
        }

        public override string Chocar()
        {
            return @"../../imagens-animais/tartaruga/tartarugaChocando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/tartaruga/tartarugaComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/tartaruga/tartarugaCaminhando.jpg";
        }
    }
}
