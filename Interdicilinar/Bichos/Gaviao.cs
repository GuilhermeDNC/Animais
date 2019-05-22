using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Gaviao : Ave, IPredador,IVoar
    {
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set; }

        public void Ataque()
        {
            throw new NotImplementedException();
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
