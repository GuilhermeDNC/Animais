namespace Interdicilinar
{
    partial class DetalhesRepteis
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
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnVoar = new System.Windows.Forms.Button();
            this.gbOviparos = new System.Windows.Forms.GroupBox();
            this.btnChocar = new System.Windows.Forms.Button();
            this.btnBotar = new System.Windows.Forms.Button();
            this.gbComuns = new System.Windows.Forms.GroupBox();
            this.btnComunicar = new System.Windows.Forms.Button();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.userControlDetalhes1 = new Interdicilinar.UserControls.userControlDetalhes();
            this.lblTemCasco = new System.Windows.Forms.Label();
            this.lblTemEscamasValor = new System.Windows.Forms.Label();
            this.lblTemCascoValor = new System.Windows.Forms.Label();
            this.lblTemEscamas = new System.Windows.Forms.Label();
            this.gbOviparos.SuspendLayout();
            this.gbComuns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(707, 61);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar.TabIndex = 25;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnVoar
            // 
            this.btnVoar.Location = new System.Drawing.Point(707, 90);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 26;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = true;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // gbOviparos
            // 
            this.gbOviparos.Controls.Add(this.btnChocar);
            this.gbOviparos.Controls.Add(this.btnBotar);
            this.gbOviparos.Location = new System.Drawing.Point(473, 129);
            this.gbOviparos.Name = "gbOviparos";
            this.gbOviparos.Size = new System.Drawing.Size(200, 75);
            this.gbOviparos.TabIndex = 28;
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
            // gbComuns
            // 
            this.gbComuns.Controls.Add(this.btnComunicar);
            this.gbComuns.Controls.Add(this.btnMovimentar);
            this.gbComuns.Controls.Add(this.btnAlimentar);
            this.gbComuns.Location = new System.Drawing.Point(441, 32);
            this.gbComuns.Name = "gbComuns";
            this.gbComuns.Size = new System.Drawing.Size(260, 75);
            this.gbComuns.TabIndex = 27;
            this.gbComuns.TabStop = false;
            this.gbComuns.Text = "Comuns";
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
            // userControlDetalhes1
            // 
            this.userControlDetalhes1.Carnivoro = "label8";
            this.userControlDetalhes1.Idade = "label10";
            this.userControlDetalhes1.Imagem = null;
            this.userControlDetalhes1.Location = new System.Drawing.Point(12, 12);
            this.userControlDetalhes1.Name = "userControlDetalhes1";
            this.userControlDetalhes1.Nome = "label5";
            this.userControlDetalhes1.Peconhento = "label11";
            this.userControlDetalhes1.Sexo = "label9";
            this.userControlDetalhes1.Size = new System.Drawing.Size(409, 336);
            this.userControlDetalhes1.TabIndex = 0;
            // 
            // lblTemCasco
            // 
            this.lblTemCasco.AutoSize = true;
            this.lblTemCasco.Location = new System.Drawing.Point(175, 190);
            this.lblTemCasco.Name = "lblTemCasco";
            this.lblTemCasco.Size = new System.Drawing.Size(64, 13);
            this.lblTemCasco.TabIndex = 29;
            this.lblTemCasco.Text = "Tem Casco:";
            // 
            // lblTemEscamasValor
            // 
            this.lblTemEscamasValor.AutoSize = true;
            this.lblTemEscamasValor.Location = new System.Drawing.Point(259, 219);
            this.lblTemEscamasValor.Name = "lblTemEscamasValor";
            this.lblTemEscamasValor.Size = new System.Drawing.Size(64, 13);
            this.lblTemEscamasValor.TabIndex = 30;
            this.lblTemEscamasValor.Text = "Tem Casco:";
            // 
            // lblTemCascoValor
            // 
            this.lblTemCascoValor.AutoSize = true;
            this.lblTemCascoValor.Location = new System.Drawing.Point(259, 191);
            this.lblTemCascoValor.Name = "lblTemCascoValor";
            this.lblTemCascoValor.Size = new System.Drawing.Size(64, 13);
            this.lblTemCascoValor.TabIndex = 31;
            this.lblTemCascoValor.Text = "Tem Casco:";
            // 
            // lblTemEscamas
            // 
            this.lblTemEscamas.AutoSize = true;
            this.lblTemEscamas.Location = new System.Drawing.Point(175, 219);
            this.lblTemEscamas.Name = "lblTemEscamas";
            this.lblTemEscamas.Size = new System.Drawing.Size(76, 13);
            this.lblTemEscamas.TabIndex = 32;
            this.lblTemEscamas.Text = "Tem escamas:";
            // 
            // DetalhesRepteis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTemEscamas);
            this.Controls.Add(this.lblTemCascoValor);
            this.Controls.Add(this.lblTemEscamasValor);
            this.Controls.Add(this.lblTemCasco);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnVoar);
            this.Controls.Add(this.gbOviparos);
            this.Controls.Add(this.gbComuns);
            this.Controls.Add(this.userControlDetalhes1);
            this.Name = "DetalhesRepteis";
            this.Text = "DetalhesRepteis";
            this.gbOviparos.ResumeLayout(false);
            this.gbComuns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.userControlDetalhes userControlDetalhes1;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.GroupBox gbOviparos;
        private System.Windows.Forms.Button btnChocar;
        private System.Windows.Forms.Button btnBotar;
        private System.Windows.Forms.GroupBox gbComuns;
        private System.Windows.Forms.Button btnComunicar;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Label lblTemCasco;
        private System.Windows.Forms.Label lblTemEscamasValor;
        private System.Windows.Forms.Label lblTemCascoValor;
        private System.Windows.Forms.Label lblTemEscamas;
    }
}