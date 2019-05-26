namespace Interdicilinar.UserControls
{
    partial class UserControlMamiferos
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
            this.nudMamas = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaoPelos = new System.Windows.Forms.RadioButton();
            this.rbSimPelos = new System.Windows.Forms.RadioButton();
            this.lblCorPelo = new System.Windows.Forms.Label();
            this.txtCorPelo = new System.Windows.Forms.TextBox();
            this.userControlAnimal1 = new Interdicilinar.UserControls.UserControlAnimal();
            ((System.ComponentModel.ISupportInitialize)(this.nudMamas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mamas:";
            // 
            // nudMamas
            // 
            this.nudMamas.Location = new System.Drawing.Point(73, 79);
            this.nudMamas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMamas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMamas.Name = "nudMamas";
            this.nudMamas.Size = new System.Drawing.Size(99, 20);
            this.nudMamas.TabIndex = 2;
            this.nudMamas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMamas.ValueChanged += new System.EventHandler(this.nudMamas_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNaoPelos);
            this.groupBox1.Controls.Add(this.rbSimPelos);
            this.groupBox1.Location = new System.Drawing.Point(301, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pelos";
            // 
            // rbNaoPelos
            // 
            this.rbNaoPelos.AutoSize = true;
            this.rbNaoPelos.Location = new System.Drawing.Point(7, 61);
            this.rbNaoPelos.Name = "rbNaoPelos";
            this.rbNaoPelos.Size = new System.Drawing.Size(45, 17);
            this.rbNaoPelos.TabIndex = 1;
            this.rbNaoPelos.Text = "Não";
            this.rbNaoPelos.UseVisualStyleBackColor = true;
            // 
            // rbSimPelos
            // 
            this.rbSimPelos.AutoSize = true;
            this.rbSimPelos.Checked = true;
            this.rbSimPelos.Location = new System.Drawing.Point(6, 28);
            this.rbSimPelos.Name = "rbSimPelos";
            this.rbSimPelos.Size = new System.Drawing.Size(42, 17);
            this.rbSimPelos.TabIndex = 0;
            this.rbSimPelos.TabStop = true;
            this.rbSimPelos.Text = "Sim";
            this.rbSimPelos.UseVisualStyleBackColor = true;
            this.rbSimPelos.CheckedChanged += new System.EventHandler(this.rbSimPelos_CheckedChanged);
            // 
            // lblCorPelo
            // 
            this.lblCorPelo.AutoSize = true;
            this.lblCorPelo.Location = new System.Drawing.Point(3, 110);
            this.lblCorPelo.Name = "lblCorPelo";
            this.lblCorPelo.Size = new System.Drawing.Size(64, 13);
            this.lblCorPelo.TabIndex = 4;
            this.lblCorPelo.Text = "Cor do pelo:";
            // 
            // txtCorPelo
            // 
            this.txtCorPelo.Location = new System.Drawing.Point(73, 107);
            this.txtCorPelo.Name = "txtCorPelo";
            this.txtCorPelo.Size = new System.Drawing.Size(99, 20);
            this.txtCorPelo.TabIndex = 5;
            this.txtCorPelo.TextChanged += new System.EventHandler(this.txtCorPelo_TextChanged);
            // 
            // userControlAnimal1
            // 
            this.userControlAnimal1.BoolCarnivoro = true;
            this.userControlAnimal1.BoolPeconhento = false;
            this.userControlAnimal1.BoolSexo = 'M';
            this.userControlAnimal1.Location = new System.Drawing.Point(0, 0);
            this.userControlAnimal1.Name = "userControlAnimal1";
            this.userControlAnimal1.Size = new System.Drawing.Size(401, 344);
            this.userControlAnimal1.TabIndex = 0;
            this.userControlAnimal1.TextoNascimento = "";
            this.userControlAnimal1.TextoNome = "";
            // 
            // UserControlMamiferos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCorPelo);
            this.Controls.Add(this.lblCorPelo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudMamas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlAnimal1);
            this.Name = "UserControlMamiferos";
            this.Size = new System.Drawing.Size(415, 259);
            ((System.ComponentModel.ISupportInitialize)(this.nudMamas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlAnimal userControlAnimal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMamas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNaoPelos;
        private System.Windows.Forms.RadioButton rbSimPelos;
        private System.Windows.Forms.Label lblCorPelo;
        private System.Windows.Forms.TextBox txtCorPelo;
    }
}
