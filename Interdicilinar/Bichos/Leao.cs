using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Bichos
{
    public class Leao : Mamifero, IPredador
    {
        public Leao()
        {
            Peconhento = false;
            Carnivoro = true;
        }
        public override string Alimentar()
        {
            return @"../../imagens-animais/leao/leaoComendo.jpg";
        }

        public override string Amamentar()
        {
            return @"../../imagens-animais/leao/leaoAmamentando.jpg";
        }

        public string Ataque()
        {
            return @"../../imagens-animais/leao/leaoAtacando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/leao/leaoComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/leao/leaoCorrendo.jpg";
        }
    }
}
