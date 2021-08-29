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
            this.Abas_2 = new System.Windows.Forms.TabControl();
            this.tab_ModeloExistente = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.tab_Estoque = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelosNovosLista = new System.Windows.Forms.DataGridView();
            this.ID_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faixa_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_faixa_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_NovaLista = new System.Windows.Forms.ComboBox();
            this.abas.SuspendLayout();
            this.tab_Cadastro.SuspendLayout();
            this.Abas_2.SuspendLayout();
            this.tab_ModeloExistente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_NovoModelo.SuspendLayout();
            this.group_AddModelo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).BeginInit();
            this.tab_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelosNovosLista)).BeginInit();
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
            this.tab_ModeloExistente.Controls.Add(this.groupBox1);
            this.tab_ModeloExistente.Location = new System.Drawing.Point(4, 22);
            this.tab_ModeloExistente.Name = "tab_ModeloExistente";
            this.tab_ModeloExistente.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ModeloExistente.Size = new System.Drawing.Size(385, 296);
            this.tab_ModeloExistente.TabIndex = 0;
            this.tab_ModeloExistente.Text = "Modelo Existente";
            this.tab_ModeloExistente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Incluir);
            this.groupBox1.Controls.Add(this.list_Modelo);
            this.groupBox1.Controls.Add(this.txt_Quantidade);
            this.groupBox1.Controls.Add(this.list_Numeracao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 265);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incluir no estoque";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(106, 158);
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
            "TOP (Tira grossa)",
            "SLIM (Tira fina)",
            "KIDS (Pequenos)",
            "BABY (Bebês)"});
            this.list_Modelo.Location = new System.Drawing.Point(106, 51);
            this.list_Modelo.Name = "list_Modelo";
            this.list_Modelo.Size = new System.Drawing.Size(216, 21);
            this.list_Modelo.TabIndex = 27;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(106, 123);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(216, 20);
            this.txt_Quantidade.TabIndex = 26;
            // 
            // list_Numeracao
            // 
            this.list_Numeracao.FormattingEnabled = true;
            this.list_Numeracao.Items.AddRange(new object[] {
            ""});
            this.list_Numeracao.Location = new System.Drawing.Point(106, 87);
            this.list_Numeracao.Name = "list_Numeracao";
            this.list_Numeracao.Size = new System.Drawing.Size(216, 21);
            this.list_Numeracao.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 91);
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
            this.tab_NovoModelo.Size = new System.Drawing.Size(385, 296);
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
            this.group_AddModelo.Size = new System.Drawing.Size(356, 265);
            this.group_AddModelo.TabIndex = 16;
            this.group_AddModelo.TabStop = false;
            this.group_AddModelo.Text = "Adicionar um novo modelo";
            // 
            // btn_AdicionarModelo
            // 
            this.btn_AdicionarModelo.Location = new System.Drawing.Point(46, 139);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 26);
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
            // ModelosNovosLista
            // 
            this.ModelosNovosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelosNovosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Lista,
            this.Nome_Lista,
            this.col_faixa_inicial,
            this.col_faixa_final});
            this.ModelosNovosLista.Location = new System.Drawing.Point(12, 383);
            this.ModelosNovosLista.Name = "ModelosNovosLista";
            this.ModelosNovosLista.Size = new System.Drawing.Size(227, 55);
            this.ModelosNovosLista.TabIndex = 18;
            this.ModelosNovosLista.Visible = false;
            this.ModelosNovosLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.list_NovaLista.Location = new System.Drawing.Point(12, 435);
            this.list_NovaLista.Name = "list_NovaLista";
            this.list_NovaLista.Size = new System.Drawing.Size(121, 21);
            this.list_NovaLista.TabIndex = 17;
            this.list_NovaLista.TabStop = false;
            this.list_NovaLista.Visible = false;
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.list_NovaLista);
            this.Controls.Add(this.ModelosNovosLista);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.btn_Sair);
            this.Name = "F_Menu";
            this.Text = "Havaianas, AS LEGÍTIMAS  –  Controle de Estoque";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            this.abas.ResumeLayout(false);
            this.tab_Cadastro.ResumeLayout(false);
            this.Abas_2.ResumeLayout(false);
            this.tab_ModeloExistente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_NovoModelo.ResumeLayout(false);
            this.group_AddModelo.ResumeLayout(false);
            this.group_AddModelo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).EndInit();
            this.tab_Estoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelosNovosLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.TabPage tab_Cadastro;
        private System.Windows.Forms.TabPage tab_Estoque;
        private System.Windows.Forms.DataGridView ModelosNovosLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.TabControl Abas_2;
        private System.Windows.Forms.TabPage tab_ModeloExistente;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.ComboBox list_Modelo;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.ComboBox list_Numeracao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faixa_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_faixa_final;
    }
}