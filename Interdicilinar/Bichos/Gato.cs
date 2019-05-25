using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    class Gato : Mamifero, IPredador
    {

        public Gato()
        {
            Peconhento = false;
            Carnivoro = true;

        }
        public override string Alimentar()
        {
            return @"../../imagens-animais/gato/gatoComendo.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/gato/gatoAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/gato/gatoAtacando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/gato/gatoComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/gato/gatoCaminhando.jpg";
        }
    }
}
