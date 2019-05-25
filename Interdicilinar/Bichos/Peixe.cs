using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Peixe : Animal, IAquatico,IOviparo
    {
        
        public Peixe()
        {
            
        }

        public bool ViveEmAgua { get => true; }
        public bool Mergulho { get => true; }
        public bool AguaDoce { get; set; }

        public override string Alimentar()
        {
            throw new NotImplementedException();
        }

        public string Botar()
        {
            throw new NotImplementedException();
        }

        public string Chocar()
        {
            throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}
