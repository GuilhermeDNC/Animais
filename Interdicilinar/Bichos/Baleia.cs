using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Baleia : Mamifero, IAquatico,IPredador
    {

        public Baleia()
        {
            Carnivoro = true;
            Peconhento = false;
            Pelos = false;
        }

        public bool ViveEmAgua { get => true;  }
        public bool Mergulho { get => true; }
        public bool AguaDoce { get => false; }

        public override string Alimentar()
        {
            return @"../../imagens-animais/baleia/baleiaAlimentando.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/baleia/baleiaAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/baleia/baleiaAtacando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/baleia/baleiaComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/baleia/baleiaMovimentando.jpg";
        }
    }
}
