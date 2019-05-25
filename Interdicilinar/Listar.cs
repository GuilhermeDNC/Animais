using Interdicilinar.Animais;
using Interdicilinar.Bichos;
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
            animaisAux = animais.Listar();
        }

        private List animais = UtilExtensions.arvore.ListagemEmOrdem();
        private Animal[] animaisAux;
        private List listaAux = new List();


        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false,false, false, false, false,false);
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
            EnableButtons(false,false, false, false, false,false);
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
            EnableButtons(false,false, false, false, false,false);
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
            EnableButtons(false,false, false, false, false,false);
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
            EnableButtons(false,false, false, false, false,false);
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
            EnableButtons(false,false, false, false, false,false);
        }

        private void rbPredadores_CheckedChanged(object sender, EventArgs e)
        {
            EnableButtons(false,false, false, false, false,false);
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

            if(animalAtual is Baleia)
                pbAnimal.ImageLocation =  @"../../imagens-animais/baleia/baleia.jpg";
            else if(animalAtual is Cachorro)
               pbAnimal.ImageLocation = @"../../imagens-animais/cachorro/cachorro.jpg";
            else if(animalAtual is Coruja)
                pbAnimal.ImageLocation = @"../../imagens-animais/coruja/coruja.jpg";
            else if(animalAtual is Gato)
                pbAnimal.ImageLocation = @"../../imagens-animais/gato/gato.jpg";
            else if(animalAtual is Gaviao)
                pbAnimal.ImageLocation = @"../../imagens-animais/gaviao/gaviao.jpg";
            else if(animalAtual is Leao)
                pbAnimal.ImageLocation = @"../../imagens-animais/leao/leao.jpg";
            else if(animalAtual is Lobo)
                pbAnimal.ImageLocation = @"../../imagens-animais/lobo/lobo.jpg";
            else if (animalAtual is Morcego)
                pbAnimal.ImageLocation = @"../../imagens-animais/morcego/morcego.jpg";
            else if(animalAtual is Ornitorrinco)
                pbAnimal.ImageLocation = @"../../imagens-animais/ornitorrinco/ornitorrinco.jpg";
            else if(animalAtual is Pato)
                pbAnimal.ImageLocation = @"../../imagens-animais/pato/pato.jpg";
            else if(animalAtual is Peixe)
                pbAnimal.ImageLocation = @"../../imagens-animais/peixe/peixe.jpg";
            else if(animalAtual is Pinguin)
                pbAnimal.ImageLocation = @"../../imagens-animais/pinguim/pinguim.jpg";
            else if(animalAtual is Pombo)
                pbAnimal.ImageLocation = @"../../imagens-animais/pombo/pombo.jpg";
            else if(animalAtual is Tartaruga)
                pbAnimal.ImageLocation = @"../../imagens-animais/tartaruga/tartaruga.jpg";

            EnableButtons(true,voador, predador, oviparo,ave,mamifero);
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

        private void EnableButtons(bool comuns,bool voador, bool predador, bool oviparo, bool ave,bool mamifero)
        {
            gbComuns.Visible = comuns;
            gbVoadores.Visible = voador;
            gbPredadores.Visible = predador;
            gbOviparos.Visible = oviparo;
            btnCiscar.Visible = ave;
            btnAmamentar.Visible = mamifero;
        }

        
    }
}
