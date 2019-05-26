namespace Interdicilinar
{
    partial class Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCadastrarMamiferos = new System.Windows.Forms.Button();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.lblVelocidadeMamiferos = new System.Windows.Forms.Label();
            this.lblAltitudeMamiferos = new System.Windows.Forms.Label();
            this.userControlMamiferos1 = new Interdicilinar.UserControls.UserControlMamiferos();
            this.rbOrnitorrinco = new System.Windows.Forms.RadioButton();
            this.rbMorcego = new System.Windows.Forms.RadioButton();
            this.rbLobo = new System.Windows.Forms.RadioButton();
            this.rbLeao = new System.Windows.Forms.RadioButton();
            this.rbGato = new System.Windows.Forms.RadioButton();
            this.rbCachorro = new System.Windows.Forms.RadioButton();
            this.rbBaleia = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCadastrarAves = new System.Windows.Forms.Button();
            this.txtVelocidadeAve = new System.Windows.Forms.TextBox();
            this.txtAltitudeAve = new System.Windows.Forms.TextBox();
            this.lblVelocidadeAves = new System.Windows.Forms.Label();
            this.lblAltitudeAves = new System.Windows.Forms.Label();
            this.rbPombo = new System.Windows.Forms.RadioButton();
            this.rbPinguim = new System.Windows.Forms.RadioButton();
            this.rbPato = new System.Windows.Forms.RadioButton();
            this.rbGaviao = new System.Windows.Forms.RadioButton();
            this.rbCoruja = new System.Windows.Forms.RadioButton();
            this.userControlAve1 = new Interdicilinar.UserControls.UserControlAve();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCadastrarRepteis = new System.Windows.Forms.Button();
            this.rbTartaruga = new System.Windows.Forms.RadioButton();
            this.userControlReptil = new Interdicilinar.UserControls.UserControlAnimal();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 482);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCadastrarMamiferos);
            this.tabPage1.Controls.Add(this.txtVelocidade);
            this.tabPage1.Controls.Add(this.txtAltitude);
            this.tabPage1.Controls.Add(this.lblVelocidadeMamiferos);
            this.tabPage1.Controls.Add(this.lblAltitudeMamiferos);
            this.tabPage1.Controls.Add(this.userControlMamiferos1);
            this.tabPage1.Controls.Add(this.rbOrnitorrinco);
            this.tabPage1.Controls.Add(this.rbMorcego);
            this.tabPage1.Controls.Add(this.rbLobo);
            this.tabPage1.Controls.Add(this.rbLeao);
            this.tabPage1.Controls.Add(this.rbGato);
            this.tabPage1.Controls.Add(this.rbCachorro);
            this.tabPage1.Controls.Add(this.rbBaleia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MAMÍFEROS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarMamiferos
            // 
            this.btnCadastrarMamiferos.Location = new System.Drawing.Point(126, 242);
            this.btnCadastrarMamiferos.Name = "btnCadastrarMamiferos";
            this.btnCadastrarMamiferos.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarMamiferos.TabIndex = 12;
            this.btnCadastrarMamiferos.Text = "Cadastrar";
            this.btnCadastrarMamiferos.UseVisualStyleBackColor = true;
            this.btnCadastrarMamiferos.Click += new System.EventHandler(this.btnCadastrarMamiferos_Click);
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(199, 173);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 11;
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(199, 144);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(100, 20);
            this.txtAltitude.TabIndex = 10;
            // 
            // lblVelocidadeMamiferos
            // 
            this.lblVelocidadeMamiferos.AutoSize = true;
            this.lblVelocidadeMamiferos.Location = new System.Drawing.Point(123, 176);
            this.lblVelocidadeMamiferos.Name = "lblVelocidadeMamiferos";
            this.lblVelocidadeMamiferos.Size = new System.Drawing.Size(63, 13);
            this.lblVelocidadeMamiferos.TabIndex = 9;
            this.lblVelocidadeMamiferos.Text = "Velocidade:";
            // 
            // lblAltitudeMamiferos
            // 
            this.lblAltitudeMamiferos.AutoSize = true;
            this.lblAltitudeMamiferos.Location = new System.Drawing.Point(141, 144);
            this.lblAltitudeMamiferos.Name = "lblAltitudeMamiferos";
            this.lblAltitudeMamiferos.Size = new System.Drawing.Size(45, 13);
            this.lblAltitudeMamiferos.TabIndex = 8;
            this.lblAltitudeMamiferos.Text = "Altitude:";
            // 
            // userControlMamiferos1
            // 
            this.userControlMamiferos1.CorPelo = null;
            this.userControlMamiferos1.Location = new System.Drawing.Point(126, 6);
            this.userControlMamiferos1.Mamas = 2;
            this.userControlMamiferos1.Name = "userControlMamiferos1";
            this.userControlMamiferos1.Pelos = true;
            this.userControlMamiferos1.Size = new System.Drawing.Size(415, 259);
            this.userControlMamiferos1.TabIndex = 7;
            // 
            // rbOrnitorrinco
            // 
            this.rbOrnitorrinco.AutoSize = true;
            this.rbOrnitorrinco.Location = new System.Drawing.Point(20, 174);
            this.rbOrnitorrinco.Name = "rbOrnitorrinco";
            this.rbOrnitorrinco.Size = new System.Drawing.Size(79, 17);
            this.rbOrnitorrinco.TabIndex = 6;
            this.rbOrnitorrinco.TabStop = true;
            this.rbOrnitorrinco.Text = "Ornitorrinco";
            this.rbOrnitorrinco.UseVisualStyleBackColor = true;
            this.rbOrnitorrinco.CheckedChanged += new System.EventHandler(this.rbOrnitorrinco_CheckedChanged);
            // 
            // rbMorcego
            // 
            this.rbMorcego.AutoSize = true;
            this.rbMorcego.Location = new System.Drawing.Point(20, 151);
            this.rbMorcego.Name = "rbMorcego";
            this.rbMorcego.Size = new System.Drawing.Size(67, 17);
            this.rbMorcego.TabIndex = 5;
            this.rbMorcego.TabStop = true;
            this.rbMorcego.Text = "Morcego";
            this.rbMorcego.UseVisualStyleBackColor = true;
            this.rbMorcego.CheckedChanged += new System.EventHandler(this.rbMorcego_CheckedChanged);
            // 
            // rbLobo
            // 
            this.rbLobo.AutoSize = true;
            this.rbLobo.Location = new System.Drawing.Point(20, 128);
            this.rbLobo.Name = "rbLobo";
            this.rbLobo.Size = new System.Drawing.Size(49, 17);
            this.rbLobo.TabIndex = 4;
            this.rbLobo.TabStop = true;
            this.rbLobo.Text = "Lobo";
            this.rbLobo.UseVisualStyleBackColor = true;
            this.rbLobo.CheckedChanged += new System.EventHandler(this.rbLobo_CheckedChanged);
            // 
            // rbLeao
            // 
            this.rbLeao.AutoSize = true;
            this.rbLeao.Location = new System.Drawing.Point(20, 105);
            this.rbLeao.Name = "rbLeao";
            this.rbLeao.Size = new System.Drawing.Size(49, 17);
            this.rbLeao.TabIndex = 3;
            this.rbLeao.TabStop = true;
            this.rbLeao.Text = "Leão";
            this.rbLeao.UseVisualStyleBackColor = true;
            this.rbLeao.CheckedChanged += new System.EventHandler(this.rbLeao_CheckedChanged);
            // 
            // rbGato
            // 
            this.rbGato.AutoSize = true;
            this.rbGato.Location = new System.Drawing.Point(20, 82);
            this.rbGato.Name = "rbGato";
            this.rbGato.Size = new System.Drawing.Size(48, 17);
            this.rbGato.TabIndex = 2;
            this.rbGato.TabStop = true;
            this.rbGato.Text = "Gato";
            this.rbGato.UseVisualStyleBackColor = true;
            this.rbGato.CheckedChanged += new System.EventHandler(this.rbGato_CheckedChanged);
            // 
            // rbCachorro
            // 
            this.rbCachorro.AutoSize = true;
            this.rbCachorro.Location = new System.Drawing.Point(20, 59);
            this.rbCachorro.Name = "rbCachorro";
            this.rbCachorro.Size = new System.Drawing.Size(68, 17);
            this.rbCachorro.TabIndex = 1;
            this.rbCachorro.TabStop = true;
            this.rbCachorro.Text = "Cachorro";
            this.rbCachorro.UseVisualStyleBackColor = true;
            this.rbCachorro.CheckedChanged += new System.EventHandler(this.rbCachorro_CheckedChanged);
            // 
            // rbBaleia
            // 
            this.rbBaleia.AutoSize = true;
            this.rbBaleia.Location = new System.Drawing.Point(20, 36);
            this.rbBaleia.Name = "rbBaleia";
            this.rbBaleia.Size = new System.Drawing.Size(54, 17);
            this.rbBaleia.TabIndex = 0;
            this.rbBaleia.TabStop = true;
            this.rbBaleia.Text = "Baleia";
            this.rbBaleia.UseVisualStyleBackColor = true;
            this.rbBaleia.CheckedChanged += new System.EventHandler(this.rbBaleia_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCadastrarAves);
            this.tabPage2.Controls.Add(this.txtVelocidadeAve);
            this.tabPage2.Controls.Add(this.txtAltitudeAve);
            this.tabPage2.Controls.Add(this.lblVelocidadeAves);
            this.tabPage2.Controls.Add(this.lblAltitudeAves);
            this.tabPage2.Controls.Add(this.rbPombo);
            this.tabPage2.Controls.Add(this.rbPinguim);
            this.tabPage2.Controls.Add(this.rbPato);
            this.tabPage2.Controls.Add(this.rbGaviao);
            this.tabPage2.Controls.Add(this.rbCoruja);
            this.tabPage2.Controls.Add(this.userControlAve1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(708, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AVES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarAves
            // 
            this.btnCadastrarAves.Location = new System.Drawing.Point(140, 215);
            this.btnCadastrarAves.Name = "btnCadastrarAves";
            this.btnCadastrarAves.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAves.TabIndex = 18;
            this.btnCadastrarAves.Text = "Cadastrar";
            this.btnCadastrarAves.UseVisualStyleBackColor = true;
            this.btnCadastrarAves.Click += new System.EventHandler(this.btnCadastrarAves_Click);
            // 
            // txtVelocidadeAve
            // 
            this.txtVelocidadeAve.Location = new System.Drawing.Point(239, 146);
            this.txtVelocidadeAve.Name = "txtVelocidadeAve";
            this.txtVelocidadeAve.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidadeAve.TabIndex = 17;
            // 
            // txtAltitudeAve
            // 
            this.txtAltitudeAve.Location = new System.Drawing.Point(239, 117);
            this.txtAltitudeAve.Name = "txtAltitudeAve";
            this.txtAltitudeAve.Size = new System.Drawing.Size(100, 20);
            this.txtAltitudeAve.TabIndex = 16;
            // 
            // lblVelocidadeAves
            // 
            this.lblVelocidadeAves.AutoSize = true;
            this.lblVelocidadeAves.Location = new System.Drawing.Point(163, 149);
            this.lblVelocidadeAves.Name = "lblVelocidadeAves";
            this.lblVelocidadeAves.Size = new System.Drawing.Size(63, 13);
            this.lblVelocidadeAves.TabIndex = 15;
            this.lblVelocidadeAves.Text = "Velocidade:";
            // 
            // lblAltitudeAves
            // 
            this.lblAltitudeAves.AutoSize = true;
            this.lblAltitudeAves.Location = new System.Drawing.Point(181, 117);
            this.lblAltitudeAves.Name = "lblAltitudeAves";
            this.lblAltitudeAves.Size = new System.Drawing.Size(45, 13);
            this.lblAltitudeAves.TabIndex = 14;
            this.lblAltitudeAves.Text = "Altitude:";
            // 
            // rbPombo
            // 
            this.rbPombo.AutoSize = true;
            this.rbPombo.Location = new System.Drawing.Point(27, 140);
            this.rbPombo.Name = "rbPombo";
            this.rbPombo.Size = new System.Drawing.Size(58, 17);
            this.rbPombo.TabIndex = 4;
            this.rbPombo.Text = "Pombo";
            this.rbPombo.UseVisualStyleBackColor = true;
            this.rbPombo.CheckedChanged += new System.EventHandler(this.rbPombo_CheckedChanged);
            // 
            // rbPinguim
            // 
            this.rbPinguim.AutoSize = true;
            this.rbPinguim.Location = new System.Drawing.Point(27, 117);
            this.rbPinguim.Name = "rbPinguim";
            this.rbPinguim.Size = new System.Drawing.Size(62, 17);
            this.rbPinguim.TabIndex = 3;
            this.rbPinguim.Text = "Pinguim";
            this.rbPinguim.UseVisualStyleBackColor = true;
            this.rbPinguim.CheckedChanged += new System.EventHandler(this.rbPinguim_CheckedChanged);
            // 
            // rbPato
            // 
            this.rbPato.AutoSize = true;
            this.rbPato.Location = new System.Drawing.Point(27, 94);
            this.rbPato.Name = "rbPato";
            this.rbPato.Size = new System.Drawing.Size(47, 17);
            this.rbPato.TabIndex = 2;
            this.rbPato.Text = "Pato";
            this.rbPato.UseVisualStyleBackColor = true;
            this.rbPato.CheckedChanged += new System.EventHandler(this.rbPato_CheckedChanged);
            // 
            // rbGaviao
            // 
            this.rbGaviao.AutoSize = true;
            this.rbGaviao.Location = new System.Drawing.Point(27, 71);
            this.rbGaviao.Name = "rbGaviao";
            this.rbGaviao.Size = new System.Drawing.Size(59, 17);
            this.rbGaviao.TabIndex = 1;
            this.rbGaviao.Text = "Gavião";
            this.rbGaviao.UseVisualStyleBackColor = true;
            this.rbGaviao.CheckedChanged += new System.EventHandler(this.rbGaviao_CheckedChanged);
            // 
            // rbCoruja
            // 
            this.rbCoruja.AutoSize = true;
            this.rbCoruja.Checked = true;
            this.rbCoruja.Location = new System.Drawing.Point(27, 48);
            this.rbCoruja.Name = "rbCoruja";
            this.rbCoruja.Size = new System.Drawing.Size(55, 17);
            this.rbCoruja.TabIndex = 0;
            this.rbCoruja.TabStop = true;
            this.rbCoruja.Text = "Coruja";
            this.rbCoruja.UseVisualStyleBackColor = true;
            this.rbCoruja.CheckedChanged += new System.EventHandler(this.rbCoruja_CheckedChanged);
            // 
            // userControlAve1
            // 
            this.userControlAve1.CorPenas = null;
            this.userControlAve1.Location = new System.Drawing.Point(167, 16);
            this.userControlAve1.Name = "userControlAve1";
            this.userControlAve1.Rapina = false;
            this.userControlAve1.Size = new System.Drawing.Size(403, 299);
            this.userControlAve1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCadastrarRepteis);
            this.tabPage3.Controls.Add(this.rbTartaruga);
            this.tabPage3.Controls.Add(this.userControlReptil);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(708, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RÉPTEIS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarRepteis
            // 
            this.btnCadastrarRepteis.Location = new System.Drawing.Point(197, 128);
            this.btnCadastrarRepteis.Name = "btnCadastrarRepteis";
            this.btnCadastrarRepteis.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarRepteis.TabIndex = 17;
            this.btnCadastrarRepteis.Text = "Cadastrar";
            this.btnCadastrarRepteis.UseVisualStyleBackColor = true;
            this.btnCadastrarRepteis.Click += new System.EventHandler(this.btnCadastrarRepteis_Click);
            // 
            // rbTartaruga
            // 
            this.rbTartaruga.AutoSize = true;
            this.rbTartaruga.Checked = true;
            this.rbTartaruga.Location = new System.Drawing.Point(17, 45);
            this.rbTartaruga.Name = "rbTartaruga";
            this.rbTartaruga.Size = new System.Drawing.Size(71, 17);
            this.rbTartaruga.TabIndex = 0;
            this.rbTartaruga.TabStop = true;
            this.rbTartaruga.Text = "Tartaruga";
            this.rbTartaruga.UseVisualStyleBackColor = true;
            this.rbTartaruga.CheckedChanged += new System.EventHandler(this.rbTartaruga_CheckedChanged);
            // 
            // userControlReptil
            // 
            this.userControlReptil.BoolCarnivoro = true;
            this.userControlReptil.BoolPeconhento = false;
            this.userControlReptil.BoolSexo = 'M';
            this.userControlReptil.Location = new System.Drawing.Point(140, 20);
            this.userControlReptil.Name = "userControlReptil";
            this.userControlReptil.Size = new System.Drawing.Size(407, 339);
            this.userControlReptil.TabIndex = 18;
            this.userControlReptil.TextoNascimento = null;
            this.userControlReptil.TextoNome = "";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 482);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastrar_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbOrnitorrinco;
        private System.Windows.Forms.RadioButton rbMorcego;
        private System.Windows.Forms.RadioButton rbLobo;
        private System.Windows.Forms.RadioButton rbLeao;
        private System.Windows.Forms.RadioButton rbGato;
        private System.Windows.Forms.RadioButton rbCachorro;
        private System.Windows.Forms.RadioButton rbBaleia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbPombo;
        private System.Windows.Forms.RadioButton rbPinguim;
        private System.Windows.Forms.RadioButton rbPato;
        private System.Windows.Forms.RadioButton rbGaviao;
        private System.Windows.Forms.RadioButton rbCoruja;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbTartaruga;
        private UserControls.UserControlAve userControlAve1;
        private UserControls.UserControlMamiferos userControlMamiferos1;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.Label lblVelocidadeMamiferos;
        private System.Windows.Forms.Label lblAltitudeMamiferos;
        private System.Windows.Forms.TextBox txtVelocidadeAve;
        private System.Windows.Forms.TextBox txtAltitudeAve;
        private System.Windows.Forms.Label lblVelocidadeAves;
        private System.Windows.Forms.Label lblAltitudeAves;
        private System.Windows.Forms.Button btnCadastrarMamiferos;
        private System.Windows.Forms.Button btnCadastrarAves;
        private System.Windows.Forms.Button btnCadastrarRepteis;
        private UserControls.UserControlAnimal userControlReptil;
    }
}