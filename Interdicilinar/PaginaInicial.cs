using Interdicilinar.Animais;
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
    public partial class PaginaInicial : Form
    {

        private ArvoreBin arvoreBin = UtilExtensions.arvore;
        public PaginaInicial()
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
            coruja.CorPena = "Preto e Branco";
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
            gaviao.CorPena = "Preto e amarelo";
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

            Lobo lobo = new Lobo();
            lobo.Nome = "Van Helsing";
            lobo.Peconhento = false;
            lobo.Pelos = true;
            lobo.CorDoPelo = "Cinza";
            lobo.QuantidadeMamas = 8;
            lobo.Sexo = 'F';
            lobo.Nascimento = DateTime.Parse("20/10/2010");

            Morcego morcego = new Morcego();
            morcego.Nome = "Batman";
            morcego.Peconhento = false;
            morcego.Pelos = false;
            morcego.QuantidadeMamas = 6;
            morcego.Sexo = 'F';
            morcego.Nascimento = DateTime.Parse("20/10/2013");

            Ornitorrinco ornitorrinco = new Ornitorrinco();
            ornitorrinco.Nome = "Perry";
            ornitorrinco.QuantidadeMamas = 8;
            ornitorrinco.Sexo = 'F';
            ornitorrinco.Nascimento = DateTime.Parse("20/10/2010");

           Pato pato = new Pato();
           pato.Nome = "Donald";
           pato.Nascimento = DateTime.Parse("01/09/2018");
           pato.CorPena = "Preto e amarelo";
           pato.Sexo = 'M';
           pato.VelocidadeDoVoo = 65;
           pato.AltitudeMaximaEmMetros = 80;

            Pinguim pinguim = new Pinguim();
            pinguim.Nome = "Happy Feet";
            pinguim.Nascimento = DateTime.Parse("20/10/1982");
            pinguim.CorPena = "Preto";
            pinguim.Sexo = 'M';

            Pombo pombo = new Pombo();
            pombo.Nome = "Pombo";
            pombo.Nascimento = DateTime.Parse("22/09/1975");
            pombo.CorPena = "Cinza";
            pombo.Sexo = 'F';
            pombo.VelocidadeDoVoo = 35;
            pombo.AltitudeMaximaEmMetros = 100;

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
            arvoreBin.Insere(lobo);
            arvoreBin.Insere(morcego);
            arvoreBin.Insere(ornitorrinco);
            arvoreBin.Insere(pato);
            arvoreBin.Insere(pinguim);
            arvoreBin.Insere(pombo);
            arvoreBin.Insere(tartaruga);

            animais = UtilExtensions.arvore.ListagemEmOrdem();
            animaisAux = animais.Listar();

            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                listaAux.InserirNoFim(animal);
                lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade() + " anos");
            }
            animaisAux = listaAux.Listar();

        }

        public List animais;
        public Animal[] animaisAux;
        public List listaAux = new List();


        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                listaAux.InserirNoFim(animal);
                lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade() + " anos");
            }
            animaisAux = listaAux.Listar();
        }

        private void rbMamiferos_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is Mamifero)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade() + " anos");
                }
            }
            animaisAux = listaAux.Listar();
        }

        private void rbOviparos_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IOviparo)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade() + " anos");
                }
            }

            animaisAux = listaAux.Listar();
        }

        private void rbAquaticos_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IAquatico)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade() + " anos");
                }
            }

            animaisAux = listaAux.Listar();
        }

        private void rbVoar_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IVoar)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade() + " anos");
                }
            }
            animaisAux = listaAux.Listar();
        }

        private void rbIdade_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            //Implementar listagem por idade
        }

        private void rbPredadores_CheckedChanged(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = "";
            btnDetalhes.Visible = false;

            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IPredador)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Idade());
                }
            }

            animaisAux = listaAux.Listar();
        }

        Animal animalAtual;
        private void lbAnimais_SelectedValueChanged(object sender, EventArgs e)
        {
            btnDetalhes.Visible = true;

            //bool voador = false;
            //bool predador = false;
            //bool oviparo = false;
            //bool ave = false;
            //bool mamifero = false;

            animalAtual = animaisAux[lbAnimais.SelectedIndex];
            UtilExtensions.animalAtual = animalAtual;

            //if (animalAtual is IVoar)
            //    voador = true;
            //if (animalAtual is IPredador)
            //    predador = true;
            //if (animalAtual is IOviparo)
            //    oviparo = true;
            //if (animalAtual is Ave)
            //    ave = true;
            //if (animalAtual is Mamifero)
            //    mamifero = true;

            if (animalAtual is Baleia)
                SetImage(@"../../imagens-animais/baleia/baleia.jpg");
            else if (animalAtual is Cachorro)
                SetImage(@"../../imagens-animais/cachorro/cachorro.jpg");
            else if (animalAtual is Coruja)
                SetImage(@"../../imagens-animais/coruja/coruja.jpg");
            else if (animalAtual is Gato)
                SetImage(@"../../imagens-animais/gato/gato.jpg");
            else if (animalAtual is Gaviao)
                SetImage(@"../../imagens-animais/gaviao/gaviao.jpg");
            else if (animalAtual is Leao)
                SetImage(@"../../imagens-animais/leao/leao.jpg");
            else if (animalAtual is Lobo)
                SetImage(@"../../imagens-animais/lobo/lobo.jpg");
            else if (animalAtual is Morcego)
                SetImage(@"../../imagens-animais/morcego/morcego.jpg");
            else if (animalAtual is Ornitorrinco)
                SetImage(@"../../imagens-animais/ornitorrinco/ornitorrinco.jpg");
            else if (animalAtual is Pato)
                SetImage(@"../../imagens-animais/pato/pato.png");
            else if (animalAtual is Peixe)
                SetImage(@"../../imagens-animais/peixe/peixe.jpg");
            else if (animalAtual is Pinguim)
                SetImage(@"../../imagens-animais/pinguim/pinguimCaminhando.jpg");
            else if (animalAtual is Pombo)
                SetImage(@"../../imagens-animais/pombo/pombo.jpg");
            else if (animalAtual is Tartaruga)
                SetImage(@"../../imagens-animais/tartaruga/tartaruga.jpg");

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (UtilExtensions.animalAtual is Mamifero)
            {
                DetalhesMamiferos winDetalhesMamiferos = new DetalhesMamiferos();
                winDetalhesMamiferos.ShowDialog();
            }
            else if (UtilExtensions.animalAtual is Ave)
            {
                DetalhesAves winDetalhesAves = new DetalhesAves();
                winDetalhesAves.ShowDialog();
            }
            else if ((UtilExtensions.animalAtual is Reptil))
            {
                DetalhesRepteis winDetalhesRepteis = new DetalhesRepteis();
                winDetalhesRepteis.ShowDialog();
            }
        }

        private void SetImage(string caminho)
        {
            pbAnimal.ImageLocation = caminho;
            UtilExtensions.imagemAtual = caminho;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar formCadastrar = new Cadastrar(this);
            formCadastrar.ShowDialog();

            rbIdade.Checked = true;
            rbIdade.Checked = false;
            lbAnimais.Items.Clear();
        }

      
    }
}
