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
            this.ModelosNovosLista = new System.Windows.Forms.DataGridView();
            this.ID_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faixa_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faixa_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_NovaLista = new System.Windows.Forms.ComboBox();
            this.tab_Estoque = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Cadastro = new System.Windows.Forms.TabPage();
            this.Abas_2 = new System.Windows.Forms.TabControl();
            this.tab_ModeloExistente = new System.Windows.Forms.TabPage();
            this.group_incluirestoque = new System.Windows.Forms.GroupBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.list_Modelo = new System.Windows.Forms.ComboBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.list_Numeracao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_NovoModelo = new System.Windows.Forms.TabPage();
            this.group_AddModelo = new System.Windows.Forms.GroupBox();
            this.btn_AdicionarModelo = new System.Windows.Forms.Button();
            this.lbl_NomeNovoModelo = new System.Windows.Forms.Label();
            this.txt_NomeNovoModelo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumFaixa_FINAL = new System.Windows.Forms.NumericUpDown();
            this.NumFaixa_INICIAL = new System.Windows.Forms.NumericUpDown();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_Ate = new System.Windows.Forms.Label();
            this.abas = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EntrarComoGerente = new System.Windows.Forms.ToolStripMenuItem();
            this.EntrarComoEstoquista = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ModelosNovosLista)).BeginInit();
            this.tab_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_Cadastro.SuspendLayout();
            this.Abas_2.SuspendLayout();
            this.tab_ModeloExistente.SuspendLayout();
            this.group_incluirestoque.SuspendLayout();
            this.tab_NovoModelo.SuspendLayout();
            this.group_AddModelo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).BeginInit();
            this.abas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelosNovosLista
            // 
            this.ModelosNovosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelosNovosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Lista,
            this.Nome_Lista,
            this.col_faixa_inicial,
            this.col_faixa_final});
            this.ModelosNovosLista.Location = new System.Drawing.Point(0, 429);
            this.ModelosNovosLista.Name = "ModelosNovosLista";
            this.ModelosNovosLista.Size = new System.Drawing.Size(227, 68);
            this.ModelosNovosLista.TabIndex = 18;
            this.ModelosNovosLista.Visible = false;
            // 
            // ID_Lista
            // 
            this.ID_Lista.HeaderText = "ID_Lista";
            this.ID_Lista.Name = "ID_Lista";
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
            this.list_NovaLista.Location = new System.Drawing.Point(256, 429);
            this.list_NovaLista.Name = "list_NovaLista";
            this.list_NovaLista.Size = new System.Drawing.Size(174, 21);
            this.list_NovaLista.TabIndex = 17;
            this.list_NovaLista.TabStop = false;
            this.list_NovaLista.Visible = false;
            // 
            // tab_Estoque
            // 
            this.tab_Estoque.Controls.Add(this.dataGridView1);
            this.tab_Estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_Estoque.Name = "tab_Estoque";
            this.tab_Estoque.Size = new System.Drawing.Size(401, 377);
            this.tab_Estoque.TabIndex = 3;
            this.tab_Estoque.Text = "Estoque";
            this.tab_Estoque.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Numeracao,
            this.Quantidade});
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 228);
            this.dataGridView1.TabIndex = 17;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Numeracao
            // 
            this.Numeracao.HeaderText = "Numeração";
            this.Numeracao.Name = "Numeracao";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // tab_Cadastro
            // 
            this.tab_Cadastro.Controls.Add(this.Abas_2);
            this.tab_Cadastro.Location = new System.Drawing.Point(4, 22);
            this.tab_Cadastro.Name = "tab_Cadastro";
            this.tab_Cadastro.Size = new System.Drawing.Size(401, 385);
            this.tab_Cadastro.TabIndex = 0;
            this.tab_Cadastro.Text = "Cadastro";
            this.tab_Cadastro.UseVisualStyleBackColor = true;
            this.tab_Cadastro.Click += new System.EventHandler(this.tab_Cadastro_Click);
            // 
            // Abas_2
            // 
            this.Abas_2.Controls.Add(this.tab_ModeloExistente);
            this.Abas_2.Controls.Add(this.tab_NovoModelo);
            this.Abas_2.Location = new System.Drawing.Point(3, 14);
            this.Abas_2.Name = "Abas_2";
            this.Abas_2.SelectedIndex = 0;
            this.Abas_2.Size = new System.Drawing.Size(393, 351);
            this.Abas_2.TabIndex = 16;
            // 
            // tab_ModeloExistente
            // 
            this.tab_ModeloExistente.Controls.Add(this.group_incluirestoque);
            this.tab_ModeloExistente.Location = new System.Drawing.Point(4, 22);
            this.tab_ModeloExistente.Name = "tab_ModeloExistente";
            this.tab_ModeloExistente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ModeloExistente.Size = new System.Drawing.Size(385, 325);
            this.tab_ModeloExistente.TabIndex = 0;
            this.tab_ModeloExistente.Text = "Modelo Existente";
            this.tab_ModeloExistente.UseVisualStyleBackColor = true;
            // 
            // group_incluirestoque
            // 
            this.group_incluirestoque.Controls.Add(this.btn_Incluir);
            this.group_incluirestoque.Controls.Add(this.list_Modelo);
            this.group_incluirestoque.Controls.Add(this.txt_Quantidade);
            this.group_incluirestoque.Controls.Add(this.list_Numeracao);
            this.group_incluirestoque.Controls.Add(this.label3);
            this.group_incluirestoque.Controls.Add(this.label2);
            this.group_incluirestoque.Controls.Add(this.label1);
            this.group_incluirestoque.Location = new System.Drawing.Point(15, 12);
            this.group_incluirestoque.Name = "group_incluirestoque";
            this.group_incluirestoque.Size = new System.Drawing.Size(356, 294);
            this.group_incluirestoque.TabIndex = 22;
            this.group_incluirestoque.TabStop = false;
            this.group_incluirestoque.Text = "Incluir no estoque";
            this.group_incluirestoque.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(106, 177);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(216, 55);
            this.btn_Incluir.TabIndex = 28;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            // 
            // list_Modelo
            // 
            this.list_Modelo.FormattingEnabled = true;
            this.list_Modelo.Items.AddRange(new object[] {
            "BABY (Bebês) (17-22)",
            "KIDS (Pequenos) (23-32)",
            "TOP (Tira grossa) (33-47)",
            "SLIM (Tira fina) (33-47)"});
            this.list_Modelo.Location = new System.Drawing.Point(106, 70);
            this.list_Modelo.Name = "list_Modelo";
            this.list_Modelo.Size = new System.Drawing.Size(216, 21);
            this.list_Modelo.TabIndex = 27;
            this.list_Modelo.SelectedIndexChanged += new System.EventHandler(this.list_Modelo_SelectedIndexChanged_1);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(106, 142);
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
            this.list_Numeracao.Location = new System.Drawing.Point(106, 106);
            this.list_Numeracao.Name = "list_Numeracao";
            this.list_Numeracao.Size = new System.Drawing.Size(216, 21);
            this.list_Numeracao.TabIndex = 25;
            this.list_Numeracao.SelectedIndexChanged += new System.EventHandler(this.list_Numeracao_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 110);
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
            this.tab_NovoModelo.Size = new System.Drawing.Size(385, 325);
            this.tab_NovoModelo.TabIndex = 1;
            this.tab_NovoModelo.Text = "Novo Modelo";
            this.tab_NovoModelo.UseVisualStyleBackColor = true;
            // 
            // group_AddModelo
            // 
            this.group_AddModelo.Controls.Add(this.btn_AdicionarModelo);
            this.group_AddModelo.Controls.Add(this.lbl_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.txt_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.groupBox2);
            this.group_AddModelo.Location = new System.Drawing.Point(15, 12);
            this.group_AddModelo.Name = "group_AddModelo";
            this.group_AddModelo.Size = new System.Drawing.Size(356, 294);
            this.group_AddModelo.TabIndex = 16;
            this.group_AddModelo.TabStop = false;
            this.group_AddModelo.Text = "Adicionar um novo modelo";
            // 
            // btn_AdicionarModelo
            // 
            this.btn_AdicionarModelo.Location = new System.Drawing.Point(49, 172);
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
            this.lbl_NomeNovoModelo.Location = new System.Drawing.Point(46, 87);
            this.lbl_NomeNovoModelo.Name = "lbl_NomeNovoModelo";
            this.lbl_NomeNovoModelo.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomeNovoModelo.TabIndex = 1;
            this.lbl_NomeNovoModelo.Text = "Nome:";
            // 
            // txt_NomeNovoModelo
            // 
            this.txt_NomeNovoModelo.Location = new System.Drawing.Point(90, 84);
            this.txt_NomeNovoModelo.Name = "txt_NomeNovoModelo";
            this.txt_NomeNovoModelo.Size = new System.Drawing.Size(223, 20);
            this.txt_NomeNovoModelo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumFaixa_FINAL);
            this.groupBox2.Controls.Add(this.NumFaixa_INICIAL);
            this.groupBox2.Controls.Add(this.lbl_De);
            this.groupBox2.Controls.Add(this.lbl_Ate);
            this.groupBox2.Location = new System.Drawing.Point(49, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faixa de numeração";
            // 
            // NumFaixa_FINAL
            // 
            this.NumFaixa_FINAL.Location = new System.Drawing.Point(162, 22);
            this.NumFaixa_FINAL.Maximum = new decimal(new int[] {
            47,
            0,
            0,
            0});
            this.NumFaixa_FINAL.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumFaixa_FINAL.Name = "NumFaixa_FINAL";
            this.NumFaixa_FINAL.Size = new System.Drawing.Size(37, 20);
            this.NumFaixa_FINAL.TabIndex = 6;
            this.NumFaixa_FINAL.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // NumFaixa_INICIAL
            // 
            this.NumFaixa_INICIAL.Location = new System.Drawing.Point(80, 22);
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
            this.lbl_De.Location = new System.Drawing.Point(50, 24);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(24, 13);
            this.lbl_De.TabIndex = 3;
            this.lbl_De.Text = "De:";
            // 
            // lbl_Ate
            // 
            this.lbl_Ate.AutoSize = true;
            this.lbl_Ate.Location = new System.Drawing.Point(129, 24);
            this.lbl_Ate.Name = "lbl_Ate";
            this.lbl_Ate.Size = new System.Drawing.Size(26, 13);
            this.lbl_Ate.TabIndex = 4;
            this.lbl_Ate.Text = "Até:";
            // 
            // abas
            // 
            this.abas.Controls.Add(this.tab_Cadastro);
            this.abas.Controls.Add(this.tab_Estoque);
            this.abas.Location = new System.Drawing.Point(12, 27);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(409, 411);
            this.abas.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.loginToolStripMenuItem.Text = "Arquivo";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntrarComoGerente,
            this.EntrarComoEstoquista});
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem1.Text = "Login";
            // 
            // EntrarComoGerente
            // 
            this.EntrarComoGerente.Name = "EntrarComoGerente";
            this.EntrarComoGerente.Size = new System.Drawing.Size(196, 22);
            this.EntrarComoGerente.Text = "Entrar como Gerente";
            // 
            // EntrarComoEstoquista
            // 
            this.EntrarComoEstoquista.Name = "EntrarComoEstoquista";
            this.EntrarComoEstoquista.Size = new System.Drawing.Size(196, 22);
            this.EntrarComoEstoquista.Text = "Entrar como Estoquista";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.btn_Sair_Click_1);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.list_NovaLista);
            this.Controls.Add(this.ModelosNovosLista);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "F_Menu";
            this.Opacity = 0.93D;
            this.Text = "Havaianas, AS LEGÍTIMAS  –  Controle de Estoque";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModelosNovosLista)).EndInit();
            this.tab_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_Cadastro.ResumeLayout(false);
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
            this.abas.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ModelosNovosLista;
        private System.Windows.Forms.ComboBox list_NovaLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faixa_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faixa_final;
        private System.Windows.Forms.TabPage tab_Estoque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
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
        private System.Windows.Forms.Label lbl_NomeNovoModelo;
        private System.Windows.Forms.TextBox txt_NomeNovoModelo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumFaixa_FINAL;
        private System.Windows.Forms.NumericUpDown NumFaixa_INICIAL;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.Label lbl_Ate;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EntrarComoGerente;
        private System.Windows.Forms.ToolStripMenuItem EntrarComoEstoquista;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}