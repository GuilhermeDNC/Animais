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

        }

        private void rbPredadores_CheckedChanged(object sender, EventArgs e)
        {

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
            animalAtual = animaisAux[lbAnimais.SelectedIndex];
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


    }
}
