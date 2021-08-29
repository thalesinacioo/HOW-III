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
            this.btn_Sair = new System.Windows.Forms.Button();
            this.abas = new System.Windows.Forms.TabControl();
            this.tab_Cadastro = new System.Windows.Forms.TabPage();
            this.tab_Estoque = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abas_2 = new System.Windows.Forms.TabControl();
            this.tab_ModeloExistente = new System.Windows.Forms.TabPage();
            this.tab_NovoModelo = new System.Windows.Forms.TabPage();
            this.list_Modelo = new System.Windows.Forms.ComboBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.list_Numeracao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_NovaLista = new System.Windows.Forms.ComboBox();
            this.group_AddModelo = new System.Windows.Forms.GroupBox();
            this.btn_AdicionarModelo = new System.Windows.Forms.Button();
            this.lbl_NomeNovoModelo = new System.Windows.Forms.Label();
            this.txt_NomeNovoModelo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumFaixa_FINAL = new System.Windows.Forms.NumericUpDown();
            this.NumFaixa_INICIAL = new System.Windows.Forms.NumericUpDown();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_Ate = new System.Windows.Forms.Label();
            this.abas.SuspendLayout();
            this.tab_Cadastro.SuspendLayout();
            this.tab_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Abas_2.SuspendLayout();
            this.tab_ModeloExistente.SuspendLayout();
            this.tab_NovoModelo.SuspendLayout();
            this.group_AddModelo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(246, 383);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(174, 55);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // abas
            // 
            this.abas.Controls.Add(this.tab_Cadastro);
            this.abas.Controls.Add(this.tab_Estoque);
            this.abas.Location = new System.Drawing.Point(12, 12);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(409, 365);
            this.abas.TabIndex = 7;
            // 
            // tab_Cadastro
            // 
            this.tab_Cadastro.Controls.Add(this.Abas_2);
            this.tab_Cadastro.Location = new System.Drawing.Point(4, 22);
            this.tab_Cadastro.Name = "tab_Cadastro";
            this.tab_Cadastro.Size = new System.Drawing.Size(401, 339);
            this.tab_Cadastro.TabIndex = 0;
            this.tab_Cadastro.Text = "Cadastro";
            this.tab_Cadastro.UseVisualStyleBackColor = true;
            this.tab_Cadastro.Click += new System.EventHandler(this.tab_Cadastro_Click);
            // 
            // tab_Estoque
            // 
            this.tab_Estoque.Controls.Add(this.dataGridView1);
            this.tab_Estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_Estoque.Name = "tab_Estoque";
            this.tab_Estoque.Size = new System.Drawing.Size(401, 339);
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 27);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Lista});
            this.dataGridView2.Location = new System.Drawing.Point(16, 383);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(221, 55);
            this.dataGridView2.TabIndex = 18;
            // 
            // ID_Lista
            // 
            this.ID_Lista.HeaderText = "ID_Lista";
            this.ID_Lista.Name = "ID_Lista";
            // 
            // Abas_2
            // 
            this.Abas_2.Controls.Add(this.tab_ModeloExistente);
            this.Abas_2.Controls.Add(this.tab_NovoModelo);
            this.Abas_2.Location = new System.Drawing.Point(3, 14);
            this.Abas_2.Name = "Abas_2";
            this.Abas_2.SelectedIndex = 0;
            this.Abas_2.Size = new System.Drawing.Size(393, 322);
            this.Abas_2.TabIndex = 16;
            // 
            // tab_ModeloExistente
            // 
            this.tab_ModeloExistente.Controls.Add(this.list_Modelo);
            this.tab_ModeloExistente.Controls.Add(this.txt_Quantidade);
            this.tab_ModeloExistente.Controls.Add(this.list_Numeracao);
            this.tab_ModeloExistente.Controls.Add(this.label3);
            this.tab_ModeloExistente.Controls.Add(this.label2);
            this.tab_ModeloExistente.Controls.Add(this.label1);
            this.tab_ModeloExistente.Location = new System.Drawing.Point(4, 22);
            this.tab_ModeloExistente.Name = "tab_ModeloExistente";
            this.tab_ModeloExistente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ModeloExistente.Size = new System.Drawing.Size(385, 296);
            this.tab_ModeloExistente.TabIndex = 0;
            this.tab_ModeloExistente.Text = "Modelo Existente";
            this.tab_ModeloExistente.UseVisualStyleBackColor = true;
            // 
            // tab_NovoModelo
            // 
            this.tab_NovoModelo.Controls.Add(this.list_NovaLista);
            this.tab_NovoModelo.Controls.Add(this.group_AddModelo);
            this.tab_NovoModelo.Location = new System.Drawing.Point(4, 22);
            this.tab_NovoModelo.Name = "tab_NovoModelo";
            this.tab_NovoModelo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NovoModelo.Size = new System.Drawing.Size(385, 296);
            this.tab_NovoModelo.TabIndex = 1;
            this.tab_NovoModelo.Text = "Novo Modelo";
            this.tab_NovoModelo.UseVisualStyleBackColor = true;
            // 
            // list_Modelo
            // 
            this.list_Modelo.FormattingEnabled = true;
            this.list_Modelo.Items.AddRange(new object[] {
            "TOP (Tira grossa)",
            "SLIM (Tira fina)",
            "KIDS (Pequenos)",
            "BABY (Bebês)"});
            this.list_Modelo.Location = new System.Drawing.Point(121, 96);
            this.list_Modelo.Name = "list_Modelo";
            this.list_Modelo.Size = new System.Drawing.Size(216, 21);
            this.list_Modelo.TabIndex = 20;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(121, 168);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(216, 20);
            this.txt_Quantidade.TabIndex = 19;
            // 
            // list_Numeracao
            // 
            this.list_Numeracao.FormattingEnabled = true;
            this.list_Numeracao.Items.AddRange(new object[] {
            "17 (Baby)",
            "18 (Baby)",
            "19 (Baby)",
            "20 (Baby)",
            "21 (Baby)",
            "22 (Baby)",
            "23 (Kids)",
            "24 (Kids)",
            "25 (Kids)",
            "26 (Kids)",
            "27 (Kids)",
            "28 (Kids)",
            "29 (Kids)",
            "30 (Kids)",
            "31 (Kids)",
            "32 (Kids)",
            "33 (Adulto)",
            "34 (Adulto)",
            "35 (Adulto)",
            "36 (Adulto)",
            "37 (Adulto)",
            "38 (Adulto)",
            "39 (Adulto)",
            "40 (Adulto)",
            "41 (Adulto)",
            "42 (Adulto)",
            "43 (Adulto)",
            "44 (Adulto)",
            "45 (Adulto)",
            "46 (Adulto)",
            "47 (Adulto)"});
            this.list_Numeracao.Location = new System.Drawing.Point(121, 132);
            this.list_Numeracao.Name = "list_Numeracao";
            this.list_Numeracao.Size = new System.Drawing.Size(216, 21);
            this.list_Numeracao.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Numeração:";
            // 
            // list_NovaLista
            // 
            this.list_NovaLista.FormattingEnabled = true;
            this.list_NovaLista.Location = new System.Drawing.Point(258, 269);
            this.list_NovaLista.Name = "list_NovaLista";
            this.list_NovaLista.Size = new System.Drawing.Size(121, 21);
            this.list_NovaLista.TabIndex = 17;
            this.list_NovaLista.TabStop = false;
            this.list_NovaLista.Visible = false;
            // 
            // group_AddModelo
            // 
            this.group_AddModelo.Controls.Add(this.btn_AdicionarModelo);
            this.group_AddModelo.Controls.Add(this.lbl_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.txt_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.groupBox2);
            this.group_AddModelo.Location = new System.Drawing.Point(20, 16);
            this.group_AddModelo.Name = "group_AddModelo";
            this.group_AddModelo.Size = new System.Drawing.Size(346, 235);
            this.group_AddModelo.TabIndex = 16;
            this.group_AddModelo.TabStop = false;
            this.group_AddModelo.Text = "Adicionar um novo modelo";
            // 
            // btn_AdicionarModelo
            // 
            this.btn_AdicionarModelo.Location = new System.Drawing.Point(46, 139);
            this.btn_AdicionarModelo.Name = "btn_AdicionarModelo";
            this.btn_AdicionarModelo.Size = new System.Drawing.Size(264, 43);
            this.btn_AdicionarModelo.TabIndex = 8;
            this.btn_AdicionarModelo.Text = "Adicionar";
            this.btn_AdicionarModelo.UseVisualStyleBackColor = true;
            this.btn_AdicionarModelo.Click += new System.EventHandler(this.btn_AdicionarModelo_Click_1);
            // 
            // lbl_NomeNovoModelo
            // 
            this.lbl_NomeNovoModelo.AutoSize = true;
            this.lbl_NomeNovoModelo.Location = new System.Drawing.Point(43, 54);
            this.lbl_NomeNovoModelo.Name = "lbl_NomeNovoModelo";
            this.lbl_NomeNovoModelo.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomeNovoModelo.TabIndex = 1;
            this.lbl_NomeNovoModelo.Text = "Nome:";
            // 
            // txt_NomeNovoModelo
            // 
            this.txt_NomeNovoModelo.Location = new System.Drawing.Point(87, 51);
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
            this.groupBox2.Location = new System.Drawing.Point(46, 77);
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
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.btn_Sair);
            this.Name = "F_Menu";
            this.Text = "Havaianas, AS LEGÍTIMAS  –  Controle de Estoque";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            this.abas.ResumeLayout(false);
            this.tab_Cadastro.ResumeLayout(false);
            this.tab_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Abas_2.ResumeLayout(false);
            this.tab_ModeloExistente.ResumeLayout(false);
            this.tab_ModeloExistente.PerformLayout();
            this.tab_NovoModelo.ResumeLayout(false);
            this.group_AddModelo.ResumeLayout(false);
            this.group_AddModelo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.TabPage tab_Cadastro;
        private System.Windows.Forms.TabPage tab_Estoque;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.TabControl Abas_2;
        private System.Windows.Forms.TabPage tab_ModeloExistente;
        private System.Windows.Forms.ComboBox list_Modelo;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.ComboBox list_Numeracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_NovoModelo;
        private System.Windows.Forms.ComboBox list_NovaLista;
        private System.Windows.Forms.GroupBox group_AddModelo;
        private System.Windows.Forms.Button btn_AdicionarModelo;
        private System.Windows.Forms.Label lbl_NomeNovoModelo;
        private System.Windows.Forms.TextBox txt_NomeNovoModelo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumFaixa_FINAL;
        private System.Windows.Forms.NumericUpDown NumFaixa_INICIAL;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.Label lbl_Ate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lista;
    }
}