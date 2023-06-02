namespace LIPA3.Telas
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.clienteLbl = new System.Windows.Forms.Label();
            this.produtoLbl = new System.Windows.Forms.Label();
            this.vendaLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clienteLbl
            // 
            this.clienteLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clienteLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clienteLbl.Image = ((System.Drawing.Image)(resources.GetObject("clienteLbl.Image")));
            this.clienteLbl.Location = new System.Drawing.Point(239, 196);
            this.clienteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(128, 118);
            this.clienteLbl.TabIndex = 0;
            this.clienteLbl.Click += new System.EventHandler(this.clienteLbl_Click);
            // 
            // produtoLbl
            // 
            this.produtoLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produtoLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.produtoLbl.Image = ((System.Drawing.Image)(resources.GetObject("produtoLbl.Image")));
            this.produtoLbl.Location = new System.Drawing.Point(455, 196);
            this.produtoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.produtoLbl.Name = "produtoLbl";
            this.produtoLbl.Size = new System.Drawing.Size(128, 118);
            this.produtoLbl.TabIndex = 1;
            this.produtoLbl.Click += new System.EventHandler(this.produtoLbl_Click);
            // 
            // vendaLbl
            // 
            this.vendaLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendaLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vendaLbl.Image = ((System.Drawing.Image)(resources.GetObject("vendaLbl.Image")));
            this.vendaLbl.Location = new System.Drawing.Point(664, 196);
            this.vendaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendaLbl.Name = "vendaLbl";
            this.vendaLbl.Size = new System.Drawing.Size(128, 118);
            this.vendaLbl.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.vendaLbl);
            this.Controls.Add(this.produtoLbl);
            this.Controls.Add(this.clienteLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.Label produtoLbl;
        private System.Windows.Forms.Label vendaLbl;
    }
}