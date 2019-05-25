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
    public partial class UserControlAve : UserControl
    {
        private string corPenas;
        private bool rapina;

        public UserControlAve()
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

        public string CorPenas
        {
            get
            {
                return this.corPenas;
            }
            set
            {
                this.corPenas = value;
            }
        }

        public bool Rapina
        {
            get
            {
                return this.rapina;
            }
            set
            {
                this.rapina = value;
            }
        }

        private void txtCorPenas_TextChanged(object sender, EventArgs e)
        {
            this.corPenas = txtCorPenas.Text;
        }
    }



    


}
