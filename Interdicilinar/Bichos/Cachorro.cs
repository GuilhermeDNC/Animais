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
            return @"../../imagens-animais/cachorro/cachorroAlimentando.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/cachorro/cachorroAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/cachorro/cachorroAtacando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/cachorro/cachorroComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/cachorro/cachorroMovimentando.jpg";
        }
    }
}
