using Animais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Bichos
{
    public class Leao : Mamifero, IPredador
    {
        public Leao(string nome, string nascimento, char sexo, string corDoPelo)
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
            CorDoPelo = corDoPelo;
            QuantidadeMamas = 8;
            Pelos = true;
            Carnivoro = true;
        }
        public void Ataque()
        {
            throw new NotImplementedException();
        }
    }
}
