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
    public partial class UserControlRepteis : UserControl
    {

        private bool escamas;
        private bool temCasco;

        public UserControlRepteis()
        {
            InitializeComponent();
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

        public bool Escamas
        {
            get
            {
                return this.escamas;
            }
            set
            {
                this.escamas = value;
            }
        }

        public bool TemCasco
        {
            get
            {
                return this.temCasco;
            }
            set
            {
                this.temCasco = value;
            }
        }

        private void rbSimEscamas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSimEscamas.Checked)
                Escamas = true;
            else
                Escamas = false;
        }

        private void rbNaoEscamas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNaoEscamas.Checked)
                Escamas = false;
            else
                Escamas = true;
        }

        private void rbSimCasco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSimCasco.Checked)
                TemCasco = true;
            else
                TemCasco = false;
        }

        private void rbNaoCasco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNaoCasco.Checked)
                TemCasco = false;
            else
                TemCasco = true;
        }
    }
}
