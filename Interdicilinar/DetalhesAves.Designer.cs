namespace Interdicilinar
{
    partial class DetalhesAves
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
            this.userControlDetalhes1 = new Interdicilinar.UserControls.userControlDetalhes();
            this.lblRapina = new System.Windows.Forms.Label();
            this.lblRapinaValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorPenas = new System.Windows.Forms.Label();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnVoar = new System.Windows.Forms.Button();
            this.gbOviparos = new System.Windows.Forms.GroupBox();
            this.btnChocar = new System.Windows.Forms.Button();
            this.btnBotar = new System.Windows.Forms.Button();
            this.gbComuns = new System.Windows.Forms.GroupBox();
            this.btnComunicar = new System.Windows.Forms.Button();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.bntCiscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbOviparos.SuspendLayout();
            this.gbComuns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.userControlDetalhes1.Size = new System.Drawing.Size(442, 517);
            this.userControlDetalhes1.TabIndex = 0;
            // 
            // lblRapina
            // 
            this.lblRapina.AutoSize = true;
            this.lblRapina.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapina.Location = new System.Drawing.Point(6, 29);
            this.lblRapina.Name = "lblRapina";
            this.lblRapina.Size = new System.Drawing.Size(80, 26);
            this.lblRapina.TabIndex = 1;
            this.lblRapina.Text = "Rapina:";
            // 
            // lblRapinaValor
            // 
            this.lblRapinaValor.AutoSize = true;
            this.lblRapinaValor.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapinaValor.Location = new System.Drawing.Point(92, 29);
            this.lblRapinaValor.Name = "lblRapinaValor";
            this.lblRapinaValor.Size = new System.Drawing.Size(0, 26);
            this.lblRapinaValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cor das Penas:";
            // 
            // lblCorPenas
            // 
            this.lblCorPenas.AutoSize = true;
            this.lblCorPenas.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorPenas.Location = new System.Drawing.Point(145, 65);
            this.lblCorPenas.Name = "lblCorPenas";
            this.lblCorPenas.Size = new System.Drawing.Size(0, 26);
            this.lblCorPenas.TabIndex = 4;
            // 
            // btnAtacar
            // 
            this.btnAtacar.BackColor = System.Drawing.Color.IndianRed;
            this.btnAtacar.Location = new System.Drawing.Point(717, 57);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(75, 23);
            this.btnAtacar.TabIndex = 21;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = false;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnVoar
            // 
            this.btnVoar.BackColor = System.Drawing.Color.IndianRed;
            this.btnVoar.Location = new System.Drawing.Point(717, 86);
            this.btnVoar.Name = "btnVoar";
            this.btnVoar.Size = new System.Drawing.Size(75, 23);
            this.btnVoar.TabIndex = 22;
            this.btnVoar.Text = "Voar";
            this.btnVoar.UseVisualStyleBackColor = false;
            this.btnVoar.Click += new System.EventHandler(this.btnVoar_Click);
            // 
            // gbOviparos
            // 
            this.gbOviparos.BackColor = System.Drawing.Color.OliveDrab;
            this.gbOviparos.Controls.Add(this.btnChocar);
            this.gbOviparos.Controls.Add(this.btnBotar);
            this.gbOviparos.Location = new System.Drawing.Point(479, 109);
            this.gbOviparos.Name = "gbOviparos";
            this.gbOviparos.Size = new System.Drawing.Size(200, 75);
            this.gbOviparos.TabIndex = 24;
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
            this.gbComuns.Location = new System.Drawing.Point(451, 28);
            this.gbComuns.Name = "gbComuns";
            this.gbComuns.Size = new System.Drawing.Size(260, 75);
            this.gbComuns.TabIndex = 23;
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
            // bntCiscar
            // 
            this.bntCiscar.BackColor = System.Drawing.Color.IndianRed;
            this.bntCiscar.Location = new System.Drawing.Point(717, 28);
            this.bntCiscar.Name = "bntCiscar";
            this.bntCiscar.Size = new System.Drawing.Size(75, 23);
            this.bntCiscar.TabIndex = 25;
            this.bntCiscar.Text = "Ciscar";
            this.bntCiscar.UseVisualStyleBackColor = false;
            this.bntCiscar.Click += new System.EventHandler(this.bntCiscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRapina);
            this.groupBox1.Controls.Add(this.lblRapinaValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCorPenas);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(278, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aves";
            // 
            // DetalhesAves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntCiscar);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnVoar);
            this.Controls.Add(this.gbOviparos);
            this.Controls.Add(this.gbComuns);
            this.Controls.Add(this.userControlDetalhes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetalhesAves";
            this.Text = "DetalhesAves";
            this.gbOviparos.ResumeLayout(false);
            this.gbComuns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.userControlDetalhes userControlDetalhes1;
        private System.Windows.Forms.Label lblRapina;
        private System.Windows.Forms.Label lblRapinaValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorPenas;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnVoar;
        private System.Windows.Forms.GroupBox gbOviparos;
        private System.Windows.Forms.Button btnChocar;
        private System.Windows.Forms.Button btnBotar;
        private System.Windows.Forms.GroupBox gbComuns;
        private System.Windows.Forms.Button btnComunicar;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button bntCiscar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}