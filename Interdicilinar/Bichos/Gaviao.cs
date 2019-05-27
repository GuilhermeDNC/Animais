using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Gaviao : Ave, IPredador,IVoar,IOviparo
    {

        public Gaviao()
        {
            Peconhento = false;
            Rapina = true;
            Carnivoro = true;
        }
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set; }

        public override string Alimentar()
        {
            return @"../../imagens-animais/gaviao/gaviaoComendo.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/gaviao/gaviaoAtacando.jpg";
        }

        public string Botar()
        {
            return @"../../imagens-animais/gaviao/gaviaoBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/gaviao/gaviaoChocando.jpg";
        }

        public override string Ciscar()
        {
            return @"../../imagens-animais/gaviao/gaviaoCiscando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/gaviao/gaviaoComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/gaviao/gaviaoCaminhando.jpg";
        }

        public string Voar()
        {
            return @"../../imagens-animais/gaviao/gaviaoVoando.jpg";
        }
    }
}
