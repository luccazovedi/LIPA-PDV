namespace LIPA3.Telas
{
    partial class TelaClienteConsulta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaClienteConsulta));
			this.clienteDataGrid = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// clienteDataGrid
			// 
			this.clienteDataGrid.AllowUserToAddRows = false;
			this.clienteDataGrid.AllowUserToDeleteRows = false;
			this.clienteDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.clienteDataGrid.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.clienteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.clienteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Cpf,
            this.Rg,
            this.Cidade,
            this.Estado});
			this.clienteDataGrid.GridColor = System.Drawing.Color.SeaGreen;
			this.clienteDataGrid.Location = new System.Drawing.Point(12, 12);
			this.clienteDataGrid.Name = "clienteDataGrid";
			this.clienteDataGrid.ReadOnly = true;
			this.clienteDataGrid.RowHeadersWidth = 51;
			this.clienteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.clienteDataGrid.Size = new System.Drawing.Size(880, 444);
			this.clienteDataGrid.TabIndex = 53;
			this.clienteDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGrid_CellDoubleClick);
			// 
			// ID
			// 
			this.ID.FillWeight = 45.68528F;
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Nome
			// 
			this.Nome.FillWeight = 110.8629F;
			this.Nome.HeaderText = "NOME";
			this.Nome.MinimumWidth = 6;
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			// 
			// Cpf
			// 
			this.Cpf.FillWeight = 110.8629F;
			this.Cpf.HeaderText = "CPF";
			this.Cpf.MinimumWidth = 6;
			this.Cpf.Name = "Cpf";
			this.Cpf.ReadOnly = true;
			// 
			// Rg
			// 
			this.Rg.FillWeight = 110.8629F;
			this.Rg.HeaderText = "RG";
			this.Rg.MinimumWidth = 6;
			this.Rg.Name = "Rg";
			this.Rg.ReadOnly = true;
			// 
			// Cidade
			// 
			this.Cidade.FillWeight = 110.8629F;
			this.Cidade.HeaderText = "CIDADE";
			this.Cidade.MinimumWidth = 6;
			this.Cidade.Name = "Cidade";
			this.Cidade.ReadOnly = true;
			// 
			// Estado
			// 
			this.Estado.FillWeight = 110.8629F;
			this.Estado.HeaderText = "ESTADO";
			this.Estado.MinimumWidth = 6;
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// TelaClienteConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(904, 461);
			this.Controls.Add(this.clienteDataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaClienteConsulta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "[LAMBDA] Cliente Consulta";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaClienteConsulta_FormClosing);
			this.Load += new System.EventHandler(this.TelaClienteConsulta_Load);
			((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clienteDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}