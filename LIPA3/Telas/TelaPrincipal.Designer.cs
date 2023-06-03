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
            this.painelPnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // clienteLbl
            // 
            this.clienteLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clienteLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clienteLbl.Image = ((System.Drawing.Image)(resources.GetObject("clienteLbl.Image")));
            this.clienteLbl.Location = new System.Drawing.Point(12, 9);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(96, 96);
            this.clienteLbl.TabIndex = 0;
            this.clienteLbl.Click += new System.EventHandler(this.clienteLbl_Click);
            // 
            // produtoLbl
            // 
            this.produtoLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produtoLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.produtoLbl.Image = ((System.Drawing.Image)(resources.GetObject("produtoLbl.Image")));
            this.produtoLbl.Location = new System.Drawing.Point(105, 9);
            this.produtoLbl.Name = "produtoLbl";
            this.produtoLbl.Size = new System.Drawing.Size(96, 96);
            this.produtoLbl.TabIndex = 1;
            this.produtoLbl.Click += new System.EventHandler(this.produtoLbl_Click);
            // 
            // vendaLbl
            // 
            this.vendaLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendaLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vendaLbl.Image = ((System.Drawing.Image)(resources.GetObject("vendaLbl.Image")));
            this.vendaLbl.Location = new System.Drawing.Point(207, 9);
            this.vendaLbl.Name = "vendaLbl";
            this.vendaLbl.Size = new System.Drawing.Size(96, 96);
            this.vendaLbl.TabIndex = 3;
            // 
            // painelPnl
            // 
            this.painelPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelPnl.Location = new System.Drawing.Point(13, 109);
            this.painelPnl.Name = "painelPnl";
            this.painelPnl.Size = new System.Drawing.Size(759, 440);
            this.painelPnl.TabIndex = 4;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.painelPnl);
            this.Controls.Add(this.vendaLbl);
            this.Controls.Add(this.produtoLbl);
            this.Controls.Add(this.clienteLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.Label produtoLbl;
        private System.Windows.Forms.Label vendaLbl;
        private System.Windows.Forms.Panel painelPnl;
    }
}