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
    public partial class UserControlAnimal : UserControl
    {
        private string nome;
        private string nascimento;
        private char sexo;
        private bool carnivoro;
        private bool peconhento;

        public UserControlAnimal()
        {
            InitializeComponent();

            sexo = 'F';
            carnivoro = true;
            peconhento = false;
        }


        public string TextoNome
        {
            get
            {
                return txtNome.Text;
            }
            set
            {

                nome = value;
            }
        }

        public string TextoNascimento
        {
            get
            {
                return nascimento;
            }
            set
            {

                this.nascimento = value;
            }
        }

        public char BoolSexo
        {
            get
            {
                return sexo;
            }
            set
            {
                this.sexo = value;
            }
        }
        public bool BoolCarnivoro
        {
            get
            {
                return this.carnivoro;
            }
            set
            {
                this.carnivoro = value;
            }
        }

        public bool BoolPeconhento
        {
            get
            {
                return this.peconhento;
            }
            set
            {
                this.peconhento = value;
            }
        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            TextoNome = txtNome.Text;
        }

        private void mtbNascimento_TextChanged(object sender, EventArgs e)
        {
            TextoNascimento = mtbNascimento.Text;
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked)
                BoolSexo = 'M';
            else
                BoolSexo = 'F';
            //VerificaChecado(rbMasculino, BoolSexo, 'M');
        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFeminino.Checked)
                BoolSexo = 'F';
            else
                BoolSexo = 'M';

            //VerificaChecado(rbFeminino, BoolSexo, 'F');
        }

        private void rbCarnivoroSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCarnivoroSim.Checked)
                BoolCarnivoro = true;
            else
                BoolCarnivoro = false;
            //VerificaChecado(rbCarnivoroSim,BoolCarnivoro, true);
        }

        private void rbCarnivoroNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCarnivoroNao.Checked)
                BoolCarnivoro = false;
            else
                BoolCarnivoro = true;
            //VerificaChecado(rbCarnivoroNao,BoolCarnivoro, false);
        }

        private void rbPeconhentoSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeconhentoSim.Checked)
                BoolPeconhento = true;
            else
                BoolPeconhento = false;
            //VerificaChecado(rbPeconhentoSim, BoolPeconhento, true);
        }

        private void rbPeconhentoNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeconhentoNao.Checked)
                BoolPeconhento = false;
            else
                BoolPeconhento = true;
            // VerificaChecado(rbPeconhentoNao, BoolPeconhento, false);
        }

        public void VerificaChecado(RadioButton radio, bool propriedade, bool valor)
        {
            if (radio.Checked)
                propriedade = valor;
            else
                propriedade = !valor;
        }

        public void VerificaChecado(RadioButton radio, char propriedade, char valor)
        {
            if (radio.Checked)
                propriedade = valor;
        }
    }
}
