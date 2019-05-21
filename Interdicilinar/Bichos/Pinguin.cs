using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Pinguin:Ave
    {
        public Pinguin(string nome, string nascimento, char sexo, string corDPena)
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
            CorPena = corDPena;
            Carnivoro = true;

        }
    }
}
