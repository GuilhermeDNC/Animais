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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoRapina = new System.Windows.Forms.RadioButton();
            this.rbSimRapina = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorPenas = new System.Windows.Forms.TextBox();
            this.userControlAnimal1 = new Interdicilinar.UserControls.UserControlAnimal();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNaoRapina);
            this.groupBox1.Controls.Add(this.rbSimRapina);
            this.groupBox1.Location = new System.Drawing.Point(300, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapina";
            // 
            // rbNaoRapina
            // 
            this.rbNaoRapina.AutoSize = true;
            this.rbNaoRapina.Location = new System.Drawing.Point(6, 62);
            this.rbNaoRapina.Name = "rbNaoRapina";
            this.rbNaoRapina.Size = new System.Drawing.Size(45, 17);
            this.rbNaoRapina.TabIndex = 1;
            this.rbNaoRapina.Text = "Não";
            this.rbNaoRapina.UseVisualStyleBackColor = true;
            this.rbNaoRapina.CheckedChanged += new System.EventHandler(this.rbNaoRapina_CheckedChanged);
            // 
            // rbSimRapina
            // 
            this.rbSimRapina.AutoSize = true;
            this.rbSimRapina.Checked = true;
            this.rbSimRapina.Location = new System.Drawing.Point(6, 29);
            this.rbSimRapina.Name = "rbSimRapina";
            this.rbSimRapina.Size = new System.Drawing.Size(42, 17);
            this.rbSimRapina.TabIndex = 0;
            this.rbSimRapina.TabStop = true;
            this.rbSimRapina.Text = "Sim";
            this.rbSimRapina.UseVisualStyleBackColor = true;
            this.rbSimRapina.CheckedChanged += new System.EventHandler(this.rbSimRapina_CheckedChanged);
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
            this.txtCorPenas.Size = new System.Drawing.Size(108, 20);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userControlAnimal1);
            this.Name = "UserControlAve";
            this.Size = new System.Drawing.Size(403, 299);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNaoRapina;
        private System.Windows.Forms.RadioButton rbSimRapina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorPenas;
        private UserControlAnimal userControlAnimal1;
    }
}
