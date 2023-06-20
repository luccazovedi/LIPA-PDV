namespace LIPA3.Telas
{
    partial class TelaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.usuarioLbl = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.tipoCmb = new System.Windows.Forms.ComboBox();
            this.tipoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "SENHA";
            // 
            // senhaTxt
            // 
            this.senhaTxt.BackColor = System.Drawing.Color.Honeydew;
            this.senhaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.senhaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.ForeColor = System.Drawing.Color.Black;
            this.senhaTxt.Location = new System.Drawing.Point(250, 261);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(275, 27);
            this.senhaTxt.TabIndex = 3;
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.voltarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarBtn.ForeColor = System.Drawing.Color.White;
            this.voltarBtn.Location = new System.Drawing.Point(391, 372);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(135, 35);
            this.voltarBtn.TabIndex = 6;
            this.voltarBtn.Text = "VOLTAR";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // usuarioLbl
            // 
            this.usuarioLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.usuarioLbl.ForeColor = System.Drawing.Color.White;
            this.usuarioLbl.Location = new System.Drawing.Point(246, 179);
            this.usuarioLbl.Name = "usuarioLbl";
            this.usuarioLbl.Size = new System.Drawing.Size(92, 20);
            this.usuarioLbl.TabIndex = 8;
            this.usuarioLbl.Text = "USUÁRIO";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.BackColor = System.Drawing.Color.Honeydew;
            this.usuarioTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuarioTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.ForeColor = System.Drawing.Color.Black;
            this.usuarioTxt.Location = new System.Drawing.Point(250, 202);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(275, 27);
            this.usuarioTxt.TabIndex = 2;
            // 
            // registrarBtn
            // 
            this.registrarBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.registrarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarBtn.ForeColor = System.Drawing.Color.White;
            this.registrarBtn.Location = new System.Drawing.Point(250, 372);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(135, 35);
            this.registrarBtn.TabIndex = 5;
            this.registrarBtn.Text = "REGISTRAR";
            this.registrarBtn.UseVisualStyleBackColor = false;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // nomeLbl
            // 
            this.nomeLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.nomeLbl.ForeColor = System.Drawing.Color.White;
            this.nomeLbl.Location = new System.Drawing.Point(246, 122);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(64, 20);
            this.nomeLbl.TabIndex = 12;
            this.nomeLbl.Text = "NOME";
            // 
            // nomeTxt
            // 
            this.nomeTxt.BackColor = System.Drawing.Color.Honeydew;
            this.nomeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.ForeColor = System.Drawing.Color.Black;
            this.nomeTxt.Location = new System.Drawing.Point(250, 145);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(275, 27);
            this.nomeTxt.TabIndex = 1;
            // 
            // tipoCmb
            // 
            this.tipoCmb.BackColor = System.Drawing.Color.Honeydew;
            this.tipoCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCmb.ForeColor = System.Drawing.Color.Black;
            this.tipoCmb.FormattingEnabled = true;
            this.tipoCmb.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "VENDEDOR"});
            this.tipoCmb.Location = new System.Drawing.Point(250, 318);
            this.tipoCmb.Name = "tipoCmb";
            this.tipoCmb.Size = new System.Drawing.Size(276, 26);
            this.tipoCmb.TabIndex = 4;
            // 
            // tipoLbl
            // 
            this.tipoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLbl.ForeColor = System.Drawing.Color.White;
            this.tipoLbl.Location = new System.Drawing.Point(246, 295);
            this.tipoLbl.Name = "tipoLbl";
            this.tipoLbl.Size = new System.Drawing.Size(93, 20);
            this.tipoLbl.TabIndex = 19;
            this.tipoLbl.Text = "ACESSO";
            // 
            // TelaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tipoLbl);
            this.Controls.Add(this.tipoCmb);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.nomeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.usuarioLbl);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.registrarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Label usuarioLbl;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.ComboBox tipoCmb;
        private System.Windows.Forms.Label tipoLbl;
    }
}