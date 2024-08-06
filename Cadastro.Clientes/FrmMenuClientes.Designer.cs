namespace Cadastro.Clientes
{
    partial class FrmMenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFicha = new System.Windows.Forms.Button();
            this.btPdf = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoBD = new System.Windows.Forms.DataGridViewImageColumn();
            this.PesqCod = new System.Windows.Forms.GroupBox();
            this.PescInativo = new System.Windows.Forms.RadioButton();
            this.PescAtivo = new System.Windows.Forms.RadioButton();
            this.PescTodos = new System.Windows.Forms.RadioButton();
            this.PestEstCivil = new System.Windows.Forms.ComboBox();
            this.PesqGenero = new System.Windows.Forms.ComboBox();
            this.PesqEnderecos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PesqNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTotalLocalizado = new System.Windows.Forms.Label();
            this.LbTotalAtivo = new System.Windows.Forms.Label();
            this.LbTotalInativo = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.PesqCod.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btFicha);
            this.groupBox1.Controls.Add(this.btPdf);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Açôes";
            // 
            // btFicha
            // 
            this.btFicha.BackColor = System.Drawing.Color.Transparent;
            this.btFicha.FlatAppearance.BorderSize = 0;
            this.btFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFicha.Image = ((System.Drawing.Image)(resources.GetObject("btFicha.Image")));
            this.btFicha.Location = new System.Drawing.Point(164, 24);
            this.btFicha.Name = "btFicha";
            this.btFicha.Size = new System.Drawing.Size(47, 51);
            this.btFicha.TabIndex = 1;
            this.btFicha.UseVisualStyleBackColor = false;
            this.btFicha.Click += new System.EventHandler(this.btFicha_Click);
            // 
            // btPdf
            // 
            this.btPdf.BackColor = System.Drawing.Color.Transparent;
            this.btPdf.FlatAppearance.BorderSize = 0;
            this.btPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPdf.Image = ((System.Drawing.Image)(resources.GetObject("btPdf.Image")));
            this.btPdf.Location = new System.Drawing.Point(111, 24);
            this.btPdf.Name = "btPdf";
            this.btPdf.Size = new System.Drawing.Size(47, 51);
            this.btPdf.TabIndex = 1;
            this.btPdf.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.Location = new System.Drawing.Point(58, 24);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(47, 51);
            this.btEdit.TabIndex = 1;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgLista.ColumnHeadersHeight = 31;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.foto,
            this.nome,
            this.documento,
            this.genero,
            this.rg,
            this.estado_civil,
            this.nascimento,
            this.cep,
            this.endereco,
            this.numero,
            this.bairro,
            this.cidade,
            this.estado,
            this.celular,
            this.email,
            this.obs,
            this.situacao,
            this.fotoBD});
            this.dgLista.EnableHeadersVisualStyles = false;
            this.dgLista.GridColor = System.Drawing.Color.Gray;
            this.dgLista.Location = new System.Drawing.Point(12, 93);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersWidth = 4;
            this.dgLista.RowTemplate.Height = 30;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(1434, 684);
            this.dgLista.TabIndex = 1;
            this.dgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellClick);
            this.dgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellContentClick);
            this.dgLista.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseEnter);
            this.dgLista.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseLeave);
            this.dgLista.Sorted += new System.EventHandler(this.dgLista_Sorted);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 68;
            // 
            // foto
            // 
            this.foto.HeaderText = "foto";
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do Cliente";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 300;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.documento.DefaultCellStyle = dataGridViewCellStyle4;
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 175;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.genero.DefaultCellStyle = dataGridViewCellStyle5;
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 132;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rg.DefaultCellStyle = dataGridViewCellStyle6;
            this.rg.HeaderText = "RG/CPF";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 60;
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estado_civil.DefaultCellStyle = dataGridViewCellStyle7;
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.ReadOnly = true;
            this.estado_civil.Width = 150;
            // 
            // nascimento
            // 
            this.nascimento.DataPropertyName = "nascimento";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nascimento.DefaultCellStyle = dataGridViewCellStyle8;
            this.nascimento.HeaderText = "Nascimento";
            this.nascimento.Name = "nascimento";
            this.nascimento.ReadOnly = true;
            this.nascimento.Width = 120;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cep.DefaultCellStyle = dataGridViewCellStyle9;
            this.cep.HeaderText = "Cep";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.endereco.DefaultCellStyle = dataGridViewCellStyle10;
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 270;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 90;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 250;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 270;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 80;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.celular.DefaultCellStyle = dataGridViewCellStyle11;
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 159;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.email.DefaultCellStyle = dataGridViewCellStyle12;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Observação";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 150;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // fotoBD
            // 
            this.fotoBD.DataPropertyName = "fotoBD";
            this.fotoBD.HeaderText = "fotoBD";
            this.fotoBD.Name = "fotoBD";
            this.fotoBD.ReadOnly = true;
            this.fotoBD.Visible = false;
            // 
            // PesqCod
            // 
            this.PesqCod.BackColor = System.Drawing.Color.Transparent;
            this.PesqCod.Controls.Add(this.PescInativo);
            this.PesqCod.Controls.Add(this.PescAtivo);
            this.PesqCod.Controls.Add(this.PescTodos);
            this.PesqCod.Controls.Add(this.PestEstCivil);
            this.PesqCod.Controls.Add(this.PesqGenero);
            this.PesqCod.Controls.Add(this.PesqEnderecos);
            this.PesqCod.Controls.Add(this.label5);
            this.PesqCod.Controls.Add(this.PesqNome);
            this.PesqCod.Controls.Add(this.label1);
            this.PesqCod.Controls.Add(this.textCod);
            this.PesqCod.Controls.Add(this.label3);
            this.PesqCod.Controls.Add(this.label4);
            this.PesqCod.Controls.Add(this.label2);
            this.PesqCod.ForeColor = System.Drawing.Color.Silver;
            this.PesqCod.Location = new System.Drawing.Point(273, 4);
            this.PesqCod.Name = "PesqCod";
            this.PesqCod.Size = new System.Drawing.Size(1173, 96);
            this.PesqCod.TabIndex = 0;
            this.PesqCod.TabStop = false;
            this.PesqCod.Text = "Açôes e Consultas";
            this.PesqCod.Enter += new System.EventHandler(this.PesqCod_Enter);
            // 
            // PescInativo
            // 
            this.PescInativo.AutoSize = true;
            this.PescInativo.BackColor = System.Drawing.Color.Transparent;
            this.PescInativo.ForeColor = System.Drawing.Color.Red;
            this.PescInativo.Location = new System.Drawing.Point(1069, 64);
            this.PescInativo.Name = "PescInativo";
            this.PescInativo.Size = new System.Drawing.Size(82, 22);
            this.PescInativo.TabIndex = 7;
            this.PescInativo.Text = "Inativo";
            this.PescInativo.UseVisualStyleBackColor = false;
            this.PescInativo.CheckedChanged += new System.EventHandler(this.PescInativo_CheckedChanged);
            // 
            // PescAtivo
            // 
            this.PescAtivo.AutoSize = true;
            this.PescAtivo.BackColor = System.Drawing.Color.Transparent;
            this.PescAtivo.ForeColor = System.Drawing.Color.LawnGreen;
            this.PescAtivo.Location = new System.Drawing.Point(1069, 36);
            this.PescAtivo.Name = "PescAtivo";
            this.PescAtivo.Size = new System.Drawing.Size(66, 22);
            this.PescAtivo.TabIndex = 7;
            this.PescAtivo.Text = "Ativo";
            this.PescAtivo.UseVisualStyleBackColor = false;
            this.PescAtivo.CheckedChanged += new System.EventHandler(this.PescAtivo_CheckedChanged);
            // 
            // PescTodos
            // 
            this.PescTodos.AutoSize = true;
            this.PescTodos.BackColor = System.Drawing.Color.Transparent;
            this.PescTodos.Checked = true;
            this.PescTodos.Location = new System.Drawing.Point(1069, 8);
            this.PescTodos.Name = "PescTodos";
            this.PescTodos.Size = new System.Drawing.Size(66, 22);
            this.PescTodos.TabIndex = 7;
            this.PescTodos.TabStop = true;
            this.PescTodos.Text = "Todos";
            this.PescTodos.UseVisualStyleBackColor = false;
            this.PescTodos.CheckedChanged += new System.EventHandler(this.PescTodos_CheckedChanged);
            // 
            // PestEstCivil
            // 
            this.PestEstCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PestEstCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PestEstCivil.DropDownHeight = 200;
            this.PestEstCivil.FormattingEnabled = true;
            this.PestEstCivil.IntegralHeight = false;
            this.PestEstCivil.Items.AddRange(new object[] {
            "Solterio",
            "Casado",
            "Viuvo",
            "Separado"});
            this.PestEstCivil.Location = new System.Drawing.Point(409, 56);
            this.PestEstCivil.Name = "PestEstCivil";
            this.PestEstCivil.Size = new System.Drawing.Size(133, 26);
            this.PestEstCivil.TabIndex = 6;
            this.PestEstCivil.TextChanged += new System.EventHandler(this.textCod_TextChanged);
            // 
            // PesqGenero
            // 
            this.PesqGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesqGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PesqGenero.DropDownHeight = 200;
            this.PesqGenero.FormattingEnabled = true;
            this.PesqGenero.IntegralHeight = false;
            this.PesqGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.PesqGenero.Location = new System.Drawing.Point(260, 56);
            this.PesqGenero.Name = "PesqGenero";
            this.PesqGenero.Size = new System.Drawing.Size(131, 26);
            this.PesqGenero.TabIndex = 6;
            this.PesqGenero.TextChanged += new System.EventHandler(this.PesqNome_TextChanged);
            // 
            // PesqEnderecos
            // 
            this.PesqEnderecos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PesqEnderecos.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqEnderecos.Location = new System.Drawing.Point(568, 56);
            this.PesqEnderecos.Margin = new System.Windows.Forms.Padding(4);
            this.PesqEnderecos.Name = "PesqEnderecos";
            this.PesqEnderecos.Size = new System.Drawing.Size(159, 25);
            this.PesqEnderecos.TabIndex = 3;
            this.PesqEnderecos.TextChanged += new System.EventHandler(this.PesqNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(578, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereços Gerais";
            // 
            // PesqNome
            // 
            this.PesqNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PesqNome.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqNome.Location = new System.Drawing.Point(84, 57);
            this.PesqNome.Margin = new System.Windows.Forms.Padding(4);
            this.PesqNome.Name = "PesqNome";
            this.PesqNome.Size = new System.Drawing.Size(159, 25);
            this.PesqNome.TabIndex = 3;
            this.PesqNome.TextChanged += new System.EventHandler(this.PesqNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome/RG ou CPF";
            // 
            // textCod
            // 
            this.textCod.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCod.Location = new System.Drawing.Point(10, 57);
            this.textCod.Margin = new System.Windows.Forms.Padding(4);
            this.textCod.Name = "textCod";
            this.textCod.Size = new System.Drawing.Size(53, 25);
            this.textCod.TabIndex = 3;
            this.textCod.TextChanged += new System.EventHandler(this.textCod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(289, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(426, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado Civil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            // 
            // LbTotalLocalizado
            // 
            this.LbTotalLocalizado.AutoSize = true;
            this.LbTotalLocalizado.BackColor = System.Drawing.Color.Transparent;
            this.LbTotalLocalizado.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbTotalLocalizado.Location = new System.Drawing.Point(26, 789);
            this.LbTotalLocalizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTotalLocalizado.Name = "LbTotalLocalizado";
            this.LbTotalLocalizado.Size = new System.Drawing.Size(144, 18);
            this.LbTotalLocalizado.TabIndex = 2;
            this.LbTotalLocalizado.Text = "Total Localizado:";
            // 
            // LbTotalAtivo
            // 
            this.LbTotalAtivo.AutoSize = true;
            this.LbTotalAtivo.BackColor = System.Drawing.Color.Transparent;
            this.LbTotalAtivo.ForeColor = System.Drawing.Color.ForestGreen;
            this.LbTotalAtivo.Location = new System.Drawing.Point(354, 789);
            this.LbTotalAtivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTotalAtivo.Name = "LbTotalAtivo";
            this.LbTotalAtivo.Size = new System.Drawing.Size(112, 18);
            this.LbTotalAtivo.TabIndex = 2;
            this.LbTotalAtivo.Text = "Total Ativos:";
            this.LbTotalAtivo.Click += new System.EventHandler(this.LbTotalAtivo_Click);
            // 
            // LbTotalInativo
            // 
            this.LbTotalInativo.AllowDrop = true;
            this.LbTotalInativo.AutoSize = true;
            this.LbTotalInativo.BackColor = System.Drawing.Color.Transparent;
            this.LbTotalInativo.ForeColor = System.Drawing.Color.Crimson;
            this.LbTotalInativo.Location = new System.Drawing.Point(638, 789);
            this.LbTotalInativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbTotalInativo.Name = "LbTotalInativo";
            this.LbTotalInativo.Size = new System.Drawing.Size(120, 18);
            this.LbTotalInativo.TabIndex = 2;
            this.LbTotalInativo.Text = "Total Inativo:";
            this.LbTotalInativo.Click += new System.EventHandler(this.LbTotalInativo_Click);
            // 
            // labelAviso
            // 
            this.labelAviso.BackColor = System.Drawing.Color.White;
            this.labelAviso.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAviso.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAviso.Image = ((System.Drawing.Image)(resources.GetObject("labelAviso.Image")));
            this.labelAviso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAviso.Location = new System.Drawing.Point(12, 128);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.labelAviso.Size = new System.Drawing.Size(1434, 631);
            this.labelAviso.TabIndex = 3;
            this.labelAviso.Text = "Nada Encontrado...";
            this.labelAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAviso.Visible = false;
            this.labelAviso.MouseEnter += new System.EventHandler(this.labelAviso_MouseEnter);
            // 
            // FrmMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Cadastro.Clientes.Properties.Resources.gradiente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2770, 1061);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.PesqCod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbTotalInativo);
            this.Controls.Add(this.LbTotalAtivo);
            this.Controls.Add(this.LbTotalLocalizado);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Clientes";
            this.Load += new System.EventHandler(this.FrmMenuClientes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.PesqCod.ResumeLayout(false);
            this.PesqCod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btFicha;
        private System.Windows.Forms.Button btPdf;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.GroupBox PesqCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCod;
        private System.Windows.Forms.TextBox PesqNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PestEstCivil;
        private System.Windows.Forms.ComboBox PesqGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PesqEnderecos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton PescInativo;
        private System.Windows.Forms.RadioButton PescAtivo;
        private System.Windows.Forms.RadioButton PescTodos;
        private System.Windows.Forms.Label LbTotalLocalizado;
        private System.Windows.Forms.Label LbTotalAtivo;
        private System.Windows.Forms.Label LbTotalInativo;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewImageColumn fotoBD;
    }
}