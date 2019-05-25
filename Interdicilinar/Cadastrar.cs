using Interdicilinar.Animais;
using Interdicilinar.Bichos;
using Interdicilinar.UserControls;
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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
            btnCadastrarMamiferos.Enabled = false;

            //Porque só há essa opção
            rbTartaruga.Checked = true;

            rbPato.Checked = true;
            rbCachorro.Checked = true;
        }

        private void rbBaleia_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(false);
            btnCadastrarMamiferos.Enabled = true;
        }

        private void rbCachorro_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(false);
            btnCadastrarMamiferos.Enabled = true;
        }


        private void rbGato_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(false);
            btnCadastrarMamiferos.Enabled = true;
        }

        private void rbLeao_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(false);
            btnCadastrarMamiferos.Enabled = true;
        }

        private void rbLobo_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(false);
            btnCadastrarMamiferos.Enabled = true;
        }

        private void rbMorcego_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(true);
            btnCadastrarMamiferos.Enabled = true;
        }

        private void rbOrnitorrinco_CheckedChanged(object sender, EventArgs e)
        {
            EnablesMamiferos(false);
            btnCadastrarMamiferos.Enabled = true;
        }

        private void EnablesMamiferos(bool voador)
        {
            txtVelocidade.Visible = voador;
            lblVelocidadeMamiferos.Visible = voador;
            txtAltitude.Visible = voador;
            lblAltitudeMamiferos.Visible = voador;
        }

        private void EnablesAves(bool voador, bool aquatico)
        {
            txtVelocidadeAve.Visible = voador;
            lblVelocidadeAves.Visible = voador;
            txtAltitudeAve.Visible = voador;
            lblAltitudeAves.Visible = voador;
        }

        private void rbCoruja_CheckedChanged(object sender, EventArgs e)
        {
            EnablesAves(true, false);
        }

        private void rbGaviao_CheckedChanged(object sender, EventArgs e)
        {
            EnablesAves(true, false);
        }

        private void rbPato_CheckedChanged(object sender, EventArgs e)
        {
            EnablesAves(true, true);
        }

        private void rbPinguim_CheckedChanged(object sender, EventArgs e)
        {
            EnablesAves(false, true);
        }

        private void rbPombo_CheckedChanged(object sender, EventArgs e)
        {
            EnablesAves(true, false);
        }

        private void rbTartaruga_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarMamiferos_Click(object sender, EventArgs e)
        {

            Mamifero animal;
            try
            {

                if (rbBaleia.Checked)
                {
                    animal = new Baleia();
                }
                else if (rbCachorro.Checked)
                {
                    animal = new Cachorro();
                }
                else if (rbGato.Checked)
                {
                    animal = new Gato();
                }
                else if (rbLeao.Checked)
                {
                    animal = new Leao();
                }
                else if (rbLobo.Checked)
                {
                    animal = new Lobo();
                }
                else if (rbMorcego.Checked)
                {
                    animal = new Morcego();
                    (animal as Morcego).AltitudeMaximaEmMetros = int.Parse(txtAltitude.Text);
                    (animal as Morcego).VelocidadeDoVoo = double.Parse(txtVelocidade.Text);
                }
                else if (rbOrnitorrinco.Checked)
                {
                    animal = new Ornitorrinco();
                }
                else
                {
                    throw new Exception("Nenhuma opção foi selecionada...");
                }

                CadastrarDadosMamifero(animal);
                UtilExtensions.arvore.Insere(animal);
                MessageBox.Show("Cadastrado com sucesso...");
                LimparForm(this);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCadastrarAves_Click(object sender, EventArgs e)
        {
            Ave animal;
            try
            {
                if (rbCoruja.Checked)
                {
                    animal = new Coruja();
                    (animal as Coruja).VelocidadeDoVoo = double.Parse(txtVelocidadeAve.Text);
                    (animal as Coruja).AltitudeMaximaEmMetros = int.Parse(txtAltitudeAve.Text);
                }
                else if (rbGaviao.Checked)
                {
                    animal = new Gaviao();
                    (animal as Gaviao).AltitudeMaximaEmMetros = int.Parse(txtAltitudeAve.Text);
                    (animal as Gaviao).VelocidadeDoVoo = double.Parse(txtVelocidadeAve.Text);
                }
                else if (rbPato.Checked)
                {
                    animal = new Pato();

                    (animal as Pato).AltitudeMaximaEmMetros = int.Parse(txtAltitudeAve.Text);
                    (animal as Pato).VelocidadeDoVoo = double.Parse(txtVelocidadeAve.Text);
                }
                else if (rbPinguim.Checked)
                {
                    animal = new Pinguin();
                }
                else if (rbPombo.Checked)
                {
                    animal = new Pombo();
                    try
                    {
                        (animal as Pombo).AltitudeMaximaEmMetros = int.Parse(txtAltitudeAve.Text);
                        (animal as Pombo).VelocidadeDoVoo = double.Parse(txtVelocidadeAve.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Insira valores válidos...");
                    }
                }
                else
                {
                    throw new Exception("Nenhuma opção foi marcada...");
                }

                CadastrarDadosAve(animal);
                UtilExtensions.arvore.Insere(animal);

                MessageBox.Show("Cadastrado com sucesso...");
                LimparForm(this);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCadastrarRepteis_Click(object sender, EventArgs e)
        {
            Reptil animal;
            try
            {
                if (rbTartaruga.Checked)
                {
                    animal = new Tartaruga();
                }
                else
                {
                    throw new Exception("Selecione uma opção de animal para cadastrar...");
                }

                CadastrarDadosRepteis(animal);
                UtilExtensions.arvore.Insere(animal);

                MessageBox.Show("Cadastrado com sucesso...");

                LimparForm(this);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void CadastrarDadosMamifero(Mamifero animal)
        {
            DateTime nascimento;
            if (userControlMamiferos1.Mamas < 2 || userControlMamiferos1.Mamas > 8)
                throw new Exception("O número de mamas deve ser maior que 2 e menor que 8...");
            else
                animal.QuantidadeMamas = userControlMamiferos1.Mamas;

            animal.Pelos = userControlMamiferos1.Pelos;
            animal.CorDoPelo = userControlMamiferos1.CorPelo;

            animal.Carnivoro = userControlMamiferos1.Carnivoro;

            if (DateTime.TryParse(userControlMamiferos1.Nascimento, out nascimento))
                animal.Nascimento = nascimento;
            else
                throw new Exception("A data não foi inserida em um formato correto...");

            if (string.IsNullOrEmpty(userControlMamiferos1.Nome))
                throw new Exception("O campo nome não pode ser nulo...");
            else
                animal.Nome = userControlMamiferos1.Nome;

            animal.Peconhento = userControlMamiferos1.Peconhento;
            animal.Sexo = userControlMamiferos1.Sexo;
        }


        private void CadastrarDadosAve(Ave animal)
        {
            DateTime nascimento;
            if (string.IsNullOrEmpty(userControlAve1.CorPenas))
                throw new Exception("O campo cor das penas não pode ser nulo...");
            else
                animal.CorPena = userControlAve1.CorPenas;

            animal.Rapina = userControlAve1.Rapina;
            animal.Carnivoro = userControlAve1.Carnivoro;

            if (DateTime.TryParse(userControlAve1.Nascimento, out nascimento))
                animal.Nascimento = nascimento;
            else
                throw new Exception("Insira o campo data em um valor válido...");

            if (string.IsNullOrEmpty(userControlAve1.Nome))
                throw new Exception("O campo nome não pode estar vazio...");
            else
                animal.Nome = userControlAve1.Nome;

            animal.Peconhento = userControlAve1.Peconhento;
            animal.Sexo = userControlAve1.Sexo;
        }

        private void CadastrarDadosRepteis(Reptil animal)
        {
            DateTime nascimento;
            if (!string.IsNullOrEmpty(userControlReptil.TextoNome))
            {
                animal.Nome = userControlReptil.TextoNome;
            }
            else
            {
                throw new Exception("O valor do campo nome não pode ser nulo...");
            }


            if (DateTime.TryParse(userControlReptil.TextoNascimento, out nascimento))
                animal.Nascimento = nascimento;
            else
                throw new Exception("Insira uma data válida...");

            animal.Sexo = userControlReptil.BoolSexo;
        }

        private void LimparForm(Control formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is TextBox || controle is MaskedTextBox)
                {
                    controle.Text = "";
                }
                else
                    LimparForm(controle);
            }
            userControlMamiferos1.Mamas = 2;
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LimparForm(this);
        }
    }

}
