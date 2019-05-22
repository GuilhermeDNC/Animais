using Interdicilinar.Estrutura.Lista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interdicilinar
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private List animais = UtilExtensions.arvore.ListagemEmOrdem();
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            //lbAnimais.Items.Clear();
            //string[] nomesAnimais = animais.Listar().Split(' ');
            //foreach (string animal in nomesAnimais)
            //{
            //    lbAnimais.Items.Add(animal);
            //}
        }

        private void rbMamiferos_CheckedChanged(object sender, EventArgs e)
        {
            lbAnimais.Items.Clear();
        }
    }
}
