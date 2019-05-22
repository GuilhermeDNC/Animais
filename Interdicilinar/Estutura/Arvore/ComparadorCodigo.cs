using Interdicilinar.Animais;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Estrutura.Arvore
{
    public class ComparadorCodigo : IComparer
    {
        public int Compare(object x, object y)
        {
            string nomeX = (x as Animal).Nome;
            string nomeY = (y as Animal).Nome;

            

            return nomeX.CompareTo(nomeY);
            /*
            if (codigoX > codigoY)
                return 1;
            else if (codigoX == codigoY)
                return 0;
            else
                return -1; */

            //return (((Funcionario)x).Codigo).CompareTo(((Funcionario)y).Codigo);
        }
    }
}
