using Interdicilinar.Animais;
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
    public partial class DetalhesRepteis : Form
    {
        public DetalhesRepteis()
        {
            InitializeComponent();

            userControlDetalhes1.Imagem = UtilExtensions.imagemAtual;
            userControlDetalhes1.Nome = animalAtual.Nome;
            userControlDetalhes1.Idade = animalAtual.Idade().ToString();
            userControlDetalhes1.Peconhento = animalAtual.Peconhento ? "Sim" : "Não";
            userControlDetalhes1.Sexo = animalAtual.Sexo.ToString();
            userControlDetalhes1.Carnivoro = animalAtual.Carnivoro ? "Sim" : "Não";

            lblTemEscamasValor.Text = (animalAtual as Reptil).TemEscamas ? "Sim" : "Não";
            lblTemCascoValor.Text = (animalAtual as Reptil).TemCasco ? "Sim" : "Não";

            if (!(UtilExtensions.animalAtual is IVoar))
                btnVoar.Visible = false;
            if (!(UtilExtensions.animalAtual is IOviparo))
                gbOviparos.Visible = false;
            if (!(UtilExtensions.animalAtual is IPredador))
                btnAtacar.Visible = false;
        }

        private Animal animalAtual = UtilExtensions.animalAtual;

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = animalAtual.Movimentar();
        }

        private void btnComunicar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = animalAtual.Comunicar();
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = animalAtual.Alimentar();
        }

        private void btnBotar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = (animalAtual as IOviparo).Botar();
        }

        private void btnChocar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = (animalAtual as IOviparo).Chocar();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = (animalAtual as IPredador).Ataque();
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            userControlDetalhes1.Imagem = (animalAtual as IVoar).Voar();
        }
    }
}
