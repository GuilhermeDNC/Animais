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

        private ArvoreBin arvoreBin = UtilExtensions.arvore;
        public Form1()
        {
            InitializeComponent();
            Baleia baleia = new Baleia();
            baleia.Nome = "Free Willy";
            baleia.Peconhento = false;
            baleia.Pelos = false;
            baleia.QuantidadeMamas = 4;
            baleia.Sexo = 'M';
            baleia.Nascimento = DateTime.Parse("09/11/2000");

            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Dogão";
            cachorro.Peconhento = false;
            cachorro.Pelos = true;
            cachorro.CorDoPelo = "Preto";
            cachorro.QuantidadeMamas = 8;
            cachorro.Sexo = 'M';
            cachorro.Nascimento = DateTime.Parse("10/09/1995");

            Coruja coruja = new Coruja();
            coruja.Nome = "Edwiges";
            coruja.Nascimento = DateTime.Parse("02/02/2002");
            coruja.Peconhento = false;
            coruja.Rapina = true;
            coruja.Sexo = 'F';
            coruja.VelocidadeDoVoo = 30;
            coruja.AltitudeMaximaEmMetros = 30;

            Gato gato = new Gato();
            gato.Nome = "Fred";
            gato.Peconhento = false;
            gato.Pelos = true;
            gato.CorDoPelo = "Preto";
            gato.QuantidadeMamas = 8;
            gato.Sexo = 'M';
            gato.Nascimento = DateTime.Parse("10/09/1998");

           Gaviao gaviao = new Gaviao();
           gaviao.Nome = "Hawk";
           gaviao.Nascimento = DateTime.Parse("01/01/2001");
           gaviao.Peconhento = false;
           gaviao.Rapina = true;
           gaviao.Sexo = 'M';
           gaviao.VelocidadeDoVoo = 50;
           gaviao.AltitudeMaximaEmMetros = 50;

            Leao leao = new Leao();
            leao.Nome = "Lion";
            leao.Peconhento = false;
            leao.Pelos = true;
            leao.CorDoPelo = "Amarelo";
            leao.QuantidadeMamas = 8;
            leao.Sexo = 'M';
            leao.Nascimento = DateTime.Parse("20/10/2010");


            Tartaruga tartaruga = new Tartaruga();
            tartaruga.Nome = "Esmeralda";
            tartaruga.Nascimento = DateTime.Parse("11/11/2011");
            tartaruga.Peconhento = false;
            tartaruga.Sexo = 'F';
            tartaruga.TemCasco = true;
            tartaruga.TemEscamas = true;
            tartaruga.Carnivoro = true;

            arvoreBin.Insere(baleia);
            arvoreBin.Insere(cachorro);
            arvoreBin.Insere(coruja);
            arvoreBin.Insere(gato);
            arvoreBin.Insere(gaviao);
            arvoreBin.Insere(leao);
            arvoreBin.Insere(tartaruga);
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
            baleia.QuantidadeMamas = 8;
            baleia.Pelos = false;
            

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
