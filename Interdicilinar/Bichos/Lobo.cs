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
            return @"../../imagens-animais/lobo/loboAlimentando.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/lobo/loboAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/lobo/loboAtacando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/lobo/loboComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/lobo/loboCaminhando.jpg";
        }

       
    }
}
