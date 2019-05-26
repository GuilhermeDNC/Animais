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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbOviparos.SuspendLayout();
            this.gbComuns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.IndianRed;
            this.btnAtacar.Location = new System.Drawing.Point(739, 32);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar.TabIndex = 25;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnVoar
            // 
            this.btnVoar.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoar.Location = new System.Drawing.Point(739, 61);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 26;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = false;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // gbOviparos
            // 
            this.gbOviparos.BackColor = System.Drawing.Color.OliveDrab;
            this.gbOviparos.Controls.Add(this.btnChocar);
            this.gbOviparos.Controls.Add(this.btnBotar);
            this.gbOviparos.Location = new System.Drawing.Point(502, 103);
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
            this.gbComuns.BackColor = System.Drawing.Color.DimGray;
            this.gbComuns.Controls.Add(this.btnComunicar);
            this.gbComuns.Controls.Add(this.btnMovimentar);
            this.gbComuns.Controls.Add(this.btnAlimentar);
            this.gbComuns.Location = new System.Drawing.Point(473, 22);
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
            this.userControlDetalhes1.Dock = System.Windows.Forms.DockStyle.Left;
            this.userControlDetalhes1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDetalhes1.Idade = "label10";
            this.userControlDetalhes1.Imagem = null;
            this.userControlDetalhes1.Location = new System.Drawing.Point(0, 0);
            this.userControlDetalhes1.Margin = new System.Windows.Forms.Padding(6);
            this.userControlDetalhes1.Name = "userControlDetalhes1";
            this.userControlDetalhes1.Nome = "label5";
            this.userControlDetalhes1.Peconhento = "label11";
            this.userControlDetalhes1.Sexo = "label9";
            this.userControlDetalhes1.Size = new System.Drawing.Size(464, 517);
            this.userControlDetalhes1.TabIndex = 0;
            // 
            // lblTemCasco
            // 
            this.lblTemCasco.AutoSize = true;
            this.lblTemCasco.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemCasco.Location = new System.Drawing.Point(6, 29);
            this.lblTemCasco.Name = "lblTemCasco";
            this.lblTemCasco.Size = new System.Drawing.Size(115, 26);
            this.lblTemCasco.TabIndex = 29;
            this.lblTemCasco.Text = "Tem Casco:";
            // 
            // lblTemEscamasValor
            // 
            this.lblTemEscamasValor.AutoSize = true;
            this.lblTemEscamasValor.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemEscamasValor.Location = new System.Drawing.Point(138, 66);
            this.lblTemEscamasValor.Name = "lblTemEscamasValor";
            this.lblTemEscamasValor.Size = new System.Drawing.Size(0, 26);
            this.lblTemEscamasValor.TabIndex = 30;
            // 
            // lblTemCascoValor
            // 
            this.lblTemCascoValor.AutoSize = true;
            this.lblTemCascoValor.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemCascoValor.Location = new System.Drawing.Point(127, 29);
            this.lblTemCascoValor.Name = "lblTemCascoValor";
            this.lblTemCascoValor.Size = new System.Drawing.Size(0, 26);
            this.lblTemCascoValor.TabIndex = 31;
            // 
            // lblTemEscamas
            // 
            this.lblTemEscamas.AutoSize = true;
            this.lblTemEscamas.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemEscamas.Location = new System.Drawing.Point(3, 66);
            this.lblTemEscamas.Name = "lblTemEscamas";
            this.lblTemEscamas.Size = new System.Drawing.Size(140, 26);
            this.lblTemEscamas.TabIndex = 32;
            this.lblTemEscamas.Text = "Tem escamas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTemCasco);
            this.groupBox1.Controls.Add(this.lblTemEscamas);
            this.groupBox1.Controls.Add(this.lblTemEscamasValor);
            this.groupBox1.Controls.Add(this.lblTemCascoValor);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(249, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Répteis";
            // 
            // DetalhesRepteis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(823, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnVoar);
            this.Controls.Add(this.gbOviparos);
            this.Controls.Add(this.gbComuns);
            this.Controls.Add(this.userControlDetalhes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetalhesRepteis";
            this.Text = "DetalhesRepteis";
            this.gbOviparos.ResumeLayout(false);
            this.gbComuns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}