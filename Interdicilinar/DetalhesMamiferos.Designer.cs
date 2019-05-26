namespace Interdicilinar
{
    partial class DetalhesMamiferos
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
            this.lblPossuiPelo = new System.Windows.Forms.Label();
            this.lblMamas = new System.Windows.Forms.Label();
            this.lblCorPelo = new System.Windows.Forms.Label();
            this.lblPossuiPeloValor = new System.Windows.Forms.Label();
            this.lblCorPeloValor = new System.Windows.Forms.Label();
            this.lblMamasValor = new System.Windows.Forms.Label();
            this.gbComuns = new System.Windows.Forms.GroupBox();
            this.btnComunicar = new System.Windows.Forms.Button();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnVoar = new System.Windows.Forms.Button();
            this.gbOviparos = new System.Windows.Forms.GroupBox();
            this.btnChocar = new System.Windows.Forms.Button();
            this.btnBotar = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnAmamentar = new System.Windows.Forms.Button();
            this.userControlDetalhes1 = new Interdicilinar.UserControls.userControlDetalhes();
            this.gbComuns.SuspendLayout();
            this.gbOviparos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPossuiPelo
            // 
            this.lblPossuiPelo.AutoSize = true;
            this.lblPossuiPelo.Location = new System.Drawing.Point(222, 213);
            this.lblPossuiPelo.Name = "lblPossuiPelo";
            this.lblPossuiPelo.Size = new System.Drawing.Size(64, 13);
            this.lblPossuiPelo.TabIndex = 1;
            this.lblPossuiPelo.Text = "Possui pelo:";
            // 
            // lblMamas
            // 
            this.lblMamas.AutoSize = true;
            this.lblMamas.Location = new System.Drawing.Point(222, 189);
            this.lblMamas.Name = "lblMamas";
            this.lblMamas.Size = new System.Drawing.Size(117, 13);
            this.lblMamas.TabIndex = 2;
            this.lblMamas.Text = "Quantidade de Mamas:";
            // 
            // lblCorPelo
            // 
            this.lblCorPelo.AutoSize = true;
            this.lblCorPelo.Location = new System.Drawing.Point(222, 236);
            this.lblCorPelo.Name = "lblCorPelo";
            this.lblCorPelo.Size = new System.Drawing.Size(64, 13);
            this.lblCorPelo.TabIndex = 3;
            this.lblCorPelo.Text = "Cor do pelo:";
            // 
            // lblPossuiPeloValor
            // 
            this.lblPossuiPeloValor.AutoSize = true;
            this.lblPossuiPeloValor.Location = new System.Drawing.Point(306, 213);
            this.lblPossuiPeloValor.Name = "lblPossuiPeloValor";
            this.lblPossuiPeloValor.Size = new System.Drawing.Size(0, 13);
            this.lblPossuiPeloValor.TabIndex = 4;
            // 
            // lblCorPeloValor
            // 
            this.lblCorPeloValor.AutoSize = true;
            this.lblCorPeloValor.Location = new System.Drawing.Point(306, 236);
            this.lblCorPeloValor.Name = "lblCorPeloValor";
            this.lblCorPeloValor.Size = new System.Drawing.Size(0, 13);
            this.lblCorPeloValor.TabIndex = 5;
            // 
            // lblMamasValor
            // 
            this.lblMamasValor.AutoSize = true;
            this.lblMamasValor.Location = new System.Drawing.Point(345, 189);
            this.lblMamasValor.Name = "lblMamasValor";
            this.lblMamasValor.Size = new System.Drawing.Size(0, 13);
            this.lblMamasValor.TabIndex = 6;
            // 
            // gbComuns
            // 
            this.gbComuns.Controls.Add(this.btnComunicar);
            this.gbComuns.Controls.Add(this.btnMovimentar);
            this.gbComuns.Controls.Add(this.btnAlimentar);
            this.gbComuns.Location = new System.Drawing.Point(453, 30);
            this.gbComuns.Name = "gbComuns";
            this.gbComuns.Size = new System.Drawing.Size(260, 75);
            this.gbComuns.TabIndex = 17;
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
            // btnVoar
            // 
            this.btnVoar.Location = new System.Drawing.Point(719, 88);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 5;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = true;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // gbOviparos
            // 
            this.gbOviparos.Controls.Add(this.btnChocar);
            this.gbOviparos.Controls.Add(this.btnBotar);
            this.gbOviparos.Location = new System.Drawing.Point(485, 127);
            this.gbOviparos.Name = "gbOviparos";
            this.gbOviparos.Size = new System.Drawing.Size(200, 75);
            this.gbOviparos.TabIndex = 20;
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
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(719, 59);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar.TabIndex = 0;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnAmamentar
            // 
            this.btnAmamentar.Location = new System.Drawing.Point(719, 30);
            this.btnAmamentar.Name = "btnAmamentar";
            this.btnAmamentar.Size = new System.Drawing.Size(75, 23);
            this.btnAmamentar.TabIndex = 23;
            this.btnAmamentar.Text = "Amamentar";
            this.btnAmamentar.UseVisualStyleBackColor = true;
            this.btnAmamentar.Click += new System.EventHandler(this.btnAmamentar_Click);
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
            // DetalhesMamiferos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnVoar);
            this.Controls.Add(this.btnAmamentar);
            this.Controls.Add(this.gbOviparos);
            this.Controls.Add(this.gbComuns);
            this.Controls.Add(this.lblMamasValor);
            this.Controls.Add(this.lblCorPeloValor);
            this.Controls.Add(this.lblPossuiPeloValor);
            this.Controls.Add(this.lblCorPelo);
            this.Controls.Add(this.lblMamas);
            this.Controls.Add(this.lblPossuiPelo);
            this.Controls.Add(this.userControlDetalhes1);
            this.Name = "DetalhesMamiferos";
            this.Text = "DetalhesMamiferos";
            this.gbComuns.ResumeLayout(false);
            this.gbOviparos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.userControlDetalhes userControlDetalhes1;
        private System.Windows.Forms.Label lblPossuiPelo;
        private System.Windows.Forms.Label lblMamas;
        private System.Windows.Forms.Label lblCorPelo;
        private System.Windows.Forms.Label lblPossuiPeloValor;
        private System.Windows.Forms.Label lblCorPeloValor;
        private System.Windows.Forms.Label lblMamasValor;
        private System.Windows.Forms.GroupBox gbComuns;
        private System.Windows.Forms.Button btnComunicar;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.GroupBox gbOviparos;
        private System.Windows.Forms.Button btnChocar;
        private System.Windows.Forms.Button btnBotar;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnAmamentar;
    }
}