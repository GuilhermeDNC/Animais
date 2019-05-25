using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Ornitorrinco : Mamifero, IAquatico, IOviparo,IPredador
    {
        public Ornitorrinco()
        {
            Peconhento = true;
            Carnivoro = true;
            Pelos = true;
        }

        public bool ViveEmAgua { get => true;  }
        public bool Mergulho { get => true; }
        public bool AguaDoce { get => true; }

        public override string Alimentar()
        {
            throw new NotImplementedException();
        }

        public override string Amamentar()
        {
            throw new NotImplementedException();
        }

        public string Ataque()
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
