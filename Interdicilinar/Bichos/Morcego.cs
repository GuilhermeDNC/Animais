using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Morcego : Mamifero, IVoar,IPredador
    {

        public Morcego()
        {
            Peconhento = false;
            Pelos = false;
        }
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set ; }

        public override string Alimentar()
        {
            return @"../../imagens-animais/morcego/morcegoAlimentando.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/morcego/morcegoAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/morcego/morcegoAtacando.png";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/morcego/morcegoComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/morcego/morcegoCaminhando.jpg";
        }

        public string Voar()
        {
            return @"../../imagens-animais/morcego/morcegoVoando.jpg";
        }
    }
}
