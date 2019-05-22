using Interdicilinar.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interdicilinar.Estrutura.Lista
{
    public class Nodo
    {       
        public Animal Dado {get;set;}
        public Nodo Proximo { get; set;}       
        
        /// <summary>
        /// construtor sem parâmetros
        /// </summary>
        public Nodo()
        {
            Dado = null;
            Proximo = null;
        }
    }
}
