using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Coruja : Ave, IVoar,IPredador,IOviparo
    {
        public Coruja()
        {
            Peconhento = false;
            Carnivoro = true;
            Rapina = true;
        }
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set ; }

        public override string Alimentar()
        {
            return @"../../imagens-animais/coruja/corujaComendo.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/coruja/corujaAtacando.jpg";
        }

        public string Botar()
        {
            return @"../../imagens-animais/coruja/corujaBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/coruja/corujaChocando.jpg";
        }

        public override string Ciscar()
        {
            return @"../../imagens-animais/coruja/corujaCiscando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/coruja/corujaComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/coruja/corujaMovimentando.jpg";
        }

        public string Voar()
        {
            return @"../../imagens-animais/coruja/corujaVoando.jpg";
        }
    }
}
