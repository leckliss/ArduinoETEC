namespace injection_modelo
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.buttonEntrarErr = new System.Windows.Forms.Button();
            this.buttonEntrarOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Arial", 14F);
            this.textUsuario.Location = new System.Drawing.Point(144, 318);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(201, 34);
            this.textUsuario.TabIndex = 3;
            this.textUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            this.textUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUsuario_KeyPress);
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Arial", 14F);
            this.textSenha.Location = new System.Drawing.Point(144, 382);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(201, 34);
            this.textSenha.TabIndex = 4;
            this.textSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // buttonEntrarErr
            // 
            this.buttonEntrarErr.BackColor = System.Drawing.Color.Red;
            this.buttonEntrarErr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarErr.Location = new System.Drawing.Point(144, 422);
            this.buttonEntrarErr.Name = "buttonEntrarErr";
            this.buttonEntrarErr.Size = new System.Drawing.Size(201, 47);
            this.buttonEntrarErr.TabIndex = 5;
            this.buttonEntrarErr.Text = "Entrar";
            this.buttonEntrarErr.UseVisualStyleBackColor = false;
            this.buttonEntrarErr.Click += new System.EventHandler(this.buttonEntrarErr_Click);
            // 
            // buttonEntrarOk
            // 
            this.buttonEntrarOk.BackColor = System.Drawing.Color.Lime;
            this.buttonEntrarOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarOk.Location = new System.Drawing.Point(144, 466);
            this.buttonEntrarOk.Name = "buttonEntrarOk";
            this.buttonEntrarOk.Size = new System.Drawing.Size(201, 47);
            this.buttonEntrarOk.TabIndex = 6;
            this.buttonEntrarOk.Text = "Entrar";
            this.buttonEntrarOk.UseVisualStyleBackColor = false;
            this.buttonEntrarOk.Click += new System.EventHandler(this.buttonEntrarOk_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 525);
            this.Controls.Add(this.buttonEntrarOk);
            this.Controls.Add(this.buttonEntrarErr);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button buttonEntrarErr;
        private System.Windows.Forms.Button buttonEntrarOk;
    }
}

