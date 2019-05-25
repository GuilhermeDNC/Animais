using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Pato : Ave, IVoar,IPredador,IOviparo
    {
        public Pato()
        {
            Peconhento = false;
            Carnivoro = true;
            Rapina = false;
        }
        public int AltitudeMaximaEmMetros { get ; set; }
        public double VelocidadeDoVoo { get; set ; }

        public override string Alimentar()
        {
            return @"../../imagens-animais/pato/patoComendo.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/pato/patoAtacando.jpg";
        }

        public string Botar()
        {
            return @"../../imagens-animais/pato/patoBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/pato/patoChocando.jpg";
        }

        public override string Ciscar()
        {
            return @"../../imagens-animais/pato/patoCiscando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/pato/patoComunicando.jpg";

        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/pato/patoCorrendo.png";
        }

        public string Voar()
        {
            return @"../../imagens-animais/pato/patoVoando.jpg";
        }
    }
}
