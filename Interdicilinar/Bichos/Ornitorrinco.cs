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
            return @"../../imagens-animais/ornitorrinco/ornitorrincoComendo.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/ornitorrinco/ornitorrincoAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/ornitorrinco/ornitorrincoAtacando.jpg";

        }

        public string Botar()
        {
            return @"../../imagens-animais/ornitorrinco/ornitorrincoBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/ornitorrinco/ornitorrincoChocando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/ornitorrinco/ornitorrincoComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/ornitorrinco/ornitorrincoCaminhando.jpg";
        }
    }
}
