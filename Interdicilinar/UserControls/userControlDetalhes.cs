using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interdicilinar.UserControls
{
    public partial class userControlDetalhes : UserControl
    {
        public userControlDetalhes()
        {
            InitializeComponent();
        }

        public string Nome
        {
            get
            {
                return lblNome.Text;
            }
            set
            {
                lblNome.Text = value;
            }
        }

        public string Imagem
        {
            get
            {
                return pbAnimal.ImageLocation;
            }
            set
            {
                pbAnimal.ImageLocation = value;
            }
        }

        public string Idade
        {
            get
            {
                return lblIdade.Text;
            }
            set
            {
                lblIdade.Text = value;
            }
        }

        public string Peconhento
        {
            get
            {
                return lblPeconhento.Text;
            }
            set
            {
                lblPeconhento.Text = value;
            }
        }

        public string Sexo
        {
            get
            {
                return lblSexo.Text;
            }
            set
            {
                lblSexo.Text = value;
            }
        }

        public string Carnivoro
        {
            get
            {
                return lblCarnivoro.Text;
            }
            set
            {
                lblCarnivoro.Text = value;
            }
        }
    }
}
