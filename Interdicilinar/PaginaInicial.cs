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

            animais = UtilExtensions.arvore.ListagemEmOrdem();
            animaisAux = animais.Listar();

            EnableButtons(false, false, false, false, false,false);
        }

        public List animais;
        public Animal[] animaisAux;
        public List listaAux = new List();
       
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                listaAux.InserirNoFim(animal);
                lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Nascimento);
            }
            animaisAux = listaAux.Listar();
        }

        private void rbMamiferos_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is Mamifero)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Nascimento);
                }
            }
            animaisAux = listaAux.Listar();
        }

        private void rbOviparos_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IOviparo)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Nascimento);
                }
            }

            animaisAux = listaAux.Listar();
        }

        private void rbAquaticos_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IAquatico)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Nascimento);
                }
            }

            animaisAux = listaAux.Listar();
        }

        private void rbVoar_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IVoar)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Nascimento);
                }
            }
            animaisAux = listaAux.Listar();
        }

        private void rbIdade_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
        }

        private void rbPredadores_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false, false, false, false, false, false);
            listaAux = new List();

            lbAnimais.Items.Clear();
            foreach (Animal animal in animais.Listar())
            {
                if (animal is IPredador)
                {
                    listaAux.InserirNoFim(animal);
                    lbAnimais.Items.Add(animal.Nome + " - " + animal.Sexo + " - " + animal.Nascimento);
                }
            }

            animaisAux = listaAux.Listar();
        }

        Animal animalAtual;
        private void lbAnimais_SelectedValueChanged(object sender, EventArgs e)
        {
            bool voador = false;
            bool predador = false;
            bool oviparo = false;
            bool ave = false;
            bool mamifero = false;

            animalAtual = animaisAux[lbAnimais.SelectedIndex];
            UtilExtensions.animalAtual = animalAtual;

            if (animalAtual is IVoar)
                voador = true;
            if (animalAtual is IPredador)
                predador = true;
            if (animalAtual is IOviparo)
                oviparo = true;
            if (animalAtual is Ave)
                ave = true;
            if (animalAtual is Mamifero)
                mamifero = true;

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
                SetImage(@"../../imagens-animais/pato/pato.jpg");
            else if (animalAtual is Peixe)
                SetImage(@"../../imagens-animais/peixe/peixe.jpg");
            else if (animalAtual is Pinguin)
                SetImage(@"../../imagens-animais/pinguim/pinguim.jpg");
            else if (animalAtual is Pombo)
                SetImage(@"../../imagens-animais/pombo/pombo.jpg");
            else if (animalAtual is Tartaruga)
                SetImage(@"../../imagens-animais/tartaruga/tartaruga.jpg");

            EnableButtons(true, voador, predador, oviparo, ave, mamifero);
        }

       
        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = animalAtual.Movimentar();
        }

        private void btnComunicar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = animalAtual.Comunicar();
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = animalAtual.Alimentar();
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = (animalAtual as IVoar).Voar();
        }

        private void btnBotar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = (animalAtual as IOviparo).Botar();
        }

        private void btnChocar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = (animalAtual as IOviparo).Chocar();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = (animalAtual as IPredador).Ataque();
        }

        private void btnCiscar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = (animalAtual as Ave).Ciscar();
        }

        private void btnAmamentar_Click(object sender, EventArgs e)
        {
            pbAnimal.ImageLocation = (animalAtual as Mamifero).Amamentar();
        }

        private void EnableButtons(bool comuns, bool voador, bool predador, bool oviparo, bool ave, bool mamifero)
        {
            gbComuns.Visible = comuns;
            gbVoadores.Visible = voador;
            gbPredadores.Visible = predador;
            gbOviparos.Visible = oviparo;
            btnCiscar.Visible = ave;
            btnAmamentar.Visible = mamifero;
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (UtilExtensions.animalAtual is Mamifero)
            {
                DetalhesMamiferos winDetalhesMamiferos = new DetalhesMamiferos();
                winDetalhesMamiferos.ShowDialog();
            }
            else if(UtilExtensions.animalAtual is Ave)
            {
                DetalhesAves winDetalhesAves = new DetalhesAves();
                winDetalhesAves.ShowDialog();
            }
            else if(UtilExtensions.animalAtual is Reptil)
            {
                DetalhesRepteis winDetalhesRepteis = new DetalhesRepteis();
                winDetalhesRepteis.ShowDialog();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar formCadastrar = new Cadastrar(this);
            formCadastrar.ShowDialog();
            
            rbIdade.Checked = true;
            rbIdade.Checked = false;
            lbAnimais.Items.Clear();

        }

        private void SetImage(string caminho)
        {
            pbAnimal.ImageLocation = caminho;
            UtilExtensions.imagemAtual = caminho;
        }
    }
}
