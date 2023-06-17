namespace LIPA3.Telas
{
    partial class TelaVendaConsulta
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
            this.vendaDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaDataGrid
            // 
            this.vendaDataGrid.AllowUserToAddRows = false;
            this.vendaDataGrid.AllowUserToDeleteRows = false;
            this.vendaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendaDataGrid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.vendaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DataVenda,
            this.Cliente,
            this.Usuario,
            this.ValorTotal});
            this.vendaDataGrid.GridColor = System.Drawing.Color.SeaGreen;
            this.vendaDataGrid.Location = new System.Drawing.Point(15, 98);
            this.vendaDataGrid.Name = "vendaDataGrid";
            this.vendaDataGrid.ReadOnly = true;
            this.vendaDataGrid.RowHeadersWidth = 51;
            this.vendaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendaDataGrid.Size = new System.Drawing.Size(877, 451);
            this.vendaDataGrid.TabIndex = 90;
            this.vendaDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendaDataGrid_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 45.68528F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.FillWeight = 110.8629F;
            this.DataVenda.HeaderText = "DATA VENDA";
            this.DataVenda.MinimumWidth = 6;
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.FillWeight = 110.8629F;
            this.Cliente.HeaderText = "CLIENTE";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.FillWeight = 110.8629F;
            this.Usuario.HeaderText = "USUÁRIO";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.FillWeight = 110.8629F;
            this.ValorTotal.HeaderText = "VALOR TOTAL";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // TelaVendaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.vendaDataGrid);
            this.Name = "TelaVendaConsulta";
            this.Text = "[LAMBDA] Venda Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaVendaConsulta_FormClosing);
            this.Load += new System.EventHandler(this.TelaVendaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vendaDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}