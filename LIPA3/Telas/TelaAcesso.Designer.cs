namespace LIPA3
{
    partial class TelaAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAcesso));
            this.entrarBtn = new System.Windows.Forms.Button();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.usuarioLbl = new System.Windows.Forms.Label();
            this.sairBtn = new System.Windows.Forms.Button();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.criarContaLbl = new System.Windows.Forms.Label();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entrarBtn
            // 
            this.entrarBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.entrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarBtn.ForeColor = System.Drawing.Color.Transparent;
            this.entrarBtn.Location = new System.Drawing.Point(268, 280);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(135, 35);
            this.entrarBtn.TabIndex = 3;
            this.entrarBtn.Text = "ENTRAR";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usuarioTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuarioTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.ForeColor = System.Drawing.Color.White;
            this.usuarioTxt.Location = new System.Drawing.Point(268, 194);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(275, 27);
            this.usuarioTxt.TabIndex = 1;
            this.usuarioTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.usuarioTxt_PreviewKeyDown);
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.BackColor = System.Drawing.Color.Transparent;
            this.usuarioLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold);
            this.usuarioLbl.ForeColor = System.Drawing.Color.White;
            this.usuarioLbl.Location = new System.Drawing.Point(265, 171);
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(93, 20);
            this.usuarioLbl.TabIndex = 2;
            this.usuarioLbl.Text = "USUÁRIO";
            // 
            // sairBtn
            // 
            this.sairBtn.BackColor = System.Drawing.Color.Teal;
            this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairBtn.ForeColor = System.Drawing.Color.Transparent;
            this.sairBtn.Location = new System.Drawing.Point(409, 280);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(135, 35);
            this.sairBtn.TabIndex = 4;
            this.sairBtn.Text = "SAIR";
            this.sairBtn.UseVisualStyleBackColor = false;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // senhaTxt
            // 
            this.senhaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.senhaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.senhaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.ForeColor = System.Drawing.Color.White;
            this.senhaTxt.Location = new System.Drawing.Point(268, 247);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(275, 27);
            this.senhaTxt.TabIndex = 2;
            this.senhaTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.senhaTxt_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SENHA";
            // 
            // criarContaLbl
            // 
            this.criarContaLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarContaLbl.ForeColor = System.Drawing.Color.White;
            this.criarContaLbl.Location = new System.Drawing.Point(265, 457);
            this.criarContaLbl.Name = "criarContaLbl";
            this.criarContaLbl.Size = new System.Drawing.Size(278, 20);
            this.criarContaLbl.TabIndex = 6;
            this.criarContaLbl.Text = "NÃO POSSUI UMA CONTA?";
            this.criarContaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registrarBtn
            // 
            this.registrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.ForeColor = System.Drawing.Color.White;
            this.registrarBtn.Location = new System.Drawing.Point(339, 480);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(135, 35);
            this.registrarBtn.TabIndex = 5;
            this.registrarBtn.Text = "REGISTRAR";
            this.registrarBtn.UseVisualStyleBackColor = false;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // TelaAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.registrarBtn);
            this.Controls.Add(this.criarContaLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.sairBtn);
            this.Controls.Add(this.usuarioLbl);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.entrarBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Label usuarioLbl;
        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label criarContaLbl;
        private System.Windows.Forms.Button registrarBtn;
    }
}

