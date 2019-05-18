using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Gaviao : Ave, IPredador
    {
        public Gaviao()
        {
            Rapina = true;
            Carnivoro = true;
        }
        public void Ataque()
        {
            throw new NotImplementedException();
        }
    }
}
