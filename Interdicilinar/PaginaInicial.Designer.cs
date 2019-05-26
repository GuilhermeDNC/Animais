namespace Interdicilinar
{
    partial class PaginaInicial
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbPredadores = new System.Windows.Forms.RadioButton();
            this.rbIdade = new System.Windows.Forms.RadioButton();
            this.rbVoar = new System.Windows.Forms.RadioButton();
            this.rbAquaticos = new System.Windows.Forms.RadioButton();
            this.rbOviparos = new System.Windows.Forms.RadioButton();
            this.rbMamiferos = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.lbAnimais = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhes.Location = new System.Drawing.Point(0, 255);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(250, 28);
            this.btnDetalhes.TabIndex = 22;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // pbAnimal
            // 
            this.pbAnimal.BackColor = System.Drawing.Color.Silver;
            this.pbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAnimal.Location = new System.Drawing.Point(220, 0);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(400, 405);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 15;
            this.pbAnimal.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.btnDetalhes);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.rbPredadores);
            this.groupBox1.Controls.Add(this.rbIdade);
            this.groupBox1.Controls.Add(this.rbVoar);
            this.groupBox1.Controls.Add(this.rbAquaticos);
            this.groupBox1.Controls.Add(this.rbOviparos);
            this.groupBox1.Controls.Add(this.rbMamiferos);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(620, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 405);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Por";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(0, 209);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(250, 30);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbPredadores
            // 
            this.rbPredadores.AutoSize = true;
            this.rbPredadores.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPredadores.Location = new System.Drawing.Point(22, 147);
            this.rbPredadores.Name = "rbPredadores";
            this.rbPredadores.Size = new System.Drawing.Size(131, 30);
            this.rbPredadores.TabIndex = 7;
            this.rbPredadores.TabStop = true;
            this.rbPredadores.Text = "Predadores";
            this.rbPredadores.UseVisualStyleBackColor = true;
            this.rbPredadores.CheckedChanged += new System.EventHandler(this.rbPredadores_CheckedChanged);
            // 
            // rbIdade
            // 
            this.rbIdade.AutoSize = true;
            this.rbIdade.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdade.Location = new System.Drawing.Point(21, 170);
            this.rbIdade.Name = "rbIdade";
            this.rbIdade.Size = new System.Drawing.Size(81, 30);
            this.rbIdade.TabIndex = 6;
            this.rbIdade.TabStop = true;
            this.rbIdade.Text = "Idade";
            this.rbIdade.UseVisualStyleBackColor = true;
            this.rbIdade.CheckedChanged += new System.EventHandler(this.rbIdade_CheckedChanged);
            // 
            // rbVoar
            // 
            this.rbVoar.AutoSize = true;
            this.rbVoar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVoar.Location = new System.Drawing.Point(22, 124);
            this.rbVoar.Name = "rbVoar";
            this.rbVoar.Size = new System.Drawing.Size(115, 30);
            this.rbVoar.TabIndex = 4;
            this.rbVoar.TabStop = true;
            this.rbVoar.Text = "Voadores";
            this.rbVoar.UseVisualStyleBackColor = true;
            this.rbVoar.CheckedChanged += new System.EventHandler(this.rbVoar_CheckedChanged);
            // 
            // rbAquaticos
            // 
            this.rbAquaticos.AutoSize = true;
            this.rbAquaticos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAquaticos.Location = new System.Drawing.Point(22, 100);
            this.rbAquaticos.Name = "rbAquaticos";
            this.rbAquaticos.Size = new System.Drawing.Size(119, 30);
            this.rbAquaticos.TabIndex = 3;
            this.rbAquaticos.TabStop = true;
            this.rbAquaticos.Text = "Aquáticos";
            this.rbAquaticos.UseVisualStyleBackColor = true;
            this.rbAquaticos.CheckedChanged += new System.EventHandler(this.rbAquaticos_CheckedChanged);
            // 
            // rbOviparos
            // 
            this.rbOviparos.AutoSize = true;
            this.rbOviparos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOviparos.Location = new System.Drawing.Point(22, 76);
            this.rbOviparos.Name = "rbOviparos";
            this.rbOviparos.Size = new System.Drawing.Size(112, 30);
            this.rbOviparos.TabIndex = 2;
            this.rbOviparos.TabStop = true;
            this.rbOviparos.Text = "Ovíparos";
            this.rbOviparos.UseVisualStyleBackColor = true;
            this.rbOviparos.CheckedChanged += new System.EventHandler(this.rbOviparos_CheckedChanged);
            // 
            // rbMamiferos
            // 
            this.rbMamiferos.AutoSize = true;
            this.rbMamiferos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMamiferos.Location = new System.Drawing.Point(22, 52);
            this.rbMamiferos.Name = "rbMamiferos";
            this.rbMamiferos.Size = new System.Drawing.Size(127, 30);
            this.rbMamiferos.TabIndex = 1;
            this.rbMamiferos.TabStop = true;
            this.rbMamiferos.Text = "Mamíferos";
            this.rbMamiferos.UseVisualStyleBackColor = true;
            this.rbMamiferos.CheckedChanged += new System.EventHandler(this.rbMamiferos_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(22, 28);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(85, 30);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // lbAnimais
            // 
            this.lbAnimais.BackColor = System.Drawing.Color.LightSalmon;
            this.lbAnimais.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAnimais.Font = new System.Drawing.Font("Open Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimais.FormattingEnabled = true;
            this.lbAnimais.ItemHeight = 22;
            this.lbAnimais.Location = new System.Drawing.Point(0, 0);
            this.lbAnimais.Name = "lbAnimais";
            this.lbAnimais.Size = new System.Drawing.Size(221, 405);
            this.lbAnimais.TabIndex = 13;
            this.lbAnimais.SelectedValueChanged += new System.EventHandler(this.lbAnimais_SelectedValueChanged);
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 405);
            this.Controls.Add(this.pbAnimal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAnimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaginaInicial";
            this.Text = "Animais";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.PictureBox pbAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPredadores;
        private System.Windows.Forms.RadioButton rbIdade;
        private System.Windows.Forms.RadioButton rbVoar;
        private System.Windows.Forms.RadioButton rbAquaticos;
        private System.Windows.Forms.RadioButton rbOviparos;
        private System.Windows.Forms.RadioButton rbMamiferos;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.ListBox lbAnimais;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

