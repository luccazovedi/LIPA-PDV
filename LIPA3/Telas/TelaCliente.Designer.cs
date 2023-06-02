namespace LIPA3.Telas
{
    partial class TelaCliente
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
            this.excluirBtn = new System.Windows.Forms.Button();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.cpfLbl = new System.Windows.Forms.Label();
            this.rgLbl = new System.Windows.Forms.Label();
            this.cpfTxt = new System.Windows.Forms.TextBox();
            this.rgTxt = new System.Windows.Forms.TextBox();
            this.situacaoChk = new System.Windows.Forms.CheckBox();
            this.generoCmb = new System.Windows.Forms.ComboBox();
            this.generoLbl = new System.Windows.Forms.Label();
            this.dataNascimentoTxt = new System.Windows.Forms.DateTimePicker();
            this.dataNascimentoLbl = new System.Windows.Forms.Label();
            this.estadoCivilLbl = new System.Windows.Forms.Label();
            this.estadoCivilCmb = new System.Windows.Forms.ComboBox();
            this.profissaoTxt = new System.Windows.Forms.TextBox();
            this.profissaoLbl = new System.Windows.Forms.Label();
            this.nacionalidadeTxt = new System.Windows.Forms.TextBox();
            this.nacionalidadeLbl = new System.Windows.Forms.Label();
            this.telefoneTxt = new System.Windows.Forms.TextBox();
            this.telefoneLbl = new System.Windows.Forms.Label();
            this.celularTxt = new System.Windows.Forms.TextBox();
            this.celularLbl = new System.Windows.Forms.Label();
            this.whatsAppChk = new System.Windows.Forms.CheckBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.enderecoLbl = new System.Windows.Forms.Label();
            this.numeroTxt = new System.Windows.Forms.TextBox();
            this.numeroLbl = new System.Windows.Forms.Label();
            this.complementoTxt = new System.Windows.Forms.TextBox();
            this.complementoLbl = new System.Windows.Forms.Label();
            this.bairroTxt = new System.Windows.Forms.TextBox();
            this.bairroLbl = new System.Windows.Forms.Label();
            this.cidadeTxt = new System.Windows.Forms.TextBox();
            this.cidadeLbl = new System.Windows.Forms.Label();
            this.estadoTxt = new System.Windows.Forms.TextBox();
            this.estadoLbl = new System.Windows.Forms.Label();
            this.cepTxt = new System.Windows.Forms.TextBox();
            this.cepLbl = new System.Windows.Forms.Label();
            this.observacoesTxt = new System.Windows.Forms.TextBox();
            this.observacoesLbl = new System.Windows.Forms.Label();
            this.editarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.clienteDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.consultaTxt = new System.Windows.Forms.TextBox();
            this.consultaLbl = new System.Windows.Forms.Label();
            this.exibirBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // excluirBtn
            // 
            this.excluirBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.excluirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirBtn.ForeColor = System.Drawing.Color.White;
            this.excluirBtn.Location = new System.Drawing.Point(729, 362);
            this.excluirBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(180, 43);
            this.excluirBtn.TabIndex = 9;
            this.excluirBtn.Text = "EXCLUIR";
            this.excluirBtn.UseVisualStyleBackColor = false;
            this.excluirBtn.Click += new System.EventHandler(this.excluirBtn_Click);
            // 
            // nomeLbl
            // 
            this.nomeLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLbl.ForeColor = System.Drawing.Color.White;
            this.nomeLbl.Location = new System.Drawing.Point(16, 22);
            this.nomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(80, 25);
            this.nomeLbl.TabIndex = 8;
            this.nomeLbl.Text = "NOME";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nomeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.ForeColor = System.Drawing.Color.White;
            this.nomeTxt.Location = new System.Drawing.Point(20, 50);
            this.nomeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(465, 32);
            this.nomeTxt.TabIndex = 7;
            // 
            // salvarBtn
            // 
            this.salvarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.salvarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.ForeColor = System.Drawing.Color.White;
            this.salvarBtn.Location = new System.Drawing.Point(541, 362);
            this.salvarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(180, 43);
            this.salvarBtn.TabIndex = 6;
            this.salvarBtn.Text = "SALVAR";
            this.salvarBtn.UseVisualStyleBackColor = false;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // cpfLbl
            // 
            this.cpfLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLbl.ForeColor = System.Drawing.Color.White;
            this.cpfLbl.Location = new System.Drawing.Point(491, 22);
            this.cpfLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpfLbl.Name = "cpfLbl";
            this.cpfLbl.Size = new System.Drawing.Size(80, 25);
            this.cpfLbl.TabIndex = 12;
            this.cpfLbl.Text = "CPF";
            // 
            // rgLbl
            // 
            this.rgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgLbl.ForeColor = System.Drawing.Color.White;
            this.rgLbl.Location = new System.Drawing.Point(799, 22);
            this.rgLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgLbl.Name = "rgLbl";
            this.rgLbl.Size = new System.Drawing.Size(80, 25);
            this.rgLbl.TabIndex = 13;
            this.rgLbl.Text = "RG";
            // 
            // cpfTxt
            // 
            this.cpfTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cpfTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cpfTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTxt.ForeColor = System.Drawing.Color.White;
            this.cpfTxt.Location = new System.Drawing.Point(495, 50);
            this.cpfTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cpfTxt.Name = "cpfTxt";
            this.cpfTxt.Size = new System.Drawing.Size(299, 32);
            this.cpfTxt.TabIndex = 14;
            this.cpfTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // rgTxt
            // 
            this.rgTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rgTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rgTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rgTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTxt.ForeColor = System.Drawing.Color.White;
            this.rgTxt.Location = new System.Drawing.Point(803, 50);
            this.rgTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rgTxt.Name = "rgTxt";
            this.rgTxt.Size = new System.Drawing.Size(332, 32);
            this.rgTxt.TabIndex = 15;
            this.rgTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // situacaoChk
            // 
            this.situacaoChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.situacaoChk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoChk.ForeColor = System.Drawing.Color.White;
            this.situacaoChk.Location = new System.Drawing.Point(1144, 50);
            this.situacaoChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.situacaoChk.Name = "situacaoChk";
            this.situacaoChk.Size = new System.Drawing.Size(135, 33);
            this.situacaoChk.TabIndex = 16;
            this.situacaoChk.Text = "INATIVO";
            this.situacaoChk.UseVisualStyleBackColor = true;
            // 
            // generoCmb
            // 
            this.generoCmb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.generoCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoCmb.ForeColor = System.Drawing.Color.White;
            this.generoCmb.FormattingEnabled = true;
            this.generoCmb.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTRO"});
            this.generoCmb.Location = new System.Drawing.Point(20, 116);
            this.generoCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generoCmb.Name = "generoCmb";
            this.generoCmb.Size = new System.Drawing.Size(365, 33);
            this.generoCmb.TabIndex = 17;
            // 
            // generoLbl
            // 
            this.generoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoLbl.ForeColor = System.Drawing.Color.White;
            this.generoLbl.Location = new System.Drawing.Point(16, 87);
            this.generoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generoLbl.Name = "generoLbl";
            this.generoLbl.Size = new System.Drawing.Size(105, 25);
            this.generoLbl.TabIndex = 18;
            this.generoLbl.Text = "GÊNERO";
            // 
            // dataNascimentoTxt
            // 
            this.dataNascimentoTxt.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoTxt.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dataNascimentoTxt.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.dataNascimentoTxt.CalendarTitleBackColor = System.Drawing.Color.DarkSlateGray;
            this.dataNascimentoTxt.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dataNascimentoTxt.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateGray;
            this.dataNascimentoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoTxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNascimentoTxt.Location = new System.Drawing.Point(395, 114);
            this.dataNascimentoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataNascimentoTxt.Name = "dataNascimentoTxt";
            this.dataNascimentoTxt.Size = new System.Drawing.Size(260, 32);
            this.dataNascimentoTxt.TabIndex = 19;
            // 
            // dataNascimentoLbl
            // 
            this.dataNascimentoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNascimentoLbl.ForeColor = System.Drawing.Color.White;
            this.dataNascimentoLbl.Location = new System.Drawing.Point(391, 87);
            this.dataNascimentoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataNascimentoLbl.Name = "dataNascimentoLbl";
            this.dataNascimentoLbl.Size = new System.Drawing.Size(265, 25);
            this.dataNascimentoLbl.TabIndex = 20;
            this.dataNascimentoLbl.Text = "DATA DE NASCIMENTO";
            // 
            // estadoCivilLbl
            // 
            this.estadoCivilLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivilLbl.ForeColor = System.Drawing.Color.White;
            this.estadoCivilLbl.Location = new System.Drawing.Point(660, 87);
            this.estadoCivilLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoCivilLbl.Name = "estadoCivilLbl";
            this.estadoCivilLbl.Size = new System.Drawing.Size(175, 25);
            this.estadoCivilLbl.TabIndex = 22;
            this.estadoCivilLbl.Text = "ESTADO CIVIL";
            // 
            // estadoCivilCmb
            // 
            this.estadoCivilCmb.BackColor = System.Drawing.Color.DarkSlateGray;
            this.estadoCivilCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivilCmb.ForeColor = System.Drawing.Color.White;
            this.estadoCivilCmb.FormattingEnabled = true;
            this.estadoCivilCmb.Items.AddRange(new object[] {
            "SOLTEIRO",
            "CASADO",
            "VIÚVO"});
            this.estadoCivilCmb.Location = new System.Drawing.Point(664, 116);
            this.estadoCivilCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estadoCivilCmb.Name = "estadoCivilCmb";
            this.estadoCivilCmb.Size = new System.Drawing.Size(299, 33);
            this.estadoCivilCmb.TabIndex = 21;
            // 
            // profissaoTxt
            // 
            this.profissaoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.profissaoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.profissaoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profissaoTxt.ForeColor = System.Drawing.Color.White;
            this.profissaoTxt.Location = new System.Drawing.Point(977, 114);
            this.profissaoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profissaoTxt.Name = "profissaoTxt";
            this.profissaoTxt.Size = new System.Drawing.Size(299, 32);
            this.profissaoTxt.TabIndex = 24;
            // 
            // profissaoLbl
            // 
            this.profissaoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profissaoLbl.ForeColor = System.Drawing.Color.White;
            this.profissaoLbl.Location = new System.Drawing.Point(973, 86);
            this.profissaoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profissaoLbl.Name = "profissaoLbl";
            this.profissaoLbl.Size = new System.Drawing.Size(148, 25);
            this.profissaoLbl.TabIndex = 23;
            this.profissaoLbl.Text = "PROFISSÃO";
            // 
            // nacionalidadeTxt
            // 
            this.nacionalidadeTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nacionalidadeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nacionalidadeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacionalidadeTxt.ForeColor = System.Drawing.Color.White;
            this.nacionalidadeTxt.Location = new System.Drawing.Point(20, 180);
            this.nacionalidadeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nacionalidadeTxt.Name = "nacionalidadeTxt";
            this.nacionalidadeTxt.Size = new System.Drawing.Size(332, 32);
            this.nacionalidadeTxt.TabIndex = 26;
            // 
            // nacionalidadeLbl
            // 
            this.nacionalidadeLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacionalidadeLbl.ForeColor = System.Drawing.Color.White;
            this.nacionalidadeLbl.Location = new System.Drawing.Point(16, 151);
            this.nacionalidadeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nacionalidadeLbl.Name = "nacionalidadeLbl";
            this.nacionalidadeLbl.Size = new System.Drawing.Size(213, 25);
            this.nacionalidadeLbl.TabIndex = 25;
            this.nacionalidadeLbl.Text = "NACIONALIDADE";
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.telefoneTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefoneTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTxt.ForeColor = System.Drawing.Color.White;
            this.telefoneTxt.Location = new System.Drawing.Point(361, 180);
            this.telefoneTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(265, 32);
            this.telefoneTxt.TabIndex = 28;
            this.telefoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // telefoneLbl
            // 
            this.telefoneLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneLbl.ForeColor = System.Drawing.Color.White;
            this.telefoneLbl.Location = new System.Drawing.Point(357, 151);
            this.telefoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefoneLbl.Name = "telefoneLbl";
            this.telefoneLbl.Size = new System.Drawing.Size(136, 25);
            this.telefoneLbl.TabIndex = 27;
            this.telefoneLbl.Text = "TELEFONE";
            // 
            // celularTxt
            // 
            this.celularTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.celularTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.celularTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularTxt.ForeColor = System.Drawing.Color.White;
            this.celularTxt.Location = new System.Drawing.Point(636, 180);
            this.celularTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.celularTxt.Name = "celularTxt";
            this.celularTxt.Size = new System.Drawing.Size(265, 32);
            this.celularTxt.TabIndex = 30;
            this.celularTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // celularLbl
            // 
            this.celularLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularLbl.ForeColor = System.Drawing.Color.White;
            this.celularLbl.Location = new System.Drawing.Point(632, 151);
            this.celularLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.celularLbl.Name = "celularLbl";
            this.celularLbl.Size = new System.Drawing.Size(119, 25);
            this.celularLbl.TabIndex = 29;
            this.celularLbl.Text = "CELULAR";
            // 
            // whatsAppChk
            // 
            this.whatsAppChk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatsAppChk.ForeColor = System.Drawing.Color.White;
            this.whatsAppChk.Location = new System.Drawing.Point(911, 180);
            this.whatsAppChk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.whatsAppChk.Name = "whatsAppChk";
            this.whatsAppChk.Size = new System.Drawing.Size(177, 33);
            this.whatsAppChk.TabIndex = 31;
            this.whatsAppChk.Text = "WHATSAPP";
            this.whatsAppChk.UseVisualStyleBackColor = true;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.emailTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.White;
            this.emailTxt.Location = new System.Drawing.Point(20, 245);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(399, 32);
            this.emailTxt.TabIndex = 33;
            // 
            // emailLbl
            // 
            this.emailLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(16, 217);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(93, 25);
            this.emailLbl.TabIndex = 32;
            this.emailLbl.Text = "E-MAIL";
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.enderecoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTxt.ForeColor = System.Drawing.Color.White;
            this.enderecoTxt.Location = new System.Drawing.Point(428, 245);
            this.enderecoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(365, 32);
            this.enderecoTxt.TabIndex = 35;
            // 
            // enderecoLbl
            // 
            this.enderecoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoLbl.ForeColor = System.Drawing.Color.White;
            this.enderecoLbl.Location = new System.Drawing.Point(424, 217);
            this.enderecoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enderecoLbl.Name = "enderecoLbl";
            this.enderecoLbl.Size = new System.Drawing.Size(136, 25);
            this.enderecoLbl.TabIndex = 34;
            this.enderecoLbl.Text = "ENDEREÇO";
            // 
            // numeroTxt
            // 
            this.numeroTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.numeroTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.numeroTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTxt.ForeColor = System.Drawing.Color.White;
            this.numeroTxt.Location = new System.Drawing.Point(803, 245);
            this.numeroTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroTxt.Name = "numeroTxt";
            this.numeroTxt.Size = new System.Drawing.Size(132, 32);
            this.numeroTxt.TabIndex = 37;
            this.numeroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // numeroLbl
            // 
            this.numeroLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLbl.ForeColor = System.Drawing.Color.White;
            this.numeroLbl.Location = new System.Drawing.Point(799, 217);
            this.numeroLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeroLbl.Name = "numeroLbl";
            this.numeroLbl.Size = new System.Drawing.Size(113, 25);
            this.numeroLbl.TabIndex = 36;
            this.numeroLbl.Text = "NÚMERO";
            // 
            // complementoTxt
            // 
            this.complementoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.complementoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.complementoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementoTxt.ForeColor = System.Drawing.Color.White;
            this.complementoTxt.Location = new System.Drawing.Point(945, 245);
            this.complementoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complementoTxt.Name = "complementoTxt";
            this.complementoTxt.Size = new System.Drawing.Size(332, 32);
            this.complementoTxt.TabIndex = 39;
            // 
            // complementoLbl
            // 
            this.complementoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementoLbl.ForeColor = System.Drawing.Color.White;
            this.complementoLbl.Location = new System.Drawing.Point(941, 217);
            this.complementoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.complementoLbl.Name = "complementoLbl";
            this.complementoLbl.Size = new System.Drawing.Size(184, 25);
            this.complementoLbl.TabIndex = 38;
            this.complementoLbl.Text = "COMPLEMENTO";
            // 
            // bairroTxt
            // 
            this.bairroTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bairroTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bairroTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroTxt.ForeColor = System.Drawing.Color.White;
            this.bairroTxt.Location = new System.Drawing.Point(20, 321);
            this.bairroTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bairroTxt.Name = "bairroTxt";
            this.bairroTxt.Size = new System.Drawing.Size(332, 32);
            this.bairroTxt.TabIndex = 41;
            // 
            // bairroLbl
            // 
            this.bairroLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairroLbl.ForeColor = System.Drawing.Color.White;
            this.bairroLbl.Location = new System.Drawing.Point(16, 293);
            this.bairroLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bairroLbl.Name = "bairroLbl";
            this.bairroLbl.Size = new System.Drawing.Size(105, 25);
            this.bairroLbl.TabIndex = 40;
            this.bairroLbl.Text = "BAIRRO";
            // 
            // cidadeTxt
            // 
            this.cidadeTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cidadeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cidadeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeTxt.ForeColor = System.Drawing.Color.White;
            this.cidadeTxt.Location = new System.Drawing.Point(361, 321);
            this.cidadeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cidadeTxt.Name = "cidadeTxt";
            this.cidadeTxt.Size = new System.Drawing.Size(332, 32);
            this.cidadeTxt.TabIndex = 43;
            // 
            // cidadeLbl
            // 
            this.cidadeLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeLbl.ForeColor = System.Drawing.Color.White;
            this.cidadeLbl.Location = new System.Drawing.Point(357, 293);
            this.cidadeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cidadeLbl.Name = "cidadeLbl";
            this.cidadeLbl.Size = new System.Drawing.Size(97, 25);
            this.cidadeLbl.TabIndex = 42;
            this.cidadeLbl.Text = "CIDADE";
            // 
            // estadoTxt
            // 
            this.estadoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.estadoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.estadoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTxt.ForeColor = System.Drawing.Color.White;
            this.estadoTxt.Location = new System.Drawing.Point(701, 321);
            this.estadoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.estadoTxt.Name = "estadoTxt";
            this.estadoTxt.Size = new System.Drawing.Size(132, 32);
            this.estadoTxt.TabIndex = 45;
            // 
            // estadoLbl
            // 
            this.estadoLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoLbl.ForeColor = System.Drawing.Color.White;
            this.estadoLbl.Location = new System.Drawing.Point(697, 293);
            this.estadoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoLbl.Name = "estadoLbl";
            this.estadoLbl.Size = new System.Drawing.Size(103, 25);
            this.estadoLbl.TabIndex = 44;
            this.estadoLbl.Text = "ESTADO";
            // 
            // cepTxt
            // 
            this.cepTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cepTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cepTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepTxt.ForeColor = System.Drawing.Color.White;
            this.cepTxt.Location = new System.Drawing.Point(843, 321);
            this.cepTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cepTxt.Name = "cepTxt";
            this.cepTxt.Size = new System.Drawing.Size(199, 32);
            this.cepTxt.TabIndex = 47;
            this.cepTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // cepLbl
            // 
            this.cepLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cepLbl.ForeColor = System.Drawing.Color.White;
            this.cepLbl.Location = new System.Drawing.Point(843, 293);
            this.cepLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cepLbl.Name = "cepLbl";
            this.cepLbl.Size = new System.Drawing.Size(60, 25);
            this.cepLbl.TabIndex = 46;
            this.cepLbl.Text = "CEP";
            // 
            // observacoesTxt
            // 
            this.observacoesTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.observacoesTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacoesTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesTxt.ForeColor = System.Drawing.Color.White;
            this.observacoesTxt.Location = new System.Drawing.Point(1051, 321);
            this.observacoesTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.observacoesTxt.Multiline = true;
            this.observacoesTxt.Name = "observacoesTxt";
            this.observacoesTxt.Size = new System.Drawing.Size(232, 32);
            this.observacoesTxt.TabIndex = 49;
            // 
            // observacoesLbl
            // 
            this.observacoesLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesLbl.ForeColor = System.Drawing.Color.White;
            this.observacoesLbl.Location = new System.Drawing.Point(1047, 293);
            this.observacoesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observacoesLbl.Name = "observacoesLbl";
            this.observacoesLbl.Size = new System.Drawing.Size(185, 25);
            this.observacoesLbl.TabIndex = 48;
            this.observacoesLbl.Text = "OBSERVAÇÕES";
            // 
            // editarBtn
            // 
            this.editarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.ForeColor = System.Drawing.Color.White;
            this.editarBtn.Location = new System.Drawing.Point(917, 362);
            this.editarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(180, 43);
            this.editarBtn.TabIndex = 50;
            this.editarBtn.Text = "EDITAR";
            this.editarBtn.UseVisualStyleBackColor = false;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.limparBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparBtn.ForeColor = System.Drawing.Color.White;
            this.limparBtn.Location = new System.Drawing.Point(541, 412);
            this.limparBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(180, 43);
            this.limparBtn.TabIndex = 51;
            this.limparBtn.Text = "LIMPAR";
            this.limparBtn.UseVisualStyleBackColor = false;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // clienteDataGrid
            // 
            this.clienteDataGrid.AllowUserToAddRows = false;
            this.clienteDataGrid.AllowUserToDeleteRows = false;
            this.clienteDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteDataGrid.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.clienteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Cpf,
            this.Rg,
            this.Cidade,
            this.Estado});
            this.clienteDataGrid.GridColor = System.Drawing.Color.SeaGreen;
            this.clienteDataGrid.Location = new System.Drawing.Point(20, 468);
            this.clienteDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clienteDataGrid.Name = "clienteDataGrid";
            this.clienteDataGrid.ReadOnly = true;
            this.clienteDataGrid.RowHeadersWidth = 51;
            this.clienteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGrid.Size = new System.Drawing.Size(1264, 454);
            this.clienteDataGrid.TabIndex = 52;
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
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(729, 412);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(180, 43);
            this.btnConsultar.TabIndex = 53;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.consultarBtn_Click);
            // 
            // consultaTxt
            // 
            this.consultaTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.consultaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.consultaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaTxt.ForeColor = System.Drawing.Color.White;
            this.consultaTxt.Location = new System.Drawing.Point(20, 422);
            this.consultaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultaTxt.Name = "consultaTxt";
            this.consultaTxt.Size = new System.Drawing.Size(351, 32);
            this.consultaTxt.TabIndex = 57;
            this.consultaTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.consultaTxt_PreviewKeyDown);
            // 
            // consultaLbl
            // 
            this.consultaLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaLbl.ForeColor = System.Drawing.Color.White;
            this.consultaLbl.Location = new System.Drawing.Point(16, 394);
            this.consultaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.consultaLbl.Name = "consultaLbl";
            this.consultaLbl.Size = new System.Drawing.Size(371, 25);
            this.consultaLbl.TabIndex = 56;
            this.consultaLbl.Text = "[F1] CONSULTAR POR: NOME";
            // 
            // exibirBtn
            // 
            this.exibirBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.exibirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exibirBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibirBtn.ForeColor = System.Drawing.Color.White;
            this.exibirBtn.Location = new System.Drawing.Point(1105, 362);
            this.exibirBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exibirBtn.Name = "exibirBtn";
            this.exibirBtn.Size = new System.Drawing.Size(180, 43);
            this.exibirBtn.TabIndex = 58;
            this.exibirBtn.Text = "EXIBIR";
            this.exibirBtn.UseVisualStyleBackColor = false;
            this.exibirBtn.Click += new System.EventHandler(this.exibirBtn_Click);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1312, 937);
            this.Controls.Add(this.exibirBtn);
            this.Controls.Add(this.consultaTxt);
            this.Controls.Add(this.consultaLbl);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.clienteDataGrid);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.observacoesTxt);
            this.Controls.Add(this.observacoesLbl);
            this.Controls.Add(this.cepTxt);
            this.Controls.Add(this.cepLbl);
            this.Controls.Add(this.estadoTxt);
            this.Controls.Add(this.estadoLbl);
            this.Controls.Add(this.cidadeTxt);
            this.Controls.Add(this.cidadeLbl);
            this.Controls.Add(this.bairroTxt);
            this.Controls.Add(this.bairroLbl);
            this.Controls.Add(this.complementoTxt);
            this.Controls.Add(this.complementoLbl);
            this.Controls.Add(this.numeroTxt);
            this.Controls.Add(this.numeroLbl);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.enderecoLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.whatsAppChk);
            this.Controls.Add(this.celularTxt);
            this.Controls.Add(this.celularLbl);
            this.Controls.Add(this.telefoneTxt);
            this.Controls.Add(this.telefoneLbl);
            this.Controls.Add(this.nacionalidadeTxt);
            this.Controls.Add(this.nacionalidadeLbl);
            this.Controls.Add(this.profissaoTxt);
            this.Controls.Add(this.profissaoLbl);
            this.Controls.Add(this.estadoCivilLbl);
            this.Controls.Add(this.estadoCivilCmb);
            this.Controls.Add(this.dataNascimentoLbl);
            this.Controls.Add(this.dataNascimentoTxt);
            this.Controls.Add(this.generoLbl);
            this.Controls.Add(this.generoCmb);
            this.Controls.Add(this.situacaoChk);
            this.Controls.Add(this.rgTxt);
            this.Controls.Add(this.cpfTxt);
            this.Controls.Add(this.rgLbl);
            this.Controls.Add(this.cpfLbl);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.nomeLbl);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.salvarBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LAMBDA] Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCliente_FormClosing);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.consultaTxt_PreviewKeyDown);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Label cpfLbl;
        private System.Windows.Forms.Label rgLbl;
        private System.Windows.Forms.TextBox cpfTxt;
        private System.Windows.Forms.TextBox rgTxt;
        private System.Windows.Forms.CheckBox situacaoChk;
        private System.Windows.Forms.ComboBox generoCmb;
        private System.Windows.Forms.Label generoLbl;
        private System.Windows.Forms.DateTimePicker dataNascimentoTxt;
        private System.Windows.Forms.Label dataNascimentoLbl;
        private System.Windows.Forms.Label estadoCivilLbl;
        private System.Windows.Forms.ComboBox estadoCivilCmb;
        private System.Windows.Forms.TextBox profissaoTxt;
        private System.Windows.Forms.Label profissaoLbl;
        private System.Windows.Forms.TextBox nacionalidadeTxt;
        private System.Windows.Forms.Label nacionalidadeLbl;
        private System.Windows.Forms.TextBox telefoneTxt;
        private System.Windows.Forms.Label telefoneLbl;
        private System.Windows.Forms.TextBox celularTxt;
        private System.Windows.Forms.Label celularLbl;
        private System.Windows.Forms.CheckBox whatsAppChk;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.Label enderecoLbl;
        private System.Windows.Forms.TextBox numeroTxt;
        private System.Windows.Forms.Label numeroLbl;
        private System.Windows.Forms.TextBox complementoTxt;
        private System.Windows.Forms.Label complementoLbl;
        private System.Windows.Forms.TextBox bairroTxt;
        private System.Windows.Forms.Label bairroLbl;
        private System.Windows.Forms.TextBox cidadeTxt;
        private System.Windows.Forms.Label cidadeLbl;
        private System.Windows.Forms.TextBox estadoTxt;
        private System.Windows.Forms.Label estadoLbl;
        private System.Windows.Forms.TextBox cepTxt;
        private System.Windows.Forms.Label cepLbl;
        private System.Windows.Forms.TextBox observacoesTxt;
        private System.Windows.Forms.Label observacoesLbl;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.DataGridView clienteDataGrid;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox consultaTxt;
        private System.Windows.Forms.Label consultaLbl;
        private System.Windows.Forms.Button exibirBtn;
    }
}