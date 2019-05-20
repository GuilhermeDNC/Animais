using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Baleia : Mamifero, IAquatico
    {
        public Baleia(string nome,string nascimento,char sexo)
        {
            Nome = nome;
            try
            {
                Nascimento = DateTime.Parse(nascimento);
            }
            catch
            {
                throw new Exception("Data inválida!");
            }
            Sexo = sexo;

            QuantidadeMamas = 0;
            Pelos = false;
            Carnivoro = true;
            ViveEmAgua = true;
            AguaDoce = false;

        }
        public bool ViveEmAgua { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
