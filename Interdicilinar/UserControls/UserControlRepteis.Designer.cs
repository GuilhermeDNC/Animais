namespace Interdicilinar.UserControls
{
    partial class UserControlRepteis
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
            this.userControlAnimal1 = new Interdicilinar.UserControls.UserControlAnimal();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoEscamas = new System.Windows.Forms.RadioButton();
            this.rbSimEscamas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNaoCasco = new System.Windows.Forms.RadioButton();
            this.rbSimCasco = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControlAnimal1
            // 
            this.userControlAnimal1.BoolCarnivoro = true;
            this.userControlAnimal1.BoolPeconhento = false;
            this.userControlAnimal1.BoolSexo = 'F';
            this.userControlAnimal1.Location = new System.Drawing.Point(0, 0);
            this.userControlAnimal1.Name = "userControlAnimal1";
            this.userControlAnimal1.Size = new System.Drawing.Size(404, 339);
            this.userControlAnimal1.TabIndex = 0;
            this.userControlAnimal1.TextoNascimento = null;
            this.userControlAnimal1.TextoNome = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNaoEscamas);
            this.groupBox1.Controls.Add(this.rbSimEscamas);
            this.groupBox1.Location = new System.Drawing.Point(304, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escamas";
            // 
            // rbNaoEscamas
            // 
            this.rbNaoEscamas.AutoSize = true;
            this.rbNaoEscamas.Location = new System.Drawing.Point(6, 62);
            this.rbNaoEscamas.Name = "rbNaoEscamas";
            this.rbNaoEscamas.Size = new System.Drawing.Size(45, 17);
            this.rbNaoEscamas.TabIndex = 1;
            this.rbNaoEscamas.Text = "Não";
            this.rbNaoEscamas.UseVisualStyleBackColor = true;
            this.rbNaoEscamas.CheckedChanged += new System.EventHandler(this.rbNaoEscamas_CheckedChanged);
            // 
            // rbSimEscamas
            // 
            this.rbSimEscamas.AutoSize = true;
            this.rbSimEscamas.Checked = true;
            this.rbSimEscamas.Location = new System.Drawing.Point(6, 29);
            this.rbSimEscamas.Name = "rbSimEscamas";
            this.rbSimEscamas.Size = new System.Drawing.Size(42, 17);
            this.rbSimEscamas.TabIndex = 0;
            this.rbSimEscamas.TabStop = true;
            this.rbSimEscamas.Text = "Sim";
            this.rbSimEscamas.UseVisualStyleBackColor = true;
            this.rbSimEscamas.CheckedChanged += new System.EventHandler(this.rbSimEscamas_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNaoCasco);
            this.groupBox2.Controls.Add(this.rbSimCasco);
            this.groupBox2.Location = new System.Drawing.Point(252, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tem Casco";
            // 
            // rbNaoCasco
            // 
            this.rbNaoCasco.AutoSize = true;
            this.rbNaoCasco.Location = new System.Drawing.Point(6, 62);
            this.rbNaoCasco.Name = "rbNaoCasco";
            this.rbNaoCasco.Size = new System.Drawing.Size(45, 17);
            this.rbNaoCasco.TabIndex = 1;
            this.rbNaoCasco.Text = "Não";
            this.rbNaoCasco.UseVisualStyleBackColor = true;
            this.rbNaoCasco.CheckedChanged += new System.EventHandler(this.rbNaoCasco_CheckedChanged);
            // 
            // rbSimCasco
            // 
            this.rbSimCasco.AutoSize = true;
            this.rbSimCasco.Checked = true;
            this.rbSimCasco.Location = new System.Drawing.Point(6, 29);
            this.rbSimCasco.Name = "rbSimCasco";
            this.rbSimCasco.Size = new System.Drawing.Size(42, 17);
            this.rbSimCasco.TabIndex = 0;
            this.rbSimCasco.TabStop = true;
            this.rbSimCasco.Text = "Sim";
            this.rbSimCasco.UseVisualStyleBackColor = true;
            this.rbSimCasco.CheckedChanged += new System.EventHandler(this.rbSimCasco_CheckedChanged);
            // 
            // UserControlRepteis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userControlAnimal1);
            this.Name = "UserControlRepteis";
            this.Size = new System.Drawing.Size(419, 351);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlAnimal userControlAnimal1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNaoEscamas;
        private System.Windows.Forms.RadioButton rbSimEscamas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNaoCasco;
        private System.Windows.Forms.RadioButton rbSimCasco;
    }
}
