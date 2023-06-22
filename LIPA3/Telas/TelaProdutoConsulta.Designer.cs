namespace LIPA3.Telas
{
    partial class TelaProdutoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProdutoConsulta));
            this.produtoDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoDataGrid
            // 
            this.produtoDataGrid.AllowUserToAddRows = false;
            this.produtoDataGrid.AllowUserToDeleteRows = false;
            this.produtoDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produtoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.produtoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CodProduto,
            this.Descricao,
            this.Marca,
            this.PrecoVenda,
            this.QuantidadeEstoque,
            this.Condicao,
            this.Situacao});
            this.produtoDataGrid.GridColor = System.Drawing.Color.SeaGreen;
            this.produtoDataGrid.Location = new System.Drawing.Point(15, 12);
            this.produtoDataGrid.Name = "produtoDataGrid";
            this.produtoDataGrid.ReadOnly = true;
            this.produtoDataGrid.RowHeadersWidth = 51;
            this.produtoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtoDataGrid.Size = new System.Drawing.Size(877, 451);
            this.produtoDataGrid.TabIndex = 89;
            this.produtoDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtoDataGrid_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 45.68528F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CodProduto
            // 
            this.CodProduto.FillWeight = 110.8629F;
            this.CodProduto.HeaderText = "CODIGO";
            this.CodProduto.MinimumWidth = 6;
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.FillWeight = 110.8629F;
            this.Descricao.HeaderText = "DESCRIÇÃO";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.FillWeight = 110.8629F;
            this.Marca.HeaderText = "MARCA";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.FillWeight = 110.8629F;
            this.PrecoVenda.HeaderText = "PREÇO VENDA";
            this.PrecoVenda.MinimumWidth = 6;
            this.PrecoVenda.Name = "PrecoVenda";
            this.PrecoVenda.ReadOnly = true;
            // 
            // QuantidadeEstoque
            // 
            this.QuantidadeEstoque.FillWeight = 110.8629F;
            this.QuantidadeEstoque.HeaderText = "QUANTIDADE ESTOQUE";
            this.QuantidadeEstoque.MinimumWidth = 6;
            this.QuantidadeEstoque.Name = "QuantidadeEstoque";
            this.QuantidadeEstoque.ReadOnly = true;
            // 
            // Condicao
            // 
            this.Condicao.FillWeight = 110.8629F;
            this.Condicao.HeaderText = "CONDIÇÃO";
            this.Condicao.MinimumWidth = 6;
            this.Condicao.Name = "Condicao";
            this.Condicao.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "SITUACAO";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Visible = false;
            // 
            // TelaProdutoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(904, 470);
            this.Controls.Add(this.produtoDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaProdutoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Produto Consulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaProdutoConsulta_FormClosing);
            this.Load += new System.EventHandler(this.TelaProdutoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView produtoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}