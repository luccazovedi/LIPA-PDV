namespace LIPA3.Telas
{
    partial class TelaVenda
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
            this.sairBtn = new System.Windows.Forms.Button();
            this.valorUnitarioTxt = new System.Windows.Forms.TextBox();
            this.valorUnitarioLbl = new System.Windows.Forms.Label();
            this.formaPagamentoLbl = new System.Windows.Forms.Label();
            this.formaPagamentoCmb = new System.Windows.Forms.ComboBox();
            this.produtoTxt = new System.Windows.Forms.TextBox();
            this.observacoesTxt = new System.Windows.Forms.TextBox();
            this.produtoLbl = new System.Windows.Forms.Label();
            this.observacoesLbl = new System.Windows.Forms.Label();
            this.clienteLbl = new System.Windows.Forms.Label();
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.clienteBtn = new System.Windows.Forms.Button();
            this.situacaoLbl = new System.Windows.Forms.Label();
            this.situacaoCmb = new System.Windows.Forms.ComboBox();
            this.quantidadeTxt = new System.Windows.Forms.TextBox();
            this.quantidadeLbl = new System.Windows.Forms.Label();
            this.subTotalProdutoTxt = new System.Windows.Forms.TextBox();
            this.subTotalProdutoLbl = new System.Windows.Forms.Label();
            this.produtoBtn = new System.Windows.Forms.Button();
            this.subTotalLbl = new System.Windows.Forms.Label();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.totalItensLbl = new System.Windows.Forms.Label();
            this.totalItensTxt = new System.Windows.Forms.TextBox();
            this.descontoLbl = new System.Windows.Forms.Label();
            this.descontoTxt = new System.Windows.Forms.TextBox();
            this.valorTotalLbl = new System.Windows.Forms.Label();
            this.valorTotalTxt = new System.Windows.Forms.TextBox();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.exibirBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.consultarBtn = new System.Windows.Forms.Button();
            this.vendaItensDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendaItensDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sairBtn
            // 
            this.sairBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairBtn.ForeColor = System.Drawing.Color.White;
            this.sairBtn.Location = new System.Drawing.Point(813, -3);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(91, 35);
            this.sairBtn.TabIndex = 61;
            this.sairBtn.Text = "SAIR";
            this.sairBtn.UseVisualStyleBackColor = false;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // valorUnitarioTxt
            // 
            this.valorUnitarioTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.valorUnitarioTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorUnitarioTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorUnitarioTxt.ForeColor = System.Drawing.Color.White;
            this.valorUnitarioTxt.Location = new System.Drawing.Point(703, 124);
            this.valorUnitarioTxt.Name = "valorUnitarioTxt";
            this.valorUnitarioTxt.Size = new System.Drawing.Size(160, 27);
            this.valorUnitarioTxt.TabIndex = 68;
            // 
            // valorUnitarioLbl
            // 
            this.valorUnitarioLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorUnitarioLbl.ForeColor = System.Drawing.Color.White;
            this.valorUnitarioLbl.Location = new System.Drawing.Point(699, 101);
            this.valorUnitarioLbl.Name = "valorUnitarioLbl";
            this.valorUnitarioLbl.Size = new System.Drawing.Size(160, 20);
            this.valorUnitarioLbl.TabIndex = 83;
            this.valorUnitarioLbl.Text = "VALOR UNITÁRIO";
            // 
            // formaPagamentoLbl
            // 
            this.formaPagamentoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamentoLbl.ForeColor = System.Drawing.Color.White;
            this.formaPagamentoLbl.Location = new System.Drawing.Point(407, 31);
            this.formaPagamentoLbl.Name = "formaPagamentoLbl";
            this.formaPagamentoLbl.Size = new System.Drawing.Size(184, 20);
            this.formaPagamentoLbl.TabIndex = 82;
            this.formaPagamentoLbl.Text = "FORMA PAGAMENTO";
            // 
            // formaPagamentoCmb
            // 
            this.formaPagamentoCmb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.formaPagamentoCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamentoCmb.ForeColor = System.Drawing.Color.White;
            this.formaPagamentoCmb.FormattingEnabled = true;
            this.formaPagamentoCmb.Items.AddRange(new object[] {
            "CARTÃO CRÉDITO",
            "CARTÃO DÉBITO",
            "DEPÓSITO",
            "DINHEIRO",
            "PIX"});
            this.formaPagamentoCmb.Location = new System.Drawing.Point(407, 54);
            this.formaPagamentoCmb.Name = "formaPagamentoCmb";
            this.formaPagamentoCmb.Size = new System.Drawing.Size(225, 26);
            this.formaPagamentoCmb.TabIndex = 67;
            // 
            // produtoTxt
            // 
            this.produtoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.produtoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.produtoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoTxt.ForeColor = System.Drawing.Color.White;
            this.produtoTxt.Location = new System.Drawing.Point(218, 124);
            this.produtoTxt.Name = "produtoTxt";
            this.produtoTxt.Size = new System.Drawing.Size(308, 27);
            this.produtoTxt.TabIndex = 64;
            // 
            // observacoesTxt
            // 
            this.observacoesTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.observacoesTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacoesTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesTxt.ForeColor = System.Drawing.Color.White;
            this.observacoesTxt.Location = new System.Drawing.Point(12, 124);
            this.observacoesTxt.Multiline = true;
            this.observacoesTxt.Name = "observacoesTxt";
            this.observacoesTxt.Size = new System.Drawing.Size(200, 54);
            this.observacoesTxt.TabIndex = 63;
            // 
            // produtoLbl
            // 
            this.produtoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoLbl.ForeColor = System.Drawing.Color.White;
            this.produtoLbl.Location = new System.Drawing.Point(218, 101);
            this.produtoLbl.Name = "produtoLbl";
            this.produtoLbl.Size = new System.Drawing.Size(91, 20);
            this.produtoLbl.TabIndex = 76;
            this.produtoLbl.Text = "PRODUTO";
            // 
            // observacoesLbl
            // 
            this.observacoesLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesLbl.ForeColor = System.Drawing.Color.White;
            this.observacoesLbl.Location = new System.Drawing.Point(9, 101);
            this.observacoesLbl.Name = "observacoesLbl";
            this.observacoesLbl.Size = new System.Drawing.Size(134, 20);
            this.observacoesLbl.TabIndex = 74;
            this.observacoesLbl.Text = "OBSERVAÇÕES";
            // 
            // clienteLbl
            // 
            this.clienteLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLbl.ForeColor = System.Drawing.Color.White;
            this.clienteLbl.Location = new System.Drawing.Point(9, 31);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(86, 20);
            this.clienteLbl.TabIndex = 69;
            this.clienteLbl.Text = "CLIENTE";
            // 
            // clienteTxt
            // 
            this.clienteTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clienteTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clienteTxt.Enabled = false;
            this.clienteTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteTxt.ForeColor = System.Drawing.Color.White;
            this.clienteTxt.Location = new System.Drawing.Point(12, 54);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.Size = new System.Drawing.Size(349, 27);
            this.clienteTxt.TabIndex = 62;
            // 
            // clienteBtn
            // 
            this.clienteBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.clienteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clienteBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteBtn.ForeColor = System.Drawing.Color.White;
            this.clienteBtn.Location = new System.Drawing.Point(367, 49);
            this.clienteBtn.Name = "clienteBtn";
            this.clienteBtn.Size = new System.Drawing.Size(34, 35);
            this.clienteBtn.TabIndex = 84;
            this.clienteBtn.Text = "C";
            this.clienteBtn.UseVisualStyleBackColor = false;
            this.clienteBtn.Click += new System.EventHandler(this.clienteBtn_Click);
            // 
            // situacaoLbl
            // 
            this.situacaoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoLbl.ForeColor = System.Drawing.Color.White;
            this.situacaoLbl.Location = new System.Drawing.Point(635, 31);
            this.situacaoLbl.Name = "situacaoLbl";
            this.situacaoLbl.Size = new System.Drawing.Size(99, 20);
            this.situacaoLbl.TabIndex = 86;
            this.situacaoLbl.Text = "SITUAÇÃO";
            // 
            // situacaoCmb
            // 
            this.situacaoCmb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.situacaoCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoCmb.ForeColor = System.Drawing.Color.White;
            this.situacaoCmb.FormattingEnabled = true;
            this.situacaoCmb.Items.AddRange(new object[] {
            "ABERTA",
            "PAGA",
            "FINALIZADA"});
            this.situacaoCmb.Location = new System.Drawing.Point(638, 54);
            this.situacaoCmb.Name = "situacaoCmb";
            this.situacaoCmb.Size = new System.Drawing.Size(225, 26);
            this.situacaoCmb.TabIndex = 85;
            // 
            // quantidadeTxt
            // 
            this.quantidadeTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.quantidadeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.quantidadeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeTxt.ForeColor = System.Drawing.Color.White;
            this.quantidadeTxt.Location = new System.Drawing.Point(572, 124);
            this.quantidadeTxt.Name = "quantidadeTxt";
            this.quantidadeTxt.Size = new System.Drawing.Size(121, 27);
            this.quantidadeTxt.TabIndex = 87;
            // 
            // quantidadeLbl
            // 
            this.quantidadeLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLbl.ForeColor = System.Drawing.Color.White;
            this.quantidadeLbl.Location = new System.Drawing.Point(571, 101);
            this.quantidadeLbl.Name = "quantidadeLbl";
            this.quantidadeLbl.Size = new System.Drawing.Size(122, 20);
            this.quantidadeLbl.TabIndex = 88;
            this.quantidadeLbl.Text = "QUANTIDADE";
            // 
            // subTotalProdutoTxt
            // 
            this.subTotalProdutoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subTotalProdutoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.subTotalProdutoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalProdutoTxt.ForeColor = System.Drawing.Color.White;
            this.subTotalProdutoTxt.Location = new System.Drawing.Point(571, 190);
            this.subTotalProdutoTxt.Name = "subTotalProdutoTxt";
            this.subTotalProdutoTxt.Size = new System.Drawing.Size(188, 27);
            this.subTotalProdutoTxt.TabIndex = 89;
            // 
            // subTotalProdutoLbl
            // 
            this.subTotalProdutoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalProdutoLbl.ForeColor = System.Drawing.Color.White;
            this.subTotalProdutoLbl.Location = new System.Drawing.Point(571, 169);
            this.subTotalProdutoLbl.Name = "subTotalProdutoLbl";
            this.subTotalProdutoLbl.Size = new System.Drawing.Size(188, 20);
            this.subTotalProdutoLbl.TabIndex = 90;
            this.subTotalProdutoLbl.Text = "SUBTOTAL PRODUTO";
            // 
            // produtoBtn
            // 
            this.produtoBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.produtoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produtoBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoBtn.ForeColor = System.Drawing.Color.White;
            this.produtoBtn.Location = new System.Drawing.Point(532, 120);
            this.produtoBtn.Name = "produtoBtn";
            this.produtoBtn.Size = new System.Drawing.Size(34, 35);
            this.produtoBtn.TabIndex = 91;
            this.produtoBtn.Text = "P";
            this.produtoBtn.UseVisualStyleBackColor = false;
            this.produtoBtn.Click += new System.EventHandler(this.produtoBtn_Click);
            // 
            // subTotalLbl
            // 
            this.subTotalLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLbl.ForeColor = System.Drawing.Color.White;
            this.subTotalLbl.Location = new System.Drawing.Point(132, 691);
            this.subTotalLbl.Name = "subTotalLbl";
            this.subTotalLbl.Size = new System.Drawing.Size(103, 20);
            this.subTotalLbl.TabIndex = 93;
            this.subTotalLbl.Text = "SUBTOTAL";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.subTotalTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.subTotalTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTxt.ForeColor = System.Drawing.Color.White;
            this.subTotalTxt.Location = new System.Drawing.Point(135, 714);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.Size = new System.Drawing.Size(109, 27);
            this.subTotalTxt.TabIndex = 92;
            // 
            // totalItensLbl
            // 
            this.totalItensLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItensLbl.ForeColor = System.Drawing.Color.White;
            this.totalItensLbl.Location = new System.Drawing.Point(9, 691);
            this.totalItensLbl.Name = "totalItensLbl";
            this.totalItensLbl.Size = new System.Drawing.Size(120, 20);
            this.totalItensLbl.TabIndex = 95;
            this.totalItensLbl.Text = "TOTAL ITENS";
            // 
            // totalItensTxt
            // 
            this.totalItensTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.totalItensTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.totalItensTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItensTxt.ForeColor = System.Drawing.Color.White;
            this.totalItensTxt.Location = new System.Drawing.Point(12, 714);
            this.totalItensTxt.Name = "totalItensTxt";
            this.totalItensTxt.Size = new System.Drawing.Size(117, 27);
            this.totalItensTxt.TabIndex = 94;
            // 
            // descontoLbl
            // 
            this.descontoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descontoLbl.ForeColor = System.Drawing.Color.White;
            this.descontoLbl.Location = new System.Drawing.Point(247, 691);
            this.descontoLbl.Name = "descontoLbl";
            this.descontoLbl.Size = new System.Drawing.Size(105, 20);
            this.descontoLbl.TabIndex = 97;
            this.descontoLbl.Text = "DESCONTO";
            // 
            // descontoTxt
            // 
            this.descontoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.descontoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descontoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descontoTxt.ForeColor = System.Drawing.Color.White;
            this.descontoTxt.Location = new System.Drawing.Point(250, 714);
            this.descontoTxt.Name = "descontoTxt";
            this.descontoTxt.Size = new System.Drawing.Size(111, 27);
            this.descontoTxt.TabIndex = 96;
            // 
            // valorTotalLbl
            // 
            this.valorTotalLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalLbl.ForeColor = System.Drawing.Color.White;
            this.valorTotalLbl.Location = new System.Drawing.Point(364, 691);
            this.valorTotalLbl.Name = "valorTotalLbl";
            this.valorTotalLbl.Size = new System.Drawing.Size(126, 20);
            this.valorTotalLbl.TabIndex = 99;
            this.valorTotalLbl.Text = "VALOR TOTAL";
            // 
            // valorTotalTxt
            // 
            this.valorTotalTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.valorTotalTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorTotalTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalTxt.ForeColor = System.Drawing.Color.White;
            this.valorTotalTxt.Location = new System.Drawing.Point(367, 714);
            this.valorTotalTxt.Name = "valorTotalTxt";
            this.valorTotalTxt.Size = new System.Drawing.Size(176, 27);
            this.valorTotalTxt.TabIndex = 98;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.adicionarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionarBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBtn.ForeColor = System.Drawing.Color.White;
            this.adicionarBtn.Location = new System.Drawing.Point(765, 186);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(34, 35);
            this.adicionarBtn.TabIndex = 100;
            this.adicionarBtn.Text = "+";
            this.adicionarBtn.UseVisualStyleBackColor = false;
            // 
            // removerBtn
            // 
            this.removerBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.removerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removerBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerBtn.ForeColor = System.Drawing.Color.White;
            this.removerBtn.Location = new System.Drawing.Point(805, 186);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(34, 35);
            this.removerBtn.TabIndex = 101;
            this.removerBtn.Text = "-";
            this.removerBtn.UseVisualStyleBackColor = false;
            // 
            // exibirBtn
            // 
            this.exibirBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.exibirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exibirBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirBtn.ForeColor = System.Drawing.Color.White;
            this.exibirBtn.Location = new System.Drawing.Point(86, 233);
            this.exibirBtn.Name = "exibirBtn";
            this.exibirBtn.Size = new System.Drawing.Size(135, 35);
            this.exibirBtn.TabIndex = 105;
            this.exibirBtn.Text = "EXIBIR";
            this.exibirBtn.UseVisualStyleBackColor = false;
            this.exibirBtn.Click += new System.EventHandler(this.exibirBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.limparBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.ForeColor = System.Drawing.Color.White;
            this.limparBtn.Location = new System.Drawing.Point(227, 233);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(135, 35);
            this.limparBtn.TabIndex = 106;
            this.limparBtn.Text = "LIMPAR";
            this.limparBtn.UseVisualStyleBackColor = false;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.ForeColor = System.Drawing.Color.White;
            this.editarBtn.Location = new System.Drawing.Point(294, 192);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(135, 35);
            this.editarBtn.TabIndex = 104;
            this.editarBtn.Text = "EDITAR";
            this.editarBtn.UseVisualStyleBackColor = false;
            // 
            // excluirBtn
            // 
            this.excluirBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.excluirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirBtn.ForeColor = System.Drawing.Color.White;
            this.excluirBtn.Location = new System.Drawing.Point(153, 192);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(135, 35);
            this.excluirBtn.TabIndex = 103;
            this.excluirBtn.Text = "EXCLUIR";
            this.excluirBtn.UseVisualStyleBackColor = false;
            this.excluirBtn.Click += new System.EventHandler(this.excluirBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.salvarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.ForeColor = System.Drawing.Color.White;
            this.salvarBtn.Location = new System.Drawing.Point(12, 192);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(135, 35);
            this.salvarBtn.TabIndex = 102;
            this.salvarBtn.Text = "SALVAR";
            this.salvarBtn.UseVisualStyleBackColor = false;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // consultarBtn
            // 
            this.consultarBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.consultarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarBtn.ForeColor = System.Drawing.Color.White;
            this.consultarBtn.Location = new System.Drawing.Point(368, 233);
            this.consultarBtn.Name = "consultarBtn";
            this.consultarBtn.Size = new System.Drawing.Size(135, 35);
            this.consultarBtn.TabIndex = 107;
            this.consultarBtn.Text = "CONSULTAR";
            this.consultarBtn.UseVisualStyleBackColor = false;
            this.consultarBtn.Click += new System.EventHandler(this.consultarBtn_Click);
            // 
            // vendaItensDataGrid
            // 
            this.vendaItensDataGrid.AllowUserToAddRows = false;
            this.vendaItensDataGrid.AllowUserToDeleteRows = false;
            this.vendaItensDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendaItensDataGrid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.vendaItensDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaItensDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descricao,
            this.Quantidade,
            this.ValorUnitario,
            this.SubTotal});
            this.vendaItensDataGrid.GridColor = System.Drawing.Color.SeaGreen;
            this.vendaItensDataGrid.Location = new System.Drawing.Point(12, 274);
            this.vendaItensDataGrid.Name = "vendaItensDataGrid";
            this.vendaItensDataGrid.ReadOnly = true;
            this.vendaItensDataGrid.RowHeadersWidth = 51;
            this.vendaItensDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendaItensDataGrid.Size = new System.Drawing.Size(877, 400);
            this.vendaItensDataGrid.TabIndex = 108;
            // 
            // ID
            // 
            this.ID.FillWeight = 45.68528F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.FillWeight = 110.8629F;
            this.Descricao.HeaderText = "DESCRIÇÃO";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.FillWeight = 110.8629F;
            this.Quantidade.HeaderText = "QUANTIDADE";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.FillWeight = 110.8629F;
            this.ValorUnitario.HeaderText = "VALOR UNITÁRIO";
            this.ValorUnitario.MinimumWidth = 6;
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.FillWeight = 110.8629F;
            this.SubTotal.HeaderText = "SUBTOTAL";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(904, 762);
            this.Controls.Add(this.vendaItensDataGrid);
            this.Controls.Add(this.consultarBtn);
            this.Controls.Add(this.exibirBtn);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.removerBtn);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.valorTotalLbl);
            this.Controls.Add(this.valorTotalTxt);
            this.Controls.Add(this.descontoLbl);
            this.Controls.Add(this.descontoTxt);
            this.Controls.Add(this.totalItensLbl);
            this.Controls.Add(this.totalItensTxt);
            this.Controls.Add(this.subTotalLbl);
            this.Controls.Add(this.subTotalTxt);
            this.Controls.Add(this.produtoBtn);
            this.Controls.Add(this.subTotalProdutoTxt);
            this.Controls.Add(this.subTotalProdutoLbl);
            this.Controls.Add(this.quantidadeTxt);
            this.Controls.Add(this.quantidadeLbl);
            this.Controls.Add(this.situacaoLbl);
            this.Controls.Add(this.situacaoCmb);
            this.Controls.Add(this.clienteBtn);
            this.Controls.Add(this.valorUnitarioTxt);
            this.Controls.Add(this.valorUnitarioLbl);
            this.Controls.Add(this.formaPagamentoLbl);
            this.Controls.Add(this.formaPagamentoCmb);
            this.Controls.Add(this.produtoTxt);
            this.Controls.Add(this.observacoesTxt);
            this.Controls.Add(this.produtoLbl);
            this.Controls.Add(this.observacoesLbl);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.clienteTxt);
            this.Controls.Add(this.sairBtn);
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Venda";
            ((System.ComponentModel.ISupportInitialize)(this.vendaItensDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.TextBox valorUnitarioTxt;
        private System.Windows.Forms.Label valorUnitarioLbl;
        private System.Windows.Forms.Label formaPagamentoLbl;
        private System.Windows.Forms.ComboBox formaPagamentoCmb;
        private System.Windows.Forms.TextBox produtoTxt;
        private System.Windows.Forms.TextBox observacoesTxt;
        private System.Windows.Forms.Label produtoLbl;
        private System.Windows.Forms.Label observacoesLbl;
        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.Button clienteBtn;
        private System.Windows.Forms.Label situacaoLbl;
        private System.Windows.Forms.ComboBox situacaoCmb;
        private System.Windows.Forms.TextBox quantidadeTxt;
        private System.Windows.Forms.Label quantidadeLbl;
        private System.Windows.Forms.TextBox subTotalProdutoTxt;
        private System.Windows.Forms.Label subTotalProdutoLbl;
        private System.Windows.Forms.Button produtoBtn;
        private System.Windows.Forms.Label subTotalLbl;
        private System.Windows.Forms.TextBox subTotalTxt;
        private System.Windows.Forms.Label totalItensLbl;
        private System.Windows.Forms.TextBox totalItensTxt;
        private System.Windows.Forms.Label descontoLbl;
        private System.Windows.Forms.TextBox descontoTxt;
        private System.Windows.Forms.Label valorTotalLbl;
        private System.Windows.Forms.TextBox valorTotalTxt;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.Button exibirBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button consultarBtn;
        private System.Windows.Forms.DataGridView vendaItensDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}