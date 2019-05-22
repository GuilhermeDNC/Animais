using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Pombo : Ave, IVoar
    {
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set ; }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
