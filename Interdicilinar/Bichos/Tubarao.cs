using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Tubarao : Animal, IAquatico,IPredador
    {
        public Tubarao(string nome, string nascimento, char sexo)
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
            Mergulho = true;
            AguaDoce = false;
        }
        public bool ViveEmAgua { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public void Ataque()
        {
            
        }
    }
}
