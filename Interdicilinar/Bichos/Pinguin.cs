using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Pinguin : Ave, IAquatico
    {
        public bool ViveEmAgua { get ; set ; }
        public bool Mergulho { get ; set ; }
        public bool AguaDoce { get ; set; }
    }
}
