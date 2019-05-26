namespace Interdicilinar.UserControls
{
    partial class userControlDetalhes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCarnivoro = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblPeconhento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnimal
            // 
            this.pbAnimal.Location = new System.Drawing.Point(18, 20);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(179, 130);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 0;
            this.pbAnimal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peconhento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carnívoro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Idade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(63, 174);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "label5";
            // 
            // lblCarnivoro
            // 
            this.lblCarnivoro.AutoSize = true;
            this.lblCarnivoro.Location = new System.Drawing.Point(81, 243);
            this.lblCarnivoro.Name = "lblCarnivoro";
            this.lblCarnivoro.Size = new System.Drawing.Size(35, 13);
            this.lblCarnivoro.TabIndex = 9;
            this.lblCarnivoro.Text = "label8";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(63, 219);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 13);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "label9";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(61, 196);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(41, 13);
            this.lblIdade.TabIndex = 11;
            this.lblIdade.Text = "label10";
            // 
            // lblPeconhento
            // 
            this.lblPeconhento.AutoSize = true;
            this.lblPeconhento.Location = new System.Drawing.Point(92, 268);
            this.lblPeconhento.Name = "lblPeconhento";
            this.lblPeconhento.Size = new System.Drawing.Size(41, 13);
            this.lblPeconhento.TabIndex = 12;
            this.lblPeconhento.Text = "label11";
            // 
            // userControlDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPeconhento);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCarnivoro);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAnimal);
            this.Name = "userControlDetalhes";
            this.Size = new System.Drawing.Size(409, 336);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCarnivoro;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblPeconhento;
    }
}
