using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public Ornitorrinco(char sexo)
        {
            if(sexo == 'm')
            {
                Peconhento = true;
            }
            ViveEmAgua = false;
            AguaDoce = true;
            Carnivoro = true;
            Pelos = true;
            Mergulho = true;
            
        }
        public bool ViveEmAgua { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set ; }

        public void Botar()
        {
            
        }

        public void Chocar()
        {
            
        }
    }
}
