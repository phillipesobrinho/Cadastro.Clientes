namespace Cadastro.Clientes
{
    partial class FrmCardCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCardCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.textBoxRg = new System.Windows.Forms.TextBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.BoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButtonSexoM = new System.Windows.Forms.RadioButton();
            this.radioButtonSexoF = new System.Windows.Forms.RadioButton();
            this.radioButtonOutros = new System.Windows.Forms.RadioButton();
            this.checkBoxCadastro = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNascimento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.ButtonCpf = new System.Windows.Forms.RadioButton();
            this.ButtonRg = new System.Windows.Forms.RadioButton();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.comboBoxEndereço = new System.Windows.Forms.ComboBox();
            this.comboBoxBairro = new System.Windows.Forms.ComboBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonphoto = new System.Windows.Forms.Button();
            this.buttonRemovePhoto = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(242, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(458, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(13, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(288, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(242, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(429, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estado Civil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(13, 465);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(492, 465);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(276, 585);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Celular";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(514, 585);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "E-mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(13, 700);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Observação";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(730, 585);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Situação Cadastral";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(830, 354);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nº";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(242, 62);
            this.Id.Margin = new System.Windows.Forms.Padding(4);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(154, 25);
            this.Id.TabIndex = 1;
            this.Id.TabStop = false;
            // 
            // textBoxRg
            // 
            this.textBoxRg.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRg.Location = new System.Drawing.Point(242, 277);
            this.textBoxRg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(154, 25);
            this.textBoxRg.TabIndex = 4;
            // 
            // textBoxObs
            // 
            this.textBoxObs.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObs.Location = new System.Drawing.Point(18, 730);
            this.textBoxObs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(934, 94);
            this.textBoxObs.TabIndex = 15;
            // 
            // BoxCliente
            // 
            this.BoxCliente.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxCliente.Location = new System.Drawing.Point(455, 62);
            this.BoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(479, 25);
            this.BoxCliente.TabIndex = 0;
            this.BoxCliente.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(509, 638);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(213, 25);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.Location = new System.Drawing.Point(806, 398);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(96, 25);
            this.textBoxNumero.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(711, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Data Nascismento";
            // 
            // radioButtonSexoM
            // 
            this.radioButtonSexoM.AutoSize = true;
            this.radioButtonSexoM.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSexoM.Location = new System.Drawing.Point(18, 36);
            this.radioButtonSexoM.Name = "radioButtonSexoM";
            this.radioButtonSexoM.Size = new System.Drawing.Size(98, 22);
            this.radioButtonSexoM.TabIndex = 3;
            this.radioButtonSexoM.TabStop = true;
            this.radioButtonSexoM.Text = "Masculino";
            this.radioButtonSexoM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButtonSexoM.UseVisualStyleBackColor = false;
            this.radioButtonSexoM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSexoF
            // 
            this.radioButtonSexoF.AutoSize = true;
            this.radioButtonSexoF.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSexoF.Location = new System.Drawing.Point(169, 36);
            this.radioButtonSexoF.Name = "radioButtonSexoF";
            this.radioButtonSexoF.Size = new System.Drawing.Size(90, 22);
            this.radioButtonSexoF.TabIndex = 4;
            this.radioButtonSexoF.TabStop = true;
            this.radioButtonSexoF.Text = "Feminino";
            this.radioButtonSexoF.UseVisualStyleBackColor = false;
            // 
            // radioButtonOutros
            // 
            this.radioButtonOutros.AutoSize = true;
            this.radioButtonOutros.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonOutros.Location = new System.Drawing.Point(327, 36);
            this.radioButtonOutros.Name = "radioButtonOutros";
            this.radioButtonOutros.Size = new System.Drawing.Size(74, 22);
            this.radioButtonOutros.TabIndex = 4;
            this.radioButtonOutros.TabStop = true;
            this.radioButtonOutros.Text = "Outros";
            this.radioButtonOutros.UseVisualStyleBackColor = false;
            // 
            // checkBoxCadastro
            // 
            this.checkBoxCadastro.AutoSize = true;
            this.checkBoxCadastro.Checked = true;
            this.checkBoxCadastro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCadastro.Location = new System.Drawing.Point(735, 641);
            this.checkBoxCadastro.Name = "checkBoxCadastro";
            this.checkBoxCadastro.Size = new System.Drawing.Size(67, 22);
            this.checkBoxCadastro.TabIndex = 5;
            this.checkBoxCadastro.Text = "Ativo";
            this.checkBoxCadastro.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(241, 167);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(205, 25);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBoxNascimento
            // 
            this.maskedTextBoxNascimento.BeepOnError = true;
            this.maskedTextBoxNascimento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxNascimento.Location = new System.Drawing.Point(716, 278);
            this.maskedTextBoxNascimento.Mask = "0000/00/00";
            this.maskedTextBoxNascimento.Name = "maskedTextBoxNascimento";
            this.maskedTextBoxNascimento.Size = new System.Drawing.Size(218, 25);
            this.maskedTextBoxNascimento.TabIndex = 6;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.BeepOnError = true;
            this.maskedTextBoxCep.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxCep.Location = new System.Drawing.Point(18, 398);
            this.maskedTextBoxCep.Mask = "00,000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(190, 25);
            this.maskedTextBoxCep.TabIndex = 7;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.BeepOnError = true;
            this.maskedTextBoxCelular.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(281, 635);
            this.maskedTextBoxCelular.Mask = "(99) 00000-0000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(190, 25);
            this.maskedTextBoxCelular.TabIndex = 13;
            // 
            // ButtonCpf
            // 
            this.ButtonCpf.AutoSize = true;
            this.ButtonCpf.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCpf.Location = new System.Drawing.Point(242, 122);
            this.ButtonCpf.Name = "ButtonCpf";
            this.ButtonCpf.Size = new System.Drawing.Size(50, 22);
            this.ButtonCpf.TabIndex = 1;
            this.ButtonCpf.TabStop = true;
            this.ButtonCpf.Text = "CPF";
            this.ButtonCpf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonCpf.UseVisualStyleBackColor = false;
            // 
            // ButtonRg
            // 
            this.ButtonRg.AutoSize = true;
            this.ButtonRg.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRg.Location = new System.Drawing.Point(321, 122);
            this.ButtonRg.Name = "ButtonRg";
            this.ButtonRg.Size = new System.Drawing.Size(42, 22);
            this.ButtonRg.TabIndex = 4;
            this.ButtonRg.TabStop = true;
            this.ButtonRg.Text = "RG";
            this.ButtonRg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonRg.UseVisualStyleBackColor = false;
            this.ButtonRg.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMain.Controls.Add(this.radioButtonSexoM);
            this.groupBoxMain.Controls.Add(this.radioButtonSexoF);
            this.groupBoxMain.Controls.Add(this.radioButtonOutros);
            this.groupBoxMain.Location = new System.Drawing.Point(479, 122);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(446, 85);
            this.groupBoxMain.TabIndex = 3;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 585);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEstado.DropDownHeight = 200;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.IntegralHeight = false;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.comboBoxEstado.Location = new System.Drawing.Point(18, 634);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(216, 26);
            this.comboBoxEstado.TabIndex = 12;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEstadoCivil.DropDownHeight = 200;
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.IntegralHeight = false;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Solterio",
            "Casado",
            "Viuvo",
            "Separado"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(455, 277);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(216, 26);
            this.comboBoxEstadoCivil.TabIndex = 5;
            // 
            // comboBoxEndereço
            // 
            this.comboBoxEndereço.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEndereço.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEndereço.DropDownHeight = 200;
            this.comboBoxEndereço.FormattingEnabled = true;
            this.comboBoxEndereço.IntegralHeight = false;
            this.comboBoxEndereço.Location = new System.Drawing.Point(281, 397);
            this.comboBoxEndereço.Name = "comboBoxEndereço";
            this.comboBoxEndereço.Size = new System.Drawing.Size(449, 26);
            this.comboBoxEndereço.TabIndex = 8;
            // 
            // comboBoxBairro
            // 
            this.comboBoxBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBairro.DropDownHeight = 200;
            this.comboBoxBairro.FormattingEnabled = true;
            this.comboBoxBairro.IntegralHeight = false;
            this.comboBoxBairro.Location = new System.Drawing.Point(18, 506);
            this.comboBoxBairro.Name = "comboBoxBairro";
            this.comboBoxBairro.Size = new System.Drawing.Size(416, 26);
            this.comboBoxBairro.TabIndex = 10;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCidade.DropDownHeight = 200;
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.IntegralHeight = false;
            this.comboBoxCidade.Location = new System.Drawing.Point(480, 506);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(454, 26);
            this.comboBoxCidade.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonphoto
            // 
            this.buttonphoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonphoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonphoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonphoto.Image = ((System.Drawing.Image)(resources.GetObject("buttonphoto.Image")));
            this.buttonphoto.Location = new System.Drawing.Point(18, 300);
            this.buttonphoto.Name = "buttonphoto";
            this.buttonphoto.Size = new System.Drawing.Size(124, 42);
            this.buttonphoto.TabIndex = 10;
            this.buttonphoto.TabStop = false;
            this.buttonphoto.Text = "Imagem";
            this.buttonphoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonphoto.UseVisualStyleBackColor = false;
            // 
            // buttonRemovePhoto
            // 
            this.buttonRemovePhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonRemovePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemovePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonRemovePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemovePhoto.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovePhoto.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemovePhoto.Image")));
            this.buttonRemovePhoto.Location = new System.Drawing.Point(148, 300);
            this.buttonRemovePhoto.Name = "buttonRemovePhoto";
            this.buttonRemovePhoto.Size = new System.Drawing.Size(70, 42);
            this.buttonRemovePhoto.TabIndex = 10;
            this.buttonRemovePhoto.TabStop = false;
            this.buttonRemovePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRemovePhoto.UseVisualStyleBackColor = false;
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(18, 874);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(124, 42);
            this.buttonFechar.TabIndex = 16;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFechar.UseVisualStyleBackColor = false;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Location = new System.Drawing.Point(191, 874);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(124, 42);
            this.buttonNovo.TabIndex = 17;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNovo.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(806, 874);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(124, 42);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(509, 874);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 48);
            this.button6.TabIndex = 19;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmCardCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cadastro.Clientes.Properties.Resources.gradiente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(971, 944);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonRemovePhoto);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.buttonphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.comboBoxBairro);
            this.Controls.Add(this.comboBoxEndereço);
            this.Controls.Add(this.comboBoxEstadoCivil);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.maskedTextBoxCelular);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.maskedTextBoxNascimento);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.checkBoxCadastro);
            this.Controls.Add(this.ButtonCpf);
            this.Controls.Add(this.ButtonRg);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxRg);
            this.Controls.Add(this.BoxCliente);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCardCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCardCliente_KeyDown);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox textBoxRg;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.TextBox BoxCliente;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButtonSexoM;
        private System.Windows.Forms.RadioButton radioButtonSexoF;
        private System.Windows.Forms.RadioButton radioButtonOutros;
        private System.Windows.Forms.CheckBox checkBoxCadastro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.RadioButton ButtonCpf;
        private System.Windows.Forms.RadioButton ButtonRg;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.ComboBox comboBoxEndereço;
        private System.Windows.Forms.ComboBox comboBoxBairro;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonphoto;
        private System.Windows.Forms.Button buttonRemovePhoto;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button button6;
    }
}

