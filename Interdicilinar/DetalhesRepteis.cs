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

        }

        private Animal animalAtual = UtilExtensions.animalAtual;
    }
}
