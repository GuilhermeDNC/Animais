using Interdicilinar.Bichos;
using Interdicilinar.Estrutura.Arvore;
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
    public partial class Form1 : Form
    {

        private ArvoreBin arvoreBin = new ArvoreBin(new ComparadorCodigo());
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List lista = new List();
           // ArvoreBin arvore = new ArvoreBin(new ComparadorCodigo());

            Gaviao ave = new Gaviao();

            ave.Carnivoro = true;
            ave.CorPena = "azul";
            ave.Nascimento = DateTime.Parse("02/05/2000");
            ave.Sexo = 'M';
            ave.Rapina = true;
            ave.Peconhento = false;
            ave.Nome = "Galinha";

            Baleia baleia = new Baleia();
            baleia.Nome = "Free Willy";
            baleia.Peconhento = false;
            baleia.Nascimento = DateTime.Parse("02/03/2005");
            baleia.Sexo = 'F';
            baleia.ViveEmAgua = true;
            baleia.QuantidadeMamas = 8;
            baleia.Pelos = false;
            baleia.Mergulho = true;
            

            lista.InserirNoFim(ave);
            lista.InserirNaPosicao(baleia,0);

            //arvore.Insere(ave);
            //arvore.Insere(baleia);

           // MessageBox.Show(arvore.ListagemEmOrdem());

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar formCadastrar = new Cadastrar();
            formCadastrar.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar formListar = new Listar();
            formListar.ShowDialog();
        }
    }
}
