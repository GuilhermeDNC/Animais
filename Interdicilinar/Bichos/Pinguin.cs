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
            return @"../../imagens-animais/pinguim/pinguimAlimentando.jpg";
        }

        public string Botar()
        {
            return @"../../imagens-animais/pinguim/pinguimBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/pinguim/pinguimChocando.jpg";
        }

        public override string Ciscar()
        {
            return @"../../imagens-animais/pinguim/pinguimCiscando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/pinguim/pinguimComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/pinguim/pinguimCaminhando.jpg";
        }
    }
}
