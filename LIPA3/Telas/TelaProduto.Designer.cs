namespace LIPA3.Telas
{
    partial class TelaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProduto));
            this.sairBtn = new System.Windows.Forms.Button();
            this.descricaoLbl = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.situacaoChk = new System.Windows.Forms.CheckBox();
            this.codigoBarrasTxt = new System.Windows.Forms.TextBox();
            this.codigoBarrasLbl = new System.Windows.Forms.Label();
            this.marcaTxt = new System.Windows.Forms.TextBox();
            this.marcaLbl = new System.Windows.Forms.Label();
            this.pesoTxt = new System.Windows.Forms.TextBox();
            this.pesoLbl = new System.Windows.Forms.Label();
            this.larguraTxt = new System.Windows.Forms.TextBox();
            this.larguraLbl = new System.Windows.Forms.Label();
            this.alturaTxt = new System.Windows.Forms.TextBox();
            this.alturaLbl = new System.Windows.Forms.Label();
            this.profundidadeTxt = new System.Windows.Forms.TextBox();
            this.profundidadeLbl = new System.Windows.Forms.Label();
            this.novoRadBtn = new System.Windows.Forms.RadioButton();
            this.usadoRadBtn = new System.Windows.Forms.RadioButton();
            this.condicaoGrpBox = new System.Windows.Forms.GroupBox();
            this.precoVendaTxt = new System.Windows.Forms.TextBox();
            this.precoVendaLbl = new System.Windows.Forms.Label();
            this.quantidadeEstoqueTxt = new System.Windows.Forms.TextBox();
            this.quantidadeEstoqueLbl = new System.Windows.Forms.Label();
            this.exibirBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.produtoDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaTxt = new System.Windows.Forms.TextBox();
            this.consultaLbl = new System.Windows.Forms.Label();
            this.consultarBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.condicaoGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sairBtn
            // 
            this.sairBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sairBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairBtn.ForeColor = System.Drawing.Color.White;
            this.sairBtn.Location = new System.Drawing.Point(798, 12);
            this.sairBtn.Name = "sairBtn";
            this.sairBtn.Size = new System.Drawing.Size(91, 35);
            this.sairBtn.TabIndex = 60;
            this.sairBtn.Text = "SAIR";
            this.sairBtn.UseVisualStyleBackColor = false;
            this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
            // 
            // descricaoLbl
            // 
            this.descricaoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descricaoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoLbl.ForeColor = System.Drawing.Color.White;
            this.descricaoLbl.Location = new System.Drawing.Point(3, 7);
            this.descricaoLbl.Name = "descricaoLbl";
            this.descricaoLbl.Size = new System.Drawing.Size(111, 19);
            this.descricaoLbl.TabIndex = 62;
            this.descricaoLbl.Text = "DESCRIÇÃO";
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descricaoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.ForeColor = System.Drawing.Color.White;
            this.descricaoTxt.Location = new System.Drawing.Point(3, 29);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(256, 27);
            this.descricaoTxt.TabIndex = 1;
            // 
            // situacaoChk
            // 
            this.situacaoChk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoChk.ForeColor = System.Drawing.Color.White;
            this.situacaoChk.Location = new System.Drawing.Point(9, 12);
            this.situacaoChk.Name = "situacaoChk";
            this.situacaoChk.Size = new System.Drawing.Size(101, 27);
            this.situacaoChk.TabIndex = 3;
            this.situacaoChk.Text = "INATIVO";
            this.situacaoChk.UseVisualStyleBackColor = true;
            // 
            // codigoBarrasTxt
            // 
            this.codigoBarrasTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codigoBarrasTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codigoBarrasTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBarrasTxt.ForeColor = System.Drawing.Color.White;
            this.codigoBarrasTxt.Location = new System.Drawing.Point(9, 180);
            this.codigoBarrasTxt.Name = "codigoBarrasTxt";
            this.codigoBarrasTxt.Size = new System.Drawing.Size(180, 27);
            this.codigoBarrasTxt.TabIndex = 4;
            // 
            // codigoBarrasLbl
            // 
            this.codigoBarrasLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBarrasLbl.ForeColor = System.Drawing.Color.White;
            this.codigoBarrasLbl.Location = new System.Drawing.Point(9, 157);
            this.codigoBarrasLbl.Name = "codigoBarrasLbl";
            this.codigoBarrasLbl.Size = new System.Drawing.Size(180, 20);
            this.codigoBarrasLbl.TabIndex = 64;
            this.codigoBarrasLbl.Text = "CÓDIGO DE BARRAS";
            // 
            // marcaTxt
            // 
            this.marcaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.marcaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.marcaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaTxt.ForeColor = System.Drawing.Color.White;
            this.marcaTxt.Location = new System.Drawing.Point(195, 180);
            this.marcaTxt.Name = "marcaTxt";
            this.marcaTxt.Size = new System.Drawing.Size(200, 27);
            this.marcaTxt.TabIndex = 5;
            // 
            // marcaLbl
            // 
            this.marcaLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaLbl.ForeColor = System.Drawing.Color.White;
            this.marcaLbl.Location = new System.Drawing.Point(192, 157);
            this.marcaLbl.Name = "marcaLbl";
            this.marcaLbl.Size = new System.Drawing.Size(73, 20);
            this.marcaLbl.TabIndex = 66;
            this.marcaLbl.Text = "MARCA";
            // 
            // pesoTxt
            // 
            this.pesoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pesoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pesoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTxt.ForeColor = System.Drawing.Color.White;
            this.pesoTxt.Location = new System.Drawing.Point(9, 241);
            this.pesoTxt.Name = "pesoTxt";
            this.pesoTxt.Size = new System.Drawing.Size(120, 27);
            this.pesoTxt.TabIndex = 6;
            // 
            // pesoLbl
            // 
            this.pesoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoLbl.ForeColor = System.Drawing.Color.White;
            this.pesoLbl.Location = new System.Drawing.Point(6, 218);
            this.pesoLbl.Name = "pesoLbl";
            this.pesoLbl.Size = new System.Drawing.Size(57, 20);
            this.pesoLbl.TabIndex = 68;
            this.pesoLbl.Text = "PESO";
            // 
            // larguraTxt
            // 
            this.larguraTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.larguraTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.larguraTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.larguraTxt.ForeColor = System.Drawing.Color.White;
            this.larguraTxt.Location = new System.Drawing.Point(261, 241);
            this.larguraTxt.Name = "larguraTxt";
            this.larguraTxt.Size = new System.Drawing.Size(120, 27);
            this.larguraTxt.TabIndex = 8;
            // 
            // larguraLbl
            // 
            this.larguraLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.larguraLbl.ForeColor = System.Drawing.Color.White;
            this.larguraLbl.Location = new System.Drawing.Point(258, 218);
            this.larguraLbl.Name = "larguraLbl";
            this.larguraLbl.Size = new System.Drawing.Size(95, 20);
            this.larguraLbl.TabIndex = 70;
            this.larguraLbl.Text = "LARGURA";
            // 
            // alturaTxt
            // 
            this.alturaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alturaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.alturaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaTxt.ForeColor = System.Drawing.Color.White;
            this.alturaTxt.Location = new System.Drawing.Point(135, 241);
            this.alturaTxt.Name = "alturaTxt";
            this.alturaTxt.Size = new System.Drawing.Size(120, 27);
            this.alturaTxt.TabIndex = 7;
            // 
            // alturaLbl
            // 
            this.alturaLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaLbl.ForeColor = System.Drawing.Color.White;
            this.alturaLbl.Location = new System.Drawing.Point(132, 218);
            this.alturaLbl.Name = "alturaLbl";
            this.alturaLbl.Size = new System.Drawing.Size(95, 20);
            this.alturaLbl.TabIndex = 72;
            this.alturaLbl.Text = "ALTURA";
            // 
            // profundidadeTxt
            // 
            this.profundidadeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profundidadeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.profundidadeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profundidadeTxt.ForeColor = System.Drawing.Color.White;
            this.profundidadeTxt.Location = new System.Drawing.Point(387, 241);
            this.profundidadeTxt.Name = "profundidadeTxt";
            this.profundidadeTxt.Size = new System.Drawing.Size(134, 27);
            this.profundidadeTxt.TabIndex = 9;
            // 
            // profundidadeLbl
            // 
            this.profundidadeLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profundidadeLbl.ForeColor = System.Drawing.Color.White;
            this.profundidadeLbl.Location = new System.Drawing.Point(384, 218);
            this.profundidadeLbl.Name = "profundidadeLbl";
            this.profundidadeLbl.Size = new System.Drawing.Size(145, 20);
            this.profundidadeLbl.TabIndex = 74;
            this.profundidadeLbl.Text = "PROFUNDIDADE";
            // 
            // novoRadBtn
            // 
            this.novoRadBtn.AutoSize = true;
            this.novoRadBtn.Checked = true;
            this.novoRadBtn.Location = new System.Drawing.Point(6, 19);
            this.novoRadBtn.Name = "novoRadBtn";
            this.novoRadBtn.Size = new System.Drawing.Size(79, 22);
            this.novoRadBtn.TabIndex = 11;
            this.novoRadBtn.TabStop = true;
            this.novoRadBtn.Text = "NOVO";
            this.novoRadBtn.UseVisualStyleBackColor = true;
            // 
            // usadoRadBtn
            // 
            this.usadoRadBtn.AutoSize = true;
            this.usadoRadBtn.Location = new System.Drawing.Point(85, 19);
            this.usadoRadBtn.Name = "usadoRadBtn";
            this.usadoRadBtn.Size = new System.Drawing.Size(89, 22);
            this.usadoRadBtn.TabIndex = 12;
            this.usadoRadBtn.Text = "USADO";
            this.usadoRadBtn.UseVisualStyleBackColor = true;
            // 
            // condicaoGrpBox
            // 
            this.condicaoGrpBox.Controls.Add(this.novoRadBtn);
            this.condicaoGrpBox.Controls.Add(this.usadoRadBtn);
            this.condicaoGrpBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condicaoGrpBox.ForeColor = System.Drawing.Color.White;
            this.condicaoGrpBox.Location = new System.Drawing.Point(9, 45);
            this.condicaoGrpBox.Name = "condicaoGrpBox";
            this.condicaoGrpBox.Size = new System.Drawing.Size(185, 47);
            this.condicaoGrpBox.TabIndex = 78;
            this.condicaoGrpBox.TabStop = false;
            this.condicaoGrpBox.Text = "CONDIÇÃO";
            // 
            // precoVendaTxt
            // 
            this.precoVendaTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precoVendaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.precoVendaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.precoVendaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoVendaTxt.ForeColor = System.Drawing.Color.White;
            this.precoVendaTxt.Location = new System.Drawing.Point(265, 29);
            this.precoVendaTxt.Name = "precoVendaTxt";
            this.precoVendaTxt.Size = new System.Drawing.Size(130, 27);
            this.precoVendaTxt.TabIndex = 2;
            // 
            // precoVendaLbl
            // 
            this.precoVendaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.precoVendaLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoVendaLbl.ForeColor = System.Drawing.Color.White;
            this.precoVendaLbl.Location = new System.Drawing.Point(265, 6);
            this.precoVendaLbl.Name = "precoVendaLbl";
            this.precoVendaLbl.Size = new System.Drawing.Size(130, 20);
            this.precoVendaLbl.TabIndex = 79;
            this.precoVendaLbl.Text = "PREÇO VENDA";
            // 
            // quantidadeEstoqueTxt
            // 
            this.quantidadeEstoqueTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidadeEstoqueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantidadeEstoqueTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.quantidadeEstoqueTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeEstoqueTxt.ForeColor = System.Drawing.Color.White;
            this.quantidadeEstoqueTxt.Location = new System.Drawing.Point(401, 29);
            this.quantidadeEstoqueTxt.Name = "quantidadeEstoqueTxt";
            this.quantidadeEstoqueTxt.Size = new System.Drawing.Size(123, 27);
            this.quantidadeEstoqueTxt.TabIndex = 3;
            // 
            // quantidadeEstoqueLbl
            // 
            this.quantidadeEstoqueLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quantidadeEstoqueLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeEstoqueLbl.ForeColor = System.Drawing.Color.White;
            this.quantidadeEstoqueLbl.Location = new System.Drawing.Point(401, 6);
            this.quantidadeEstoqueLbl.Name = "quantidadeEstoqueLbl";
            this.quantidadeEstoqueLbl.Size = new System.Drawing.Size(119, 20);
            this.quantidadeEstoqueLbl.TabIndex = 81;
            this.quantidadeEstoqueLbl.Text = "QUANTIDADE ESTOQUE";
            // 
            // exibirBtn
            // 
            this.exibirBtn.BackColor = System.Drawing.Color.DimGray;
            this.exibirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exibirBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirBtn.ForeColor = System.Drawing.Color.White;
            this.exibirBtn.Location = new System.Drawing.Point(754, 200);
            this.exibirBtn.Name = "exibirBtn";
            this.exibirBtn.Size = new System.Drawing.Size(135, 35);
            this.exibirBtn.TabIndex = 16;
            this.exibirBtn.Text = "EXIBIR";
            this.exibirBtn.UseVisualStyleBackColor = false;
            this.exibirBtn.Click += new System.EventHandler(this.exibirBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.BackColor = System.Drawing.Color.DimGray;
            this.limparBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.ForeColor = System.Drawing.Color.White;
            this.limparBtn.Location = new System.Drawing.Point(754, 241);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(135, 35);
            this.limparBtn.TabIndex = 17;
            this.limparBtn.Text = "LIMPAR";
            this.limparBtn.UseVisualStyleBackColor = false;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.BackColor = System.Drawing.Color.DimGray;
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.ForeColor = System.Drawing.Color.White;
            this.editarBtn.Location = new System.Drawing.Point(754, 159);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(135, 35);
            this.editarBtn.TabIndex = 15;
            this.editarBtn.Text = "EDITAR";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.BackColor = System.Drawing.Color.DimGray;
            this.excluirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirBtn.ForeColor = System.Drawing.Color.White;
            this.excluirBtn.Location = new System.Drawing.Point(754, 118);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(135, 35);
            this.excluirBtn.TabIndex = 14;
            this.excluirBtn.Text = "EXCLUIR";
            this.excluirBtn.UseVisualStyleBackColor = false;
            this.excluirBtn.Click += new System.EventHandler(this.excluirBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarBtn.BackColor = System.Drawing.Color.DimGray;
            this.salvarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.ForeColor = System.Drawing.Color.White;
            this.salvarBtn.Location = new System.Drawing.Point(754, 77);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(135, 35);
            this.salvarBtn.TabIndex = 13;
            this.salvarBtn.Text = "SALVAR";
            this.salvarBtn.UseVisualStyleBackColor = false;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
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
            this.Descricao,
            this.Marca,
            this.PrecoVenda,
            this.QuantidadeEstoque,
            this.Condicao});
            this.produtoDataGrid.GridColor = System.Drawing.Color.SeaGreen;
            this.produtoDataGrid.Location = new System.Drawing.Point(12, 381);
            this.produtoDataGrid.Name = "produtoDataGrid";
            this.produtoDataGrid.ReadOnly = true;
            this.produtoDataGrid.RowHeadersWidth = 51;
            this.produtoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtoDataGrid.Size = new System.Drawing.Size(877, 369);
            this.produtoDataGrid.TabIndex = 88;
            this.produtoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtoDataGrid_CellContentClick);
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
            // consultaTxt
            // 
            this.consultaTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.consultaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.consultaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaTxt.ForeColor = System.Drawing.Color.White;
            this.consultaTxt.Location = new System.Drawing.Point(12, 346);
            this.consultaTxt.Name = "consultaTxt";
            this.consultaTxt.Size = new System.Drawing.Size(310, 27);
            this.consultaTxt.TabIndex = 10;
            this.consultaTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.consultaTxt_PreviewKeyDown);
            // 
            // consultaLbl
            // 
            this.consultaLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLbl.ForeColor = System.Drawing.Color.White;
            this.consultaLbl.Location = new System.Drawing.Point(9, 323);
            this.consultaLbl.Name = "consultaLbl";
            this.consultaLbl.Size = new System.Drawing.Size(313, 20);
            this.consultaLbl.TabIndex = 90;
            this.consultaLbl.Text = "[F1] CONSULTAR POR: DESCRIÇÃO";
            // 
            // consultarBtn
            // 
            this.consultarBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.consultarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarBtn.ForeColor = System.Drawing.Color.White;
            this.consultarBtn.Location = new System.Drawing.Point(328, 342);
            this.consultarBtn.Name = "consultarBtn";
            this.consultarBtn.Size = new System.Drawing.Size(135, 35);
            this.consultarBtn.TabIndex = 19;
            this.consultarBtn.Text = "CONSULTAR";
            this.consultarBtn.UseVisualStyleBackColor = false;
            this.consultarBtn.Click += new System.EventHandler(this.consultarBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.71537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.80645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28843F));
            this.tableLayoutPanel1.Controls.Add(this.descricaoTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.precoVendaTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.quantidadeEstoqueTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.descricaoLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.precoVendaLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.quantidadeEstoqueLbl, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 53);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(904, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.consultaTxt);
            this.Controls.Add(this.consultaLbl);
            this.Controls.Add(this.consultarBtn);
            this.Controls.Add(this.produtoDataGrid);
            this.Controls.Add(this.exibirBtn);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.condicaoGrpBox);
            this.Controls.Add(this.profundidadeTxt);
            this.Controls.Add(this.profundidadeLbl);
            this.Controls.Add(this.alturaTxt);
            this.Controls.Add(this.alturaLbl);
            this.Controls.Add(this.larguraTxt);
            this.Controls.Add(this.larguraLbl);
            this.Controls.Add(this.pesoTxt);
            this.Controls.Add(this.pesoLbl);
            this.Controls.Add(this.marcaTxt);
            this.Controls.Add(this.marcaLbl);
            this.Controls.Add(this.codigoBarrasTxt);
            this.Controls.Add(this.codigoBarrasLbl);
            this.Controls.Add(this.situacaoChk);
            this.Controls.Add(this.sairBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Produto";
            this.condicaoGrpBox.ResumeLayout(false);
            this.condicaoGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairBtn;
        private System.Windows.Forms.Label descricaoLbl;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.CheckBox situacaoChk;
        private System.Windows.Forms.TextBox codigoBarrasTxt;
        private System.Windows.Forms.Label codigoBarrasLbl;
        private System.Windows.Forms.TextBox marcaTxt;
        private System.Windows.Forms.Label marcaLbl;
        private System.Windows.Forms.TextBox pesoTxt;
        private System.Windows.Forms.Label pesoLbl;
        private System.Windows.Forms.TextBox larguraTxt;
        private System.Windows.Forms.Label larguraLbl;
        private System.Windows.Forms.TextBox alturaTxt;
        private System.Windows.Forms.Label alturaLbl;
        private System.Windows.Forms.TextBox profundidadeTxt;
        private System.Windows.Forms.Label profundidadeLbl;
        private System.Windows.Forms.RadioButton novoRadBtn;
        private System.Windows.Forms.RadioButton usadoRadBtn;
        private System.Windows.Forms.GroupBox condicaoGrpBox;
        private System.Windows.Forms.TextBox precoVendaTxt;
        private System.Windows.Forms.Label precoVendaLbl;
        private System.Windows.Forms.TextBox quantidadeEstoqueTxt;
        private System.Windows.Forms.Label quantidadeEstoqueLbl;
        private System.Windows.Forms.Button exibirBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.DataGridView produtoDataGrid;
        private System.Windows.Forms.TextBox consultaTxt;
        private System.Windows.Forms.Label consultaLbl;
        private System.Windows.Forms.Button consultarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}