namespace Interdicilinar.UserControls
{
    partial class UserControlAve
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorPenas = new System.Windows.Forms.TextBox();
            this.userControlAnimal1 = new Interdicilinar.UserControls.UserControlAnimal();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cor penas:";
            // 
            // txtCorPenas
            // 
            this.txtCorPenas.Location = new System.Drawing.Point(67, 71);
            this.txtCorPenas.Name = "txtCorPenas";
            this.txtCorPenas.Size = new System.Drawing.Size(103, 20);
            this.txtCorPenas.TabIndex = 3;
            this.txtCorPenas.TextChanged += new System.EventHandler(this.txtCorPenas_TextChanged);
            // 
            // userControlAnimal1
            // 
            this.userControlAnimal1.BoolCarnivoro = true;
            this.userControlAnimal1.BoolPeconhento = false;
            this.userControlAnimal1.BoolSexo = 'F';
            this.userControlAnimal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAnimal1.Location = new System.Drawing.Point(0, 0);
            this.userControlAnimal1.Name = "userControlAnimal1";
            this.userControlAnimal1.Size = new System.Drawing.Size(403, 299);
            this.userControlAnimal1.TabIndex = 0;
            this.userControlAnimal1.TextoNascimento = null;
            this.userControlAnimal1.TextoNome = "";
            // 
            // UserControlAve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCorPenas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlAnimal1);
            this.Name = "UserControlAve";
            this.Size = new System.Drawing.Size(403, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorPenas;
        private UserControlAnimal userControlAnimal1;
    }
}
