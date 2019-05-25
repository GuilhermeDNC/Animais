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
            throw new NotImplementedException();
        }

        public string Ataque()
        {
            return "";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/baleia/baleiaComunicando.gif";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/baleia/baleiaCaminhando.gif";
        }
    }
}
