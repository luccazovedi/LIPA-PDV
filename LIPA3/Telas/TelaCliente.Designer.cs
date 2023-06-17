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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
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
			this.sairBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.clienteDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// excluirBtn
			// 
			this.excluirBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.excluirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.excluirBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.excluirBtn.ForeColor = System.Drawing.Color.Transparent;
			this.excluirBtn.Location = new System.Drawing.Point(764, 248);
			this.excluirBtn.Name = "excluirBtn";
			this.excluirBtn.Size = new System.Drawing.Size(135, 38);
			this.excluirBtn.TabIndex = 23;
			this.excluirBtn.Text = "EXCLUIR";
			this.excluirBtn.UseVisualStyleBackColor = false;
			this.excluirBtn.Click += new System.EventHandler(this.excluirBtn_Click);
			// 
			// nomeLbl
			// 
			this.nomeLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomeLbl.ForeColor = System.Drawing.Color.White;
			this.nomeLbl.Location = new System.Drawing.Point(8, 44);
			this.nomeLbl.Name = "nomeLbl";
			this.nomeLbl.Size = new System.Drawing.Size(60, 20);
			this.nomeLbl.TabIndex = 8;
			this.nomeLbl.Text = "NOME";
			// 
			// nomeTxt
			// 
			this.nomeTxt.BackColor = System.Drawing.Color.Honeydew;
			this.nomeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.nomeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomeTxt.ForeColor = System.Drawing.Color.White;
			this.nomeTxt.Location = new System.Drawing.Point(11, 67);
			this.nomeTxt.Name = "nomeTxt";
			this.nomeTxt.Size = new System.Drawing.Size(326, 27);
			this.nomeTxt.TabIndex = 1;
			// 
			// salvarBtn
			// 
			this.salvarBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.salvarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.salvarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salvarBtn.ForeColor = System.Drawing.Color.Transparent;
			this.salvarBtn.Location = new System.Drawing.Point(764, 67);
			this.salvarBtn.Name = "salvarBtn";
			this.salvarBtn.Size = new System.Drawing.Size(135, 38);
			this.salvarBtn.TabIndex = 22;
			this.salvarBtn.Text = "SALVAR";
			this.salvarBtn.UseVisualStyleBackColor = false;
			this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
			// 
			// cpfLbl
			// 
			this.cpfLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpfLbl.ForeColor = System.Drawing.Color.White;
			this.cpfLbl.Location = new System.Drawing.Point(340, 44);
			this.cpfLbl.Name = "cpfLbl";
			this.cpfLbl.Size = new System.Drawing.Size(60, 20);
			this.cpfLbl.TabIndex = 12;
			this.cpfLbl.Text = "CPF";
			// 
			// rgLbl
			// 
			this.rgLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rgLbl.ForeColor = System.Drawing.Color.White;
			this.rgLbl.Location = new System.Drawing.Point(547, 44);
			this.rgLbl.Name = "rgLbl";
			this.rgLbl.Size = new System.Drawing.Size(60, 20);
			this.rgLbl.TabIndex = 13;
			this.rgLbl.Text = "RG";
			// 
			// cpfTxt
			// 
			this.cpfTxt.BackColor = System.Drawing.Color.Honeydew;
			this.cpfTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.cpfTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpfTxt.ForeColor = System.Drawing.Color.White;
			this.cpfTxt.Location = new System.Drawing.Point(340, 67);
			this.cpfTxt.Name = "cpfTxt";
			this.cpfTxt.Size = new System.Drawing.Size(200, 27);
			this.cpfTxt.TabIndex = 2;
			this.cpfTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
			// 
			// rgTxt
			// 
			this.rgTxt.BackColor = System.Drawing.Color.Honeydew;
			this.rgTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.rgTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rgTxt.ForeColor = System.Drawing.Color.White;
			this.rgTxt.Location = new System.Drawing.Point(546, 67);
			this.rgTxt.Name = "rgTxt";
			this.rgTxt.Size = new System.Drawing.Size(200, 27);
			this.rgTxt.TabIndex = 3;
			this.rgTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
			// 
			// situacaoChk
			// 
			this.situacaoChk.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.situacaoChk.ForeColor = System.Drawing.Color.White;
			this.situacaoChk.Location = new System.Drawing.Point(11, 8);
			this.situacaoChk.Name = "situacaoChk";
			this.situacaoChk.Size = new System.Drawing.Size(101, 27);
			this.situacaoChk.TabIndex = 4;
			this.situacaoChk.Text = "INATIVO";
			this.situacaoChk.UseVisualStyleBackColor = true;
			// 
			// generoCmb
			// 
			this.generoCmb.BackColor = System.Drawing.Color.Honeydew;
			this.generoCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generoCmb.ForeColor = System.Drawing.Color.White;
			this.generoCmb.FormattingEnabled = true;
			this.generoCmb.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTRO"});
			this.generoCmb.Location = new System.Drawing.Point(338, 122);
			this.generoCmb.Name = "generoCmb";
			this.generoCmb.Size = new System.Drawing.Size(202, 26);
			this.generoCmb.TabIndex = 5;
			// 
			// generoLbl
			// 
			this.generoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generoLbl.ForeColor = System.Drawing.Color.White;
			this.generoLbl.Location = new System.Drawing.Point(340, 99);
			this.generoLbl.Name = "generoLbl";
			this.generoLbl.Size = new System.Drawing.Size(79, 20);
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
			this.dataNascimentoTxt.Location = new System.Drawing.Point(546, 121);
			this.dataNascimentoTxt.Name = "dataNascimentoTxt";
			this.dataNascimentoTxt.Size = new System.Drawing.Size(200, 27);
			this.dataNascimentoTxt.TabIndex = 6;
			// 
			// dataNascimentoLbl
			// 
			this.dataNascimentoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataNascimentoLbl.ForeColor = System.Drawing.Color.White;
			this.dataNascimentoLbl.Location = new System.Drawing.Point(547, 98);
			this.dataNascimentoLbl.Name = "dataNascimentoLbl";
			this.dataNascimentoLbl.Size = new System.Drawing.Size(199, 20);
			this.dataNascimentoLbl.TabIndex = 20;
			this.dataNascimentoLbl.Text = "DATA DE NASCIMENTO";
			// 
			// estadoCivilLbl
			// 
			this.estadoCivilLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estadoCivilLbl.ForeColor = System.Drawing.Color.White;
			this.estadoCivilLbl.Location = new System.Drawing.Point(174, 157);
			this.estadoCivilLbl.Name = "estadoCivilLbl";
			this.estadoCivilLbl.Size = new System.Drawing.Size(131, 20);
			this.estadoCivilLbl.TabIndex = 22;
			this.estadoCivilLbl.Text = "ESTADO CIVIL";
			// 
			// estadoCivilCmb
			// 
			this.estadoCivilCmb.BackColor = System.Drawing.Color.Honeydew;
			this.estadoCivilCmb.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estadoCivilCmb.ForeColor = System.Drawing.Color.White;
			this.estadoCivilCmb.FormattingEnabled = true;
			this.estadoCivilCmb.Items.AddRange(new object[] {
            "SOLTEIRO",
            "CASADO",
            "VIÚVO"});
			this.estadoCivilCmb.Location = new System.Drawing.Point(174, 182);
			this.estadoCivilCmb.Name = "estadoCivilCmb";
			this.estadoCivilCmb.Size = new System.Drawing.Size(163, 26);
			this.estadoCivilCmb.TabIndex = 7;
			// 
			// profissaoTxt
			// 
			this.profissaoTxt.BackColor = System.Drawing.Color.Honeydew;
			this.profissaoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.profissaoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.profissaoTxt.ForeColor = System.Drawing.Color.White;
			this.profissaoTxt.Location = new System.Drawing.Point(338, 182);
			this.profissaoTxt.Name = "profissaoTxt";
			this.profissaoTxt.Size = new System.Drawing.Size(200, 27);
			this.profissaoTxt.TabIndex = 8;
			// 
			// profissaoLbl
			// 
			this.profissaoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.profissaoLbl.ForeColor = System.Drawing.Color.White;
			this.profissaoLbl.Location = new System.Drawing.Point(340, 157);
			this.profissaoLbl.Name = "profissaoLbl";
			this.profissaoLbl.Size = new System.Drawing.Size(111, 20);
			this.profissaoLbl.TabIndex = 23;
			this.profissaoLbl.Text = "PROFISSÃO";
			// 
			// nacionalidadeTxt
			// 
			this.nacionalidadeTxt.BackColor = System.Drawing.Color.Honeydew;
			this.nacionalidadeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.nacionalidadeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nacionalidadeTxt.ForeColor = System.Drawing.Color.White;
			this.nacionalidadeTxt.Location = new System.Drawing.Point(11, 181);
			this.nacionalidadeTxt.Name = "nacionalidadeTxt";
			this.nacionalidadeTxt.Size = new System.Drawing.Size(157, 27);
			this.nacionalidadeTxt.TabIndex = 9;
			// 
			// nacionalidadeLbl
			// 
			this.nacionalidadeLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nacionalidadeLbl.ForeColor = System.Drawing.Color.White;
			this.nacionalidadeLbl.Location = new System.Drawing.Point(8, 157);
			this.nacionalidadeLbl.Name = "nacionalidadeLbl";
			this.nacionalidadeLbl.Size = new System.Drawing.Size(160, 20);
			this.nacionalidadeLbl.TabIndex = 25;
			this.nacionalidadeLbl.Text = "NACIONALIDADE";
			// 
			// telefoneTxt
			// 
			this.telefoneTxt.BackColor = System.Drawing.Color.Honeydew;
			this.telefoneTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.telefoneTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefoneTxt.ForeColor = System.Drawing.Color.White;
			this.telefoneTxt.Location = new System.Drawing.Point(11, 241);
			this.telefoneTxt.Name = "telefoneTxt";
			this.telefoneTxt.Size = new System.Drawing.Size(198, 27);
			this.telefoneTxt.TabIndex = 10;
			this.telefoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
			// 
			// telefoneLbl
			// 
			this.telefoneLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefoneLbl.ForeColor = System.Drawing.Color.White;
			this.telefoneLbl.Location = new System.Drawing.Point(8, 218);
			this.telefoneLbl.Name = "telefoneLbl";
			this.telefoneLbl.Size = new System.Drawing.Size(102, 20);
			this.telefoneLbl.TabIndex = 27;
			this.telefoneLbl.Text = "TELEFONE";
			// 
			// celularTxt
			// 
			this.celularTxt.BackColor = System.Drawing.Color.Honeydew;
			this.celularTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.celularTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.celularTxt.ForeColor = System.Drawing.Color.White;
			this.celularTxt.Location = new System.Drawing.Point(544, 181);
			this.celularTxt.Name = "celularTxt";
			this.celularTxt.Size = new System.Drawing.Size(202, 27);
			this.celularTxt.TabIndex = 11;
			this.celularTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
			// 
			// celularLbl
			// 
			this.celularLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.celularLbl.ForeColor = System.Drawing.Color.White;
			this.celularLbl.Location = new System.Drawing.Point(551, 158);
			this.celularLbl.Name = "celularLbl";
			this.celularLbl.Size = new System.Drawing.Size(89, 20);
			this.celularLbl.TabIndex = 29;
			this.celularLbl.Text = "CELULAR";
			// 
			// whatsAppChk
			// 
			this.whatsAppChk.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.whatsAppChk.ForeColor = System.Drawing.Color.White;
			this.whatsAppChk.Location = new System.Drawing.Point(655, 155);
			this.whatsAppChk.Name = "whatsAppChk";
			this.whatsAppChk.Size = new System.Drawing.Size(101, 27);
			this.whatsAppChk.TabIndex = 12;
			this.whatsAppChk.Text = "WHATSAPP";
			this.whatsAppChk.UseVisualStyleBackColor = true;
			// 
			// emailTxt
			// 
			this.emailTxt.BackColor = System.Drawing.Color.Honeydew;
			this.emailTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.emailTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTxt.ForeColor = System.Drawing.Color.White;
			this.emailTxt.Location = new System.Drawing.Point(11, 122);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.Size = new System.Drawing.Size(326, 27);
			this.emailTxt.TabIndex = 13;
			// 
			// emailLbl
			// 
			this.emailLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLbl.ForeColor = System.Drawing.Color.White;
			this.emailLbl.Location = new System.Drawing.Point(8, 98);
			this.emailLbl.Name = "emailLbl";
			this.emailLbl.Size = new System.Drawing.Size(70, 20);
			this.emailLbl.TabIndex = 32;
			this.emailLbl.Text = "E-MAIL";
			// 
			// enderecoTxt
			// 
			this.enderecoTxt.BackColor = System.Drawing.Color.Honeydew;
			this.enderecoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.enderecoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enderecoTxt.ForeColor = System.Drawing.Color.White;
			this.enderecoTxt.Location = new System.Drawing.Point(368, 241);
			this.enderecoTxt.Name = "enderecoTxt";
			this.enderecoTxt.Size = new System.Drawing.Size(378, 27);
			this.enderecoTxt.TabIndex = 14;
			// 
			// enderecoLbl
			// 
			this.enderecoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.enderecoLbl.ForeColor = System.Drawing.Color.White;
			this.enderecoLbl.Location = new System.Drawing.Point(365, 218);
			this.enderecoLbl.Name = "enderecoLbl";
			this.enderecoLbl.Size = new System.Drawing.Size(218, 20);
			this.enderecoLbl.TabIndex = 34;
			this.enderecoLbl.Text = "LOGRADOURO";
			// 
			// numeroTxt
			// 
			this.numeroTxt.BackColor = System.Drawing.Color.Honeydew;
			this.numeroTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numeroTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeroTxt.ForeColor = System.Drawing.Color.White;
			this.numeroTxt.Location = new System.Drawing.Point(284, 296);
			this.numeroTxt.Name = "numeroTxt";
			this.numeroTxt.Size = new System.Drawing.Size(107, 27);
			this.numeroTxt.TabIndex = 15;
			this.numeroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
			// 
			// numeroLbl
			// 
			this.numeroLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numeroLbl.ForeColor = System.Drawing.Color.White;
			this.numeroLbl.Location = new System.Drawing.Point(281, 273);
			this.numeroLbl.Name = "numeroLbl";
			this.numeroLbl.Size = new System.Drawing.Size(85, 20);
			this.numeroLbl.TabIndex = 36;
			this.numeroLbl.Text = "NÚMERO";
			// 
			// complementoTxt
			// 
			this.complementoTxt.BackColor = System.Drawing.Color.Honeydew;
			this.complementoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.complementoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.complementoTxt.ForeColor = System.Drawing.Color.White;
			this.complementoTxt.Location = new System.Drawing.Point(11, 360);
			this.complementoTxt.Name = "complementoTxt";
			this.complementoTxt.Size = new System.Drawing.Size(229, 27);
			this.complementoTxt.TabIndex = 16;
			// 
			// complementoLbl
			// 
			this.complementoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.complementoLbl.ForeColor = System.Drawing.Color.White;
			this.complementoLbl.Location = new System.Drawing.Point(8, 337);
			this.complementoLbl.Name = "complementoLbl";
			this.complementoLbl.Size = new System.Drawing.Size(138, 20);
			this.complementoLbl.TabIndex = 38;
			this.complementoLbl.Text = "COMPLEMENTO";
			// 
			// bairroTxt
			// 
			this.bairroTxt.BackColor = System.Drawing.Color.Honeydew;
			this.bairroTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.bairroTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bairroTxt.ForeColor = System.Drawing.Color.White;
			this.bairroTxt.Location = new System.Drawing.Point(11, 296);
			this.bairroTxt.Name = "bairroTxt";
			this.bairroTxt.Size = new System.Drawing.Size(267, 27);
			this.bairroTxt.TabIndex = 17;
			// 
			// bairroLbl
			// 
			this.bairroLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bairroLbl.ForeColor = System.Drawing.Color.White;
			this.bairroLbl.Location = new System.Drawing.Point(8, 273);
			this.bairroLbl.Name = "bairroLbl";
			this.bairroLbl.Size = new System.Drawing.Size(84, 20);
			this.bairroLbl.TabIndex = 40;
			this.bairroLbl.Text = "BAIRRO";
			// 
			// cidadeTxt
			// 
			this.cidadeTxt.BackColor = System.Drawing.Color.Honeydew;
			this.cidadeTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.cidadeTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cidadeTxt.ForeColor = System.Drawing.Color.White;
			this.cidadeTxt.Location = new System.Drawing.Point(395, 296);
			this.cidadeTxt.Name = "cidadeTxt";
			this.cidadeTxt.Size = new System.Drawing.Size(245, 27);
			this.cidadeTxt.TabIndex = 18;
			// 
			// cidadeLbl
			// 
			this.cidadeLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cidadeLbl.ForeColor = System.Drawing.Color.White;
			this.cidadeLbl.Location = new System.Drawing.Point(392, 273);
			this.cidadeLbl.Name = "cidadeLbl";
			this.cidadeLbl.Size = new System.Drawing.Size(73, 20);
			this.cidadeLbl.TabIndex = 42;
			this.cidadeLbl.Text = "CIDADE";
			// 
			// estadoTxt
			// 
			this.estadoTxt.BackColor = System.Drawing.Color.Honeydew;
			this.estadoTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.estadoTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estadoTxt.ForeColor = System.Drawing.Color.White;
			this.estadoTxt.Location = new System.Drawing.Point(646, 296);
			this.estadoTxt.Name = "estadoTxt";
			this.estadoTxt.Size = new System.Drawing.Size(100, 27);
			this.estadoTxt.TabIndex = 19;
			// 
			// estadoLbl
			// 
			this.estadoLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estadoLbl.ForeColor = System.Drawing.Color.White;
			this.estadoLbl.Location = new System.Drawing.Point(643, 273);
			this.estadoLbl.Name = "estadoLbl";
			this.estadoLbl.Size = new System.Drawing.Size(77, 20);
			this.estadoLbl.TabIndex = 44;
			this.estadoLbl.Text = "ESTADO";
			// 
			// cepTxt
			// 
			this.cepTxt.BackColor = System.Drawing.Color.Honeydew;
			this.cepTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.cepTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cepTxt.ForeColor = System.Drawing.Color.White;
			this.cepTxt.Location = new System.Drawing.Point(212, 241);
			this.cepTxt.Name = "cepTxt";
			this.cepTxt.Size = new System.Drawing.Size(150, 27);
			this.cepTxt.TabIndex = 20;
			this.cepTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
			// 
			// cepLbl
			// 
			this.cepLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cepLbl.ForeColor = System.Drawing.Color.White;
			this.cepLbl.Location = new System.Drawing.Point(212, 218);
			this.cepLbl.Name = "cepLbl";
			this.cepLbl.Size = new System.Drawing.Size(45, 20);
			this.cepLbl.TabIndex = 46;
			this.cepLbl.Text = "CEP";
			// 
			// observacoesTxt
			// 
			this.observacoesTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.observacoesTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.observacoesTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.observacoesTxt.ForeColor = System.Drawing.Color.White;
			this.observacoesTxt.Location = new System.Drawing.Point(246, 360);
			this.observacoesTxt.Multiline = true;
			this.observacoesTxt.Name = "observacoesTxt";
			this.observacoesTxt.Size = new System.Drawing.Size(500, 27);
			this.observacoesTxt.TabIndex = 21;
			// 
			// observacoesLbl
			// 
			this.observacoesLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.observacoesLbl.ForeColor = System.Drawing.Color.White;
			this.observacoesLbl.Location = new System.Drawing.Point(243, 337);
			this.observacoesLbl.Name = "observacoesLbl";
			this.observacoesLbl.Size = new System.Drawing.Size(139, 20);
			this.observacoesLbl.TabIndex = 48;
			this.observacoesLbl.Text = "OBSERVAÇÕES";
			// 
			// editarBtn
			// 
			this.editarBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.editarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editarBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editarBtn.ForeColor = System.Drawing.Color.Transparent;
			this.editarBtn.Location = new System.Drawing.Point(764, 116);
			this.editarBtn.Name = "editarBtn";
			this.editarBtn.Size = new System.Drawing.Size(135, 38);
			this.editarBtn.TabIndex = 24;
			this.editarBtn.Text = "EDITAR";
			this.editarBtn.UseVisualStyleBackColor = false;
			this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
			// 
			// limparBtn
			// 
			this.limparBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.limparBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.limparBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.limparBtn.ForeColor = System.Drawing.Color.Transparent;
			this.limparBtn.Location = new System.Drawing.Point(764, 204);
			this.limparBtn.Name = "limparBtn";
			this.limparBtn.Size = new System.Drawing.Size(135, 38);
			this.limparBtn.TabIndex = 26;
			this.limparBtn.Text = "LIMPAR";
			this.limparBtn.UseVisualStyleBackColor = false;
			this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
			// 
			// clienteDataGrid
			// 
			this.clienteDataGrid.AllowUserToAddRows = false;
			this.clienteDataGrid.AllowUserToDeleteRows = false;
			this.clienteDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.clienteDataGrid.BackgroundColor = System.Drawing.Color.Honeydew;
			this.clienteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.clienteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Cpf,
            this.Rg,
            this.Cidade,
            this.Estado});
			this.clienteDataGrid.GridColor = System.Drawing.Color.SeaGreen;
			this.clienteDataGrid.Location = new System.Drawing.Point(11, 471);
			this.clienteDataGrid.Name = "clienteDataGrid";
			this.clienteDataGrid.ReadOnly = true;
			this.clienteDataGrid.RowHeadersWidth = 51;
			this.clienteDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.clienteDataGrid.Size = new System.Drawing.Size(883, 266);
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
			this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.Location = new System.Drawing.Point(284, 438);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(135, 27);
			this.btnConsultar.TabIndex = 28;
			this.btnConsultar.Text = "CONSULTAR";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.consultarBtn_Click);
			// 
			// consultaTxt
			// 
			this.consultaTxt.BackColor = System.Drawing.Color.Honeydew;
			this.consultaTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.consultaTxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultaTxt.ForeColor = System.Drawing.Color.White;
			this.consultaTxt.Location = new System.Drawing.Point(11, 438);
			this.consultaTxt.Name = "consultaTxt";
			this.consultaTxt.Size = new System.Drawing.Size(264, 27);
			this.consultaTxt.TabIndex = 27;
			this.consultaTxt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.consultaTxt_PreviewKeyDown);
			// 
			// consultaLbl
			// 
			this.consultaLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultaLbl.ForeColor = System.Drawing.Color.White;
			this.consultaLbl.Location = new System.Drawing.Point(8, 415);
			this.consultaLbl.Name = "consultaLbl";
			this.consultaLbl.Size = new System.Drawing.Size(278, 20);
			this.consultaLbl.TabIndex = 56;
			this.consultaLbl.Text = "[F1] CONSULTAR POR: NOME";
			// 
			// exibirBtn
			// 
			this.exibirBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.exibirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exibirBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exibirBtn.ForeColor = System.Drawing.Color.Transparent;
			this.exibirBtn.Location = new System.Drawing.Point(764, 160);
			this.exibirBtn.Name = "exibirBtn";
			this.exibirBtn.Size = new System.Drawing.Size(135, 38);
			this.exibirBtn.TabIndex = 25;
			this.exibirBtn.Text = "EXIBIR";
			this.exibirBtn.UseVisualStyleBackColor = false;
			this.exibirBtn.Click += new System.EventHandler(this.exibirBtn_Click);
			// 
			// sairBtn
			// 
			this.sairBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.sairBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sairBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sairBtn.ForeColor = System.Drawing.Color.Red;
			this.sairBtn.Location = new System.Drawing.Point(834, 8);
			this.sairBtn.Name = "sairBtn";
			this.sairBtn.Size = new System.Drawing.Size(65, 31);
			this.sairBtn.TabIndex = 59;
			this.sairBtn.Text = "SAIR";
			this.sairBtn.UseVisualStyleBackColor = false;
			this.sairBtn.Click += new System.EventHandler(this.sairBtn_Click);
			// 
			// TelaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(902, 749);
			this.Controls.Add(this.sairBtn);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "[LAMBDA] Cliente";
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.consultaTxt_PreviewKeyDown);
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
        private System.Windows.Forms.Button sairBtn;
    }
}