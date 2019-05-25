namespace Interdicilinar
{
    partial class Listar
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
            this.lbAnimais = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPredadores = new System.Windows.Forms.RadioButton();
            this.rbIdade = new System.Windows.Forms.RadioButton();
            this.rbVoar = new System.Windows.Forms.RadioButton();
            this.rbAquaticos = new System.Windows.Forms.RadioButton();
            this.rbOviparos = new System.Windows.Forms.RadioButton();
            this.rbMamiferos = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnComunicar = new System.Windows.Forms.Button();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.gbComuns = new System.Windows.Forms.GroupBox();
            this.gbVoadores = new System.Windows.Forms.GroupBox();
            this.btnVoar = new System.Windows.Forms.Button();
            this.gbPredadores = new System.Windows.Forms.GroupBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.gbOviparos = new System.Windows.Forms.GroupBox();
            this.btnChocar = new System.Windows.Forms.Button();
            this.btnBotar = new System.Windows.Forms.Button();
            this.btnCiscar = new System.Windows.Forms.Button();
            this.btnAmamentar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.gbComuns.SuspendLayout();
            this.gbVoadores.SuspendLayout();
            this.gbPredadores.SuspendLayout();
            this.gbOviparos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAnimais
            // 
            this.lbAnimais.FormattingEnabled = true;
            this.lbAnimais.Location = new System.Drawing.Point(319, 15);
            this.lbAnimais.Name = "lbAnimais";
            this.lbAnimais.Size = new System.Drawing.Size(214, 173);
            this.lbAnimais.TabIndex = 0;
            this.lbAnimais.SelectedValueChanged += new System.EventHandler(this.lbAnimais_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPredadores);
            this.groupBox1.Controls.Add(this.rbIdade);
            this.groupBox1.Controls.Add(this.rbVoar);
            this.groupBox1.Controls.Add(this.rbAquaticos);
            this.groupBox1.Controls.Add(this.rbOviparos);
            this.groupBox1.Controls.Add(this.rbMamiferos);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Por";
            // 
            // rbPredadores
            // 
            this.rbPredadores.AutoSize = true;
            this.rbPredadores.Location = new System.Drawing.Point(121, 44);
            this.rbPredadores.Name = "rbPredadores";
            this.rbPredadores.Size = new System.Drawing.Size(79, 17);
            this.rbPredadores.TabIndex = 7;
            this.rbPredadores.TabStop = true;
            this.rbPredadores.Text = "Predadores";
            this.rbPredadores.UseVisualStyleBackColor = true;
            this.rbPredadores.CheckedChanged += new System.EventHandler(this.rbPredadores_CheckedChanged);
            // 
            // rbIdade
            // 
            this.rbIdade.AutoSize = true;
            this.rbIdade.Location = new System.Drawing.Point(121, 19);
            this.rbIdade.Name = "rbIdade";
            this.rbIdade.Size = new System.Drawing.Size(52, 17);
            this.rbIdade.TabIndex = 6;
            this.rbIdade.TabStop = true;
            this.rbIdade.Text = "Idade";
            this.rbIdade.UseVisualStyleBackColor = true;
            this.rbIdade.CheckedChanged += new System.EventHandler(this.rbIdade_CheckedChanged);
            // 
            // rbVoar
            // 
            this.rbVoar.AutoSize = true;
            this.rbVoar.Location = new System.Drawing.Point(7, 116);
            this.rbVoar.Name = "rbVoar";
            this.rbVoar.Size = new System.Drawing.Size(47, 17);
            this.rbVoar.TabIndex = 4;
            this.rbVoar.TabStop = true;
            this.rbVoar.Text = "Voar";
            this.rbVoar.UseVisualStyleBackColor = true;
            this.rbVoar.CheckedChanged += new System.EventHandler(this.rbVoar_CheckedChanged);
            // 
            // rbAquaticos
            // 
            this.rbAquaticos.AutoSize = true;
            this.rbAquaticos.Location = new System.Drawing.Point(7, 92);
            this.rbAquaticos.Name = "rbAquaticos";
            this.rbAquaticos.Size = new System.Drawing.Size(72, 17);
            this.rbAquaticos.TabIndex = 3;
            this.rbAquaticos.TabStop = true;
            this.rbAquaticos.Text = "Aquáticos";
            this.rbAquaticos.UseVisualStyleBackColor = true;
            this.rbAquaticos.CheckedChanged += new System.EventHandler(this.rbAquaticos_CheckedChanged);
            // 
            // rbOviparos
            // 
            this.rbOviparos.AutoSize = true;
            this.rbOviparos.Location = new System.Drawing.Point(7, 68);
            this.rbOviparos.Name = "rbOviparos";
            this.rbOviparos.Size = new System.Drawing.Size(69, 17);
            this.rbOviparos.TabIndex = 2;
            this.rbOviparos.TabStop = true;
            this.rbOviparos.Text = "Ovíparos";
            this.rbOviparos.UseVisualStyleBackColor = true;
            this.rbOviparos.CheckedChanged += new System.EventHandler(this.rbOviparos_CheckedChanged);
            // 
            // rbMamiferos
            // 
            this.rbMamiferos.AutoSize = true;
            this.rbMamiferos.Location = new System.Drawing.Point(7, 44);
            this.rbMamiferos.Name = "rbMamiferos";
            this.rbMamiferos.Size = new System.Drawing.Size(75, 17);
            this.rbMamiferos.TabIndex = 1;
            this.rbMamiferos.TabStop = true;
            this.rbMamiferos.Text = "Mamíferos";
            this.rbMamiferos.UseVisualStyleBackColor = true;
            this.rbMamiferos.CheckedChanged += new System.EventHandler(this.rbMamiferos_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(7, 20);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.Location = new System.Drawing.Point(10, 33);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(75, 23);
            this.btnMovimentar.TabIndex = 2;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = true;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(172, 33);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(75, 23);
            this.btnAlimentar.TabIndex = 3;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnComunicar
            // 
            this.btnComunicar.Location = new System.Drawing.Point(91, 33);
            this.btnComunicar.Name = "btnComunicar";
            this.btnComunicar.Size = new System.Drawing.Size(75, 23);
            this.btnComunicar.TabIndex = 4;
            this.btnComunicar.Text = "Comunicar";
            this.btnComunicar.UseVisualStyleBackColor = true;
            this.btnComunicar.Click += new System.EventHandler(this.btnComunicar_Click);
            // 
            // pbAnimal
            // 
            this.pbAnimal.Location = new System.Drawing.Point(592, 12);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(196, 140);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 5;
            this.pbAnimal.TabStop = false;
            // 
            // gbComuns
            // 
            this.gbComuns.Controls.Add(this.btnComunicar);
            this.gbComuns.Controls.Add(this.btnMovimentar);
            this.gbComuns.Controls.Add(this.btnAlimentar);
            this.gbComuns.Location = new System.Drawing.Point(21, 209);
            this.gbComuns.Name = "gbComuns";
            this.gbComuns.Size = new System.Drawing.Size(260, 75);
            this.gbComuns.TabIndex = 6;
            this.gbComuns.TabStop = false;
            this.gbComuns.Text = "Comuns";
            // 
            // gbVoadores
            // 
            this.gbVoadores.Controls.Add(this.btnVoar);
            this.gbVoadores.Location = new System.Drawing.Point(21, 290);
            this.gbVoadores.Name = "gbVoadores";
            this.gbVoadores.Size = new System.Drawing.Size(260, 59);
            this.gbVoadores.TabIndex = 7;
            this.gbVoadores.TabStop = false;
            this.gbVoadores.Text = "Voadores";
            // 
            // btnVoar
            // 
            this.btnVoar.Location = new System.Drawing.Point(76, 19);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 5;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = true;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // gbPredadores
            // 
            this.gbPredadores.Controls.Add(this.btnAtacar);
            this.gbPredadores.Location = new System.Drawing.Point(305, 290);
            this.gbPredadores.Name = "gbPredadores";
            this.gbPredadores.Size = new System.Drawing.Size(200, 59);
            this.gbPredadores.TabIndex = 8;
            this.gbPredadores.TabStop = false;
            this.gbPredadores.Text = "Predadores";
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(59, 19);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar.TabIndex = 0;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // gbOviparos
            // 
            this.gbOviparos.Controls.Add(this.btnChocar);
            this.gbOviparos.Controls.Add(this.btnBotar);
            this.gbOviparos.Location = new System.Drawing.Point(305, 209);
            this.gbOviparos.Name = "gbOviparos";
            this.gbOviparos.Size = new System.Drawing.Size(200, 75);
            this.gbOviparos.TabIndex = 9;
            this.gbOviparos.TabStop = false;
            this.gbOviparos.Text = "Ovíparos";
            // 
            // btnChocar
            // 
            this.btnChocar.Location = new System.Drawing.Point(99, 33);
            this.btnChocar.Name = "btnChocar";
            this.btnChocar.Size = new System.Drawing.Size(75, 23);
            this.btnChocar.TabIndex = 2;
            this.btnChocar.Text = "Chocar";
            this.btnChocar.UseVisualStyleBackColor = true;
            this.btnChocar.Click += new System.EventHandler(this.btnChocar_Click);
            // 
            // btnBotar
            // 
            this.btnBotar.Location = new System.Drawing.Point(18, 33);
            this.btnBotar.Name = "btnBotar";
            this.btnBotar.Size = new System.Drawing.Size(75, 23);
            this.btnBotar.TabIndex = 1;
            this.btnBotar.Text = "Botar";
            this.btnBotar.UseVisualStyleBackColor = true;
            this.btnBotar.Click += new System.EventHandler(this.btnBotar_Click);
            // 
            // btnCiscar
            // 
            this.btnCiscar.Location = new System.Drawing.Point(527, 242);
            this.btnCiscar.Name = "btnCiscar";
            this.btnCiscar.Size = new System.Drawing.Size(75, 23);
            this.btnCiscar.TabIndex = 10;
            this.btnCiscar.Text = "Ciscar";
            this.btnCiscar.UseVisualStyleBackColor = true;
            this.btnCiscar.Click += new System.EventHandler(this.btnCiscar_Click);
            // 
            // btnAmamentar
            // 
            this.btnAmamentar.Location = new System.Drawing.Point(527, 309);
            this.btnAmamentar.Name = "btnAmamentar";
            this.btnAmamentar.Size = new System.Drawing.Size(75, 23);
            this.btnAmamentar.TabIndex = 11;
            this.btnAmamentar.Text = "Amamentar";
            this.btnAmamentar.UseVisualStyleBackColor = true;
            this.btnAmamentar.Click += new System.EventHandler(this.btnAmamentar_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAmamentar);
            this.Controls.Add(this.btnCiscar);
            this.Controls.Add(this.gbOviparos);
            this.Controls.Add(this.gbPredadores);
            this.Controls.Add(this.gbVoadores);
            this.Controls.Add(this.gbComuns);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAnimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Listar";
            this.Text = "Listar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.gbComuns.ResumeLayout(false);
            this.gbVoadores.ResumeLayout(false);
            this.gbPredadores.ResumeLayout(false);
            this.gbOviparos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAnimais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbMamiferos;
        private System.Windows.Forms.RadioButton rbPredadores;
        private System.Windows.Forms.RadioButton rbIdade;
        private System.Windows.Forms.RadioButton rbVoar;
        private System.Windows.Forms.RadioButton rbAquaticos;
        private System.Windows.Forms.RadioButton rbOviparos;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnComunicar;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.GroupBox gbComuns;
        private System.Windows.Forms.GroupBox gbVoadores;
        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.GroupBox gbPredadores;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.GroupBox gbOviparos;
        private System.Windows.Forms.Button btnChocar;
        private System.Windows.Forms.Button btnBotar;
        private System.Windows.Forms.Button btnCiscar;
        private System.Windows.Forms.Button btnAmamentar;
    }
}