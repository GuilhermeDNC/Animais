using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    interface IAquatico
    {
        bool ViveEmAgua { get; set; }
        bool Mergulho { get; set; }
        bool AguaDoce { get; set; }
    }
}
