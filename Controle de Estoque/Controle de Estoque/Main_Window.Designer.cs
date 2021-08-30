namespace Controle_de_Estoque
{
    partial class F_Menu
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
            this.grid_Listas = new System.Windows.Forms.DataGridView();
            this.ID_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faixa_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faixa_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_NovaLista = new System.Windows.Forms.ComboBox();
            this.tab_Estoque = new System.Windows.Forms.TabPage();
            this.bt_salvardb = new System.Windows.Forms.Button();
            this.tab_Cadastro = new System.Windows.Forms.TabPage();
            this.Abas_2 = new System.Windows.Forms.TabControl();
            this.tab_ModeloExistente = new System.Windows.Forms.TabPage();
            this.group_incluirestoque = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.list_Cor = new System.Windows.Forms.ComboBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.list_Modelo = new System.Windows.Forms.ComboBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.list_Numeracao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_NovoModelo = new System.Windows.Forms.TabPage();
            this.group_AddModelo = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_AdicionarModelo = new System.Windows.Forms.Button();
            this.lbl_NomeNovoModelo = new System.Windows.Forms.Label();
            this.txt_NomeNovoModelo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumFaixa_FINAL = new System.Windows.Forms.NumericUpDown();
            this.NumFaixa_INICIAL = new System.Windows.Forms.NumericUpDown();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_Ate = new System.Windows.Forms.Label();
            this.lbl_privilegio = new System.Windows.Forms.Label();
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rd_gerente = new System.Windows.Forms.RadioButton();
            this.rd_estoquista = new System.Windows.Forms.RadioButton();
            this.group_entrarcomo = new System.Windows.Forms.GroupBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_passenter = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Listas)).BeginInit();
            this.tab_Estoque.SuspendLayout();
            this.tab_Cadastro.SuspendLayout();
            this.Abas_2.SuspendLayout();
            this.tab_ModeloExistente.SuspendLayout();
            this.group_incluirestoque.SuspendLayout();
            this.tab_NovoModelo.SuspendLayout();
            this.group_AddModelo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).BeginInit();
            this.AllTabs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.group_entrarcomo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Listas
            // 
            this.grid_Listas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Listas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Lista,
            this.Login_Nome,
            this.Login_Senha,
            this.Nome_Lista,
            this.col_faixa_inicial,
            this.col_faixa_final});
            this.grid_Listas.Location = new System.Drawing.Point(0, 534);
            this.grid_Listas.Name = "grid_Listas";
            this.grid_Listas.Size = new System.Drawing.Size(227, 56);
            this.grid_Listas.TabIndex = 18;
            this.grid_Listas.Visible = false;
            this.grid_Listas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Listas_CellContentClick);
            // 
            // ID_Lista
            // 
            this.ID_Lista.HeaderText = "ID_Lista";
            this.ID_Lista.Name = "ID_Lista";
            // 
            // Login_Nome
            // 
            this.Login_Nome.HeaderText = "Login_Nome";
            this.Login_Nome.Name = "Login_Nome";
            // 
            // Login_Senha
            // 
            this.Login_Senha.HeaderText = "Login_Senha";
            this.Login_Senha.Name = "Login_Senha";
            // 
            // Nome_Lista
            // 
            this.Nome_Lista.HeaderText = "Nome_Lista";
            this.Nome_Lista.Name = "Nome_Lista";
            // 
            // col_faixa_inicial
            // 
            this.col_faixa_inicial.HeaderText = "col_faixa_inicial";
            this.col_faixa_inicial.Name = "col_faixa_inicial";
            // 
            // col_faixa_final
            // 
            this.col_faixa_final.HeaderText = "col_faixa_final";
            this.col_faixa_final.Name = "col_faixa_final";
            // 
            // list_NovaLista
            // 
            this.list_NovaLista.FormattingEnabled = true;
            this.list_NovaLista.Location = new System.Drawing.Point(233, 569);
            this.list_NovaLista.Name = "list_NovaLista";
            this.list_NovaLista.Size = new System.Drawing.Size(197, 21);
            this.list_NovaLista.TabIndex = 17;
            this.list_NovaLista.TabStop = false;
            this.list_NovaLista.Visible = false;
            this.list_NovaLista.SelectedIndexChanged += new System.EventHandler(this.list_NovaLista_SelectedIndexChanged);
            // 
            // tab_Estoque
            // 
            this.tab_Estoque.Controls.Add(this.dataGridView1);
            this.tab_Estoque.Controls.Add(this.bt_salvardb);
            this.tab_Estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_Estoque.Name = "tab_Estoque";
            this.tab_Estoque.Size = new System.Drawing.Size(398, 360);
            this.tab_Estoque.TabIndex = 3;
            this.tab_Estoque.Text = "Estoque";
            this.tab_Estoque.UseVisualStyleBackColor = true;
            // 
            // bt_salvardb
            // 
            this.bt_salvardb.Location = new System.Drawing.Point(30, 307);
            this.bt_salvardb.Name = "bt_salvardb";
            this.bt_salvardb.Size = new System.Drawing.Size(343, 33);
            this.bt_salvardb.TabIndex = 18;
            this.bt_salvardb.Text = "Salvar alterações";
            this.bt_salvardb.UseVisualStyleBackColor = true;
            this.bt_salvardb.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tab_Cadastro
            // 
            this.tab_Cadastro.Controls.Add(this.Abas_2);
            this.tab_Cadastro.Controls.Add(this.lbl_privilegio);
            this.tab_Cadastro.Location = new System.Drawing.Point(4, 22);
            this.tab_Cadastro.Name = "tab_Cadastro";
            this.tab_Cadastro.Size = new System.Drawing.Size(398, 360);
            this.tab_Cadastro.TabIndex = 0;
            this.tab_Cadastro.Text = "Cadastro";
            this.tab_Cadastro.UseVisualStyleBackColor = true;
            this.tab_Cadastro.Click += new System.EventHandler(this.tab_Cadastro_Click);
            // 
            // Abas_2
            // 
            this.Abas_2.Controls.Add(this.tab_ModeloExistente);
            this.Abas_2.Controls.Add(this.tab_NovoModelo);
            this.Abas_2.Location = new System.Drawing.Point(2, 12);
            this.Abas_2.Name = "Abas_2";
            this.Abas_2.SelectedIndex = 0;
            this.Abas_2.Size = new System.Drawing.Size(393, 348);
            this.Abas_2.TabIndex = 16;
            // 
            // tab_ModeloExistente
            // 
            this.tab_ModeloExistente.Controls.Add(this.group_incluirestoque);
            this.tab_ModeloExistente.Location = new System.Drawing.Point(4, 22);
            this.tab_ModeloExistente.Name = "tab_ModeloExistente";
            this.tab_ModeloExistente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ModeloExistente.Size = new System.Drawing.Size(385, 322);
            this.tab_ModeloExistente.TabIndex = 0;
            this.tab_ModeloExistente.Text = "Modelo Existente";
            this.tab_ModeloExistente.UseVisualStyleBackColor = true;
            // 
            // group_incluirestoque
            // 
            this.group_incluirestoque.Controls.Add(this.textBox3);
            this.group_incluirestoque.Controls.Add(this.label9);
            this.group_incluirestoque.Controls.Add(this.comboBox1);
            this.group_incluirestoque.Controls.Add(this.label6);
            this.group_incluirestoque.Controls.Add(this.label5);
            this.group_incluirestoque.Controls.Add(this.textBox1);
            this.group_incluirestoque.Controls.Add(this.label4);
            this.group_incluirestoque.Controls.Add(this.list_Cor);
            this.group_incluirestoque.Controls.Add(this.btn_Incluir);
            this.group_incluirestoque.Controls.Add(this.list_Modelo);
            this.group_incluirestoque.Controls.Add(this.txt_Quantidade);
            this.group_incluirestoque.Controls.Add(this.list_Numeracao);
            this.group_incluirestoque.Controls.Add(this.label3);
            this.group_incluirestoque.Controls.Add(this.label2);
            this.group_incluirestoque.Controls.Add(this.label1);
            this.group_incluirestoque.Location = new System.Drawing.Point(15, 12);
            this.group_incluirestoque.Name = "group_incluirestoque";
            this.group_incluirestoque.Size = new System.Drawing.Size(356, 304);
            this.group_incluirestoque.TabIndex = 22;
            this.group_incluirestoque.TabStop = false;
            this.group_incluirestoque.Text = "Incluir no estoque";
            this.group_incluirestoque.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 20);
            this.textBox3.TabIndex = 36;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Valor:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BABY (Bebês) (17-22)",
            "KIDS (Pequenos) (23-32)",
            "TOP (Tira grossa) (33-47)",
            "SLIM (Tira fina) (33-47)"});
            this.comboBox1.Location = new System.Drawing.Point(90, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(216, 54);
            this.textBox1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cor:";
            // 
            // list_Cor
            // 
            this.list_Cor.FormattingEnabled = true;
            this.list_Cor.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47"});
            this.list_Cor.Location = new System.Drawing.Point(90, 73);
            this.list_Cor.Name = "list_Cor";
            this.list_Cor.Size = new System.Drawing.Size(216, 21);
            this.list_Cor.TabIndex = 29;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(89, 238);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(218, 55);
            this.btn_Incluir.TabIndex = 28;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // list_Modelo
            // 
            this.list_Modelo.FormattingEnabled = true;
            this.list_Modelo.Items.AddRange(new object[] {
            "BABY (Bebês) (17-22)",
            "KIDS (Pequenos) (23-32)",
            "TOP (Tira grossa) (33-47)",
            "SLIM (Tira fina) (33-47)"});
            this.list_Modelo.Location = new System.Drawing.Point(90, 46);
            this.list_Modelo.Name = "list_Modelo";
            this.list_Modelo.Size = new System.Drawing.Size(216, 21);
            this.list_Modelo.TabIndex = 27;
            this.list_Modelo.SelectedIndexChanged += new System.EventHandler(this.list_Modelo_SelectedIndexChanged_1);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(90, 187);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(216, 20);
            this.txt_Quantidade.TabIndex = 26;
            // 
            // list_Numeracao
            // 
            this.list_Numeracao.FormattingEnabled = true;
            this.list_Numeracao.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47"});
            this.list_Numeracao.Location = new System.Drawing.Point(90, 100);
            this.list_Numeracao.Name = "list_Numeracao";
            this.list_Numeracao.Size = new System.Drawing.Size(216, 21);
            this.list_Numeracao.TabIndex = 25;
            this.list_Numeracao.SelectedIndexChanged += new System.EventHandler(this.list_Numeracao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Numeração:";
            // 
            // tab_NovoModelo
            // 
            this.tab_NovoModelo.Controls.Add(this.group_AddModelo);
            this.tab_NovoModelo.Location = new System.Drawing.Point(4, 22);
            this.tab_NovoModelo.Name = "tab_NovoModelo";
            this.tab_NovoModelo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NovoModelo.Size = new System.Drawing.Size(385, 322);
            this.tab_NovoModelo.TabIndex = 1;
            this.tab_NovoModelo.Text = "Novo Modelo";
            this.tab_NovoModelo.UseVisualStyleBackColor = true;
            // 
            // group_AddModelo
            // 
            this.group_AddModelo.Controls.Add(this.checkedListBox1);
            this.group_AddModelo.Controls.Add(this.label8);
            this.group_AddModelo.Controls.Add(this.label7);
            this.group_AddModelo.Controls.Add(this.textBox2);
            this.group_AddModelo.Controls.Add(this.btn_AdicionarModelo);
            this.group_AddModelo.Controls.Add(this.lbl_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.txt_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.groupBox2);
            this.group_AddModelo.Location = new System.Drawing.Point(15, 13);
            this.group_AddModelo.Name = "group_AddModelo";
            this.group_AddModelo.Size = new System.Drawing.Size(356, 294);
            this.group_AddModelo.TabIndex = 16;
            this.group_AddModelo.TabStop = false;
            this.group_AddModelo.Text = "Adicionar um novo modelo";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Preta",
            "Branca",
            "Verde",
            "Amarela",
            "Azul",
            "Vermelha",
            "Rosa"});
            this.checkedListBox1.Location = new System.Drawing.Point(90, 87);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(216, 49);
            this.checkedListBox1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cores:";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Modelo:";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btn_AdicionarModelo
            // 
            this.btn_AdicionarModelo.Location = new System.Drawing.Point(42, 210);
            this.btn_AdicionarModelo.Name = "btn_AdicionarModelo";
            this.btn_AdicionarModelo.Size = new System.Drawing.Size(264, 55);
            this.btn_AdicionarModelo.TabIndex = 8;
            this.btn_AdicionarModelo.Text = "Adicionar";
            this.btn_AdicionarModelo.UseVisualStyleBackColor = true;
            this.btn_AdicionarModelo.Click += new System.EventHandler(this.btn_AdicionarModelo_Click_1);
            // 
            // lbl_NomeNovoModelo
            // 
            this.lbl_NomeNovoModelo.AutoSize = true;
            this.lbl_NomeNovoModelo.Location = new System.Drawing.Point(46, 38);
            this.lbl_NomeNovoModelo.Name = "lbl_NomeNovoModelo";
            this.lbl_NomeNovoModelo.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomeNovoModelo.TabIndex = 1;
            this.lbl_NomeNovoModelo.Text = "Nome:";
            // 
            // txt_NomeNovoModelo
            // 
            this.txt_NomeNovoModelo.Location = new System.Drawing.Point(90, 35);
            this.txt_NomeNovoModelo.Name = "txt_NomeNovoModelo";
            this.txt_NomeNovoModelo.Size = new System.Drawing.Size(216, 20);
            this.txt_NomeNovoModelo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumFaixa_FINAL);
            this.groupBox2.Controls.Add(this.NumFaixa_INICIAL);
            this.groupBox2.Controls.Add(this.lbl_De);
            this.groupBox2.Controls.Add(this.lbl_Ate);
            this.groupBox2.Location = new System.Drawing.Point(42, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faixa de numeração";
            // 
            // NumFaixa_FINAL
            // 
            this.NumFaixa_FINAL.Location = new System.Drawing.Point(162, 25);
            this.NumFaixa_FINAL.Maximum = new decimal(new int[] {
            47,
            0,
            0,
            0});
            this.NumFaixa_FINAL.Minimum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.NumFaixa_FINAL.Name = "NumFaixa_FINAL";
            this.NumFaixa_FINAL.Size = new System.Drawing.Size(37, 20);
            this.NumFaixa_FINAL.TabIndex = 6;
            this.NumFaixa_FINAL.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // NumFaixa_INICIAL
            // 
            this.NumFaixa_INICIAL.Location = new System.Drawing.Point(80, 25);
            this.NumFaixa_INICIAL.Maximum = new decimal(new int[] {
            47,
            0,
            0,
            0});
            this.NumFaixa_INICIAL.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.NumFaixa_INICIAL.Name = "NumFaixa_INICIAL";
            this.NumFaixa_INICIAL.Size = new System.Drawing.Size(37, 20);
            this.NumFaixa_INICIAL.TabIndex = 5;
            this.NumFaixa_INICIAL.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // lbl_De
            // 
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(50, 27);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(24, 13);
            this.lbl_De.TabIndex = 3;
            this.lbl_De.Text = "De:";
            // 
            // lbl_Ate
            // 
            this.lbl_Ate.AutoSize = true;
            this.lbl_Ate.Location = new System.Drawing.Point(129, 27);
            this.lbl_Ate.Name = "lbl_Ate";
            this.lbl_Ate.Size = new System.Drawing.Size(26, 13);
            this.lbl_Ate.TabIndex = 4;
            this.lbl_Ate.Text = "Até:";
            // 
            // lbl_privilegio
            // 
            this.lbl_privilegio.AutoSize = true;
            this.lbl_privilegio.Location = new System.Drawing.Point(41, 164);
            this.lbl_privilegio.Name = "lbl_privilegio";
            this.lbl_privilegio.Size = new System.Drawing.Size(306, 26);
            this.lbl_privilegio.TabIndex = 35;
            this.lbl_privilegio.Text = "Você não tem privilégios suficientes para acessar este recurso. \r\nPor favor, cont" +
    "ate seu gerente.";
            this.lbl_privilegio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.tab_Cadastro);
            this.AllTabs.Controls.Add(this.tab_Estoque);
            this.AllTabs.Location = new System.Drawing.Point(13, 118);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(406, 386);
            this.AllTabs.TabIndex = 7;
            this.AllTabs.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.btn_Sair_Click_1);
            // 
            // rd_gerente
            // 
            this.rd_gerente.AutoSize = true;
            this.rd_gerente.Location = new System.Drawing.Point(127, 19);
            this.rd_gerente.Name = "rd_gerente";
            this.rd_gerente.Size = new System.Drawing.Size(63, 17);
            this.rd_gerente.TabIndex = 29;
            this.rd_gerente.TabStop = true;
            this.rd_gerente.Text = "Gerente";
            this.rd_gerente.UseVisualStyleBackColor = true;
            this.rd_gerente.CheckedChanged += new System.EventHandler(this.rdGerente_CheckedChanged);
            // 
            // rd_estoquista
            // 
            this.rd_estoquista.AutoSize = true;
            this.rd_estoquista.Location = new System.Drawing.Point(198, 19);
            this.rd_estoquista.Name = "rd_estoquista";
            this.rd_estoquista.Size = new System.Drawing.Size(74, 17);
            this.rd_estoquista.TabIndex = 30;
            this.rd_estoquista.TabStop = true;
            this.rd_estoquista.Text = "Estoquista";
            this.rd_estoquista.UseVisualStyleBackColor = true;
            this.rd_estoquista.CheckedChanged += new System.EventHandler(this.rdEstoquista_CheckedChanged);
            // 
            // group_entrarcomo
            // 
            this.group_entrarcomo.Controls.Add(this.lbl_password);
            this.group_entrarcomo.Controls.Add(this.btn_passenter);
            this.group_entrarcomo.Controls.Add(this.txt_pass);
            this.group_entrarcomo.Controls.Add(this.rd_estoquista);
            this.group_entrarcomo.Controls.Add(this.rd_gerente);
            this.group_entrarcomo.Location = new System.Drawing.Point(12, 27);
            this.group_entrarcomo.Name = "group_entrarcomo";
            this.group_entrarcomo.Size = new System.Drawing.Size(406, 85);
            this.group_entrarcomo.TabIndex = 26;
            this.group_entrarcomo.TabStop = false;
            this.group_entrarcomo.Text = "Entrar como";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(31, 54);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 31;
            this.lbl_password.Text = "Password:";
            // 
            // btn_passenter
            // 
            this.btn_passenter.Location = new System.Drawing.Point(283, 50);
            this.btn_passenter.Name = "btn_passenter";
            this.btn_passenter.Size = new System.Drawing.Size(75, 23);
            this.btn_passenter.TabIndex = 32;
            this.btn_passenter.Text = "Entrar";
            this.btn_passenter.UseVisualStyleBackColor = true;
            this.btn_passenter.Click += new System.EventHandler(this.passenter_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(93, 51);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(184, 20);
            this.txt_pass.TabIndex = 33;
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Modelo,
            this.Cor,
            this.Numeracao,
            this.Descricao,
            this.Quantidade,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(30, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 230);
            this.dataGridView1.TabIndex = 19;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            // 
            // Numeracao
            // 
            this.Numeracao.HeaderText = "Numeração";
            this.Numeracao.Name = "Numeracao";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 514);
            this.Controls.Add(this.AllTabs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grid_Listas);
            this.Controls.Add(this.list_NovaLista);
            this.Controls.Add(this.group_entrarcomo);
            this.Name = "F_Menu";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havaianas, AS LEGÍTIMAS  –  Controle de Estoque";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Listas)).EndInit();
            this.tab_Estoque.ResumeLayout(false);
            this.tab_Cadastro.ResumeLayout(false);
            this.tab_Cadastro.PerformLayout();
            this.Abas_2.ResumeLayout(false);
            this.tab_ModeloExistente.ResumeLayout(false);
            this.group_incluirestoque.ResumeLayout(false);
            this.group_incluirestoque.PerformLayout();
            this.tab_NovoModelo.ResumeLayout(false);
            this.group_AddModelo.ResumeLayout(false);
            this.group_AddModelo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).EndInit();
            this.AllTabs.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_entrarcomo.ResumeLayout(false);
            this.group_entrarcomo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_Listas;
        private System.Windows.Forms.ComboBox list_NovaLista;
        private System.Windows.Forms.TabPage tab_Estoque;
        private System.Windows.Forms.TabPage tab_Cadastro;
        private System.Windows.Forms.TabControl Abas_2;
        private System.Windows.Forms.TabPage tab_ModeloExistente;
        private System.Windows.Forms.GroupBox group_incluirestoque;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.ComboBox list_Modelo;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.ComboBox list_Numeracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_NovoModelo;
        private System.Windows.Forms.GroupBox group_AddModelo;
        private System.Windows.Forms.Button btn_AdicionarModelo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumFaixa_FINAL;
        private System.Windows.Forms.NumericUpDown NumFaixa_INICIAL;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.Label lbl_Ate;
        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox list_Cor;
        private System.Windows.Forms.Button bt_salvardb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faixa_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faixa_final;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_NomeNovoModelo;
        private System.Windows.Forms.TextBox txt_NomeNovoModelo;
        private System.Windows.Forms.RadioButton rd_gerente;
        private System.Windows.Forms.RadioButton rd_estoquista;
        private System.Windows.Forms.GroupBox group_entrarcomo;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_passenter;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_privilegio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}