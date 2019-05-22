using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Logicas
{
    public class NomeRepetidoException:Exception
    {
        public NomeRepetidoException(string mensagem):base(mensagem)
        {
        }

    }
}
