using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Pombo : Ave, IVoar,IOviparo
    {
        public Pombo()
        {
            Peconhento = false;
            Carnivoro = true;
            Rapina = false;
        }
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set ; }

        public override string Alimentar()
        {
            return @"../../imagens-animais/pombo/pomboComendo.jpg";
        }

        public string Botar()
        {
            return @"../../imagens-animais/pombo/pomboBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/pombo/pomboChocando.jpg";
        }

        public override string Ciscar()
        {
            return @"../../imagens-animais/pombo/pomboCiscando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/pombo/pomboComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/pombo/pomboCaminhando.jpg";
        }

        public string Voar()
        {
            return @"../../imagens-animais/pombo/pomboVoando.jpg";
        }
    }
}
