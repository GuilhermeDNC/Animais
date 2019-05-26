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
            this.userControlDetalhes1 = new Interdicilinar.UserControls.userControlDetalhes();
            this.SuspendLayout();
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
            // DetalhesRepteis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlDetalhes1);
            this.Name = "DetalhesRepteis";
            this.Text = "DetalhesRepteis";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.userControlDetalhes userControlDetalhes1;
    }
}