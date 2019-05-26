using Interdicilinar.Animais;
using Interdicilinar.Estrutura.Arvore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar
{
    public static class UtilExtensions
    {
        public static ArvoreBin arvore = new ArvoreBin(new ComparadorCodigo());
        public static Animal animalAtual;
        public static string imagemAtual = @"../../imagens-animais/baleia/baleia.jpg";
    }
}
