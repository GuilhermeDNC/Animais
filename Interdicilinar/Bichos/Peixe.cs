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
            return @"../../imagens-animais/peixe/peixeComendo.jpg";
        }

        public string Botar()
        {
            return @"../../imagens-animais/peixe/peixeBotando.jpg";
        }

        public string Chocar()
        {
            return @"../../imagens-animais/peixe/peixechocando.jpg";
        }

        public override string Comunicar()
        {
            return @"../../imagens-animais/peixe/peixeComunicando.jpg";
        }

        public override string Movimentar()
        {
            return @"../../imagens-animais/peixe/peixeCaminhando.jpg";
        }
    }
}
