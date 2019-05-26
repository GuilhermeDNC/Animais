using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    abstract class Peixe : Animal, IAquatico, IOviparo
    {
        public bool ViveEmAgua { get => true; }

        public bool Mergulho { get => true; }

        public bool AguaDoce { get; set; }

        public abstract string Botar();

        public abstract string Chocar();

    }
}
