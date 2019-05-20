using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Tartaruga : Animal, IAquatico,IOviparo
    {
        public Tartaruga(string nome, string nascimento, char sexo)
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
            ViveEmAgua = true;
        }

        public bool ViveEmAgua { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public void Botar()
        {
        }

        public void Chocar()
        {
        }
    }
}
