using Animais.Animais;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Estrutura.Arvore
{
    public class ComparadorCodigo : IComparer
    {
        public int Compare(object x, object y)
        {
            int codigoX = ((Animal)x).Codigo;
            int codigoY = (y as Animal).Codigo;

            //return codigoX.CompareTo(codigoY);

            if (codigoX > codigoY)
                return 1;
            else if (codigoX == codigoY)
                return 0;
            else
                return -1;

            //return (((Funcionario)x).Codigo).CompareTo(((Funcionario)y).Codigo);
        }
    }
}
