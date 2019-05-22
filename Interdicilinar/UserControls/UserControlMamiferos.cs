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
    public partial class UserControlMamiferos : UserControl
    { 
        private int mamas;
        private bool pelos;
        private string corPelo;

        public UserControlMamiferos()
        {
            InitializeComponent();
            Mamas = 2;
        }


        public string Nome
        {
            get
            {
                return userControlAnimal1.TextoNome;
            }
        }

        public string Nascimento
        {
            get
            {
                return userControlAnimal1.TextoNascimento;
            }
        } 

        public char Sexo
        {
            get
            {
                return userControlAnimal1.BoolSexo;
            }
        }

        public bool Carnivoro
        {
            get
            {
                return userControlAnimal1.BoolCarnivoro;
            }
        }

        public bool Peconhento
        {
            get
            {
                return userControlAnimal1.BoolPeconhento;
            }
        }

        public int Mamas
        {
            get
            {
                return this.mamas;
            }
            set
            {
               if (value >= 2 && value <= 8)
                    this.mamas = value;
               
                   // throw new Exception("Número de mamas deve estar entre 2 e 8...");
            }
        }

        public bool Pelos
        {
            get
            {
                return this.pelos;
            }
            set
            {
                this.pelos = value;
            }
        }


        public string CorPelo
        {
            get
            {
                return this.corPelo;
            }
            set
            {
                this.corPelo = value;
            }
        }

        private void nudMamas_ValueChanged(object sender, EventArgs e)
        {
            Mamas = Convert.ToInt32(nudMamas.Value);
        }

        private void txtCorPelo_TextChanged(object sender, EventArgs e)
        {
            CorPelo = txtCorPelo.Text;
        }

        private void rbSimPelos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSimPelos.Checked)
            {
                Pelos = true;
                txtCorPelo.Enabled = true;
            }
            else
            {
                Pelos = false;
                txtCorPelo.Text = "";
                txtCorPelo.Enabled = false;
            }
                
        }

    }
}
