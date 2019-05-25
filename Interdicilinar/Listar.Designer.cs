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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnimais
            // 
            this.lbAnimais.FormattingEnabled = true;
            this.lbAnimais.Location = new System.Drawing.Point(319, 15);
            this.lbAnimais.Name = "lbAnimais";
            this.lbAnimais.Size = new System.Drawing.Size(362, 173);
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
            this.btnMovimentar.Location = new System.Drawing.Point(28, 209);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(75, 23);
            this.btnMovimentar.TabIndex = 2;
            this.btnMovimentar.Text = "Movimentar";
            this.btnMovimentar.UseVisualStyleBackColor = true;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(190, 209);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(75, 23);
            this.btnAlimentar.TabIndex = 3;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnComunicar
            // 
            this.btnComunicar.Location = new System.Drawing.Point(109, 209);
            this.btnComunicar.Name = "btnComunicar";
            this.btnComunicar.Size = new System.Drawing.Size(75, 23);
            this.btnComunicar.TabIndex = 4;
            this.btnComunicar.Text = "Comunicar";
            this.btnComunicar.UseVisualStyleBackColor = true;
            this.btnComunicar.Click += new System.EventHandler(this.btnComunicar_Click);
            // 
            // pbAnimal
            // 
            this.pbAnimal.Location = new System.Drawing.Point(362, 209);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(196, 140);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 5;
            this.pbAnimal.TabStop = false;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.btnComunicar);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnMovimentar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAnimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Listar";
            this.Text = "Listar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
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
    }
}