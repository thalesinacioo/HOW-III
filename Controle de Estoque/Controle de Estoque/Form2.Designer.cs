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
            this.btn_CancelaAddModelo = new System.Windows.Forms.Button();
            this.group_AddModelo = new System.Windows.Forms.GroupBox();
            this.btn_AdicionarModelo = new System.Windows.Forms.Button();
            this.lbl_NomeNovoModelo = new System.Windows.Forms.Label();
            this.txt_NomeNovoModelo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumFaixa_FINAL = new System.Windows.Forms.NumericUpDown();
            this.NumFaixa_INICIAL = new System.Windows.Forms.NumericUpDown();
            this.lbl_De = new System.Windows.Forms.Label();
            this.lbl_Ate = new System.Windows.Forms.Label();
            this.btn_NovoModelo = new System.Windows.Forms.Button();
            this.lbl_OModeloENovo = new System.Windows.Forms.Label();
            this.list_Modelo = new System.Windows.Forms.ComboBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.list_Numeracao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Compras = new System.Windows.Forms.TabPage();
            this.tab_Vendas = new System.Windows.Forms.TabPage();
            this.tab_Estoque = new System.Windows.Forms.TabPage();
            this.tab_Relatorios = new System.Windows.Forms.TabPage();
            this.abas.SuspendLayout();
            this.tab_Cadastro.SuspendLayout();
            this.group_AddModelo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFaixa_INICIAL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(613, 383);
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
            this.abas.Controls.Add(this.tab_Compras);
            this.abas.Controls.Add(this.tab_Vendas);
            this.abas.Controls.Add(this.tab_Estoque);
            this.abas.Controls.Add(this.tab_Relatorios);
            this.abas.Location = new System.Drawing.Point(12, 12);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(776, 365);
            this.abas.TabIndex = 7;
            // 
            // tab_Cadastro
            // 
            this.tab_Cadastro.Controls.Add(this.btn_CancelaAddModelo);
            this.tab_Cadastro.Controls.Add(this.group_AddModelo);
            this.tab_Cadastro.Controls.Add(this.btn_NovoModelo);
            this.tab_Cadastro.Controls.Add(this.lbl_OModeloENovo);
            this.tab_Cadastro.Controls.Add(this.list_Modelo);
            this.tab_Cadastro.Controls.Add(this.txt_Quantidade);
            this.tab_Cadastro.Controls.Add(this.list_Numeracao);
            this.tab_Cadastro.Controls.Add(this.label3);
            this.tab_Cadastro.Controls.Add(this.label2);
            this.tab_Cadastro.Controls.Add(this.label1);
            this.tab_Cadastro.Location = new System.Drawing.Point(4, 22);
            this.tab_Cadastro.Name = "tab_Cadastro";
            this.tab_Cadastro.Size = new System.Drawing.Size(768, 339);
            this.tab_Cadastro.TabIndex = 0;
            this.tab_Cadastro.Text = "Cadastro";
            this.tab_Cadastro.UseVisualStyleBackColor = true;
            this.tab_Cadastro.Click += new System.EventHandler(this.tab_Cadastro_Click);
            // 
            // btn_CancelaAddModelo
            // 
            this.btn_CancelaAddModelo.BackColor = System.Drawing.Color.LightGray;
            this.btn_CancelaAddModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelaAddModelo.Location = new System.Drawing.Point(127, 38);
            this.btn_CancelaAddModelo.Name = "btn_CancelaAddModelo";
            this.btn_CancelaAddModelo.Size = new System.Drawing.Size(217, 63);
            this.btn_CancelaAddModelo.TabIndex = 14;
            this.btn_CancelaAddModelo.Text = "Cancelar";
            this.btn_CancelaAddModelo.UseVisualStyleBackColor = false;
            this.btn_CancelaAddModelo.Visible = false;
            this.btn_CancelaAddModelo.Click += new System.EventHandler(this.btn_CancelaAddModelo_Click);
            // 
            // group_AddModelo
            // 
            this.group_AddModelo.Controls.Add(this.btn_AdicionarModelo);
            this.group_AddModelo.Controls.Add(this.lbl_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.txt_NomeNovoModelo);
            this.group_AddModelo.Controls.Add(this.groupBox2);
            this.group_AddModelo.Location = new System.Drawing.Point(413, 32);
            this.group_AddModelo.Name = "group_AddModelo";
            this.group_AddModelo.Size = new System.Drawing.Size(303, 178);
            this.group_AddModelo.TabIndex = 13;
            this.group_AddModelo.TabStop = false;
            this.group_AddModelo.Text = "Adicionar um novo modelo";
            this.group_AddModelo.Visible = false;
            // 
            // btn_AdicionarModelo
            // 
            this.btn_AdicionarModelo.Location = new System.Drawing.Point(21, 115);
            this.btn_AdicionarModelo.Name = "btn_AdicionarModelo";
            this.btn_AdicionarModelo.Size = new System.Drawing.Size(264, 43);
            this.btn_AdicionarModelo.TabIndex = 8;
            this.btn_AdicionarModelo.Text = "Adicionar";
            this.btn_AdicionarModelo.UseVisualStyleBackColor = true;
            this.btn_AdicionarModelo.Click += new System.EventHandler(this.btn_AdicionarModelo_Click);
            // 
            // lbl_NomeNovoModelo
            // 
            this.lbl_NomeNovoModelo.AutoSize = true;
            this.lbl_NomeNovoModelo.Location = new System.Drawing.Point(18, 30);
            this.lbl_NomeNovoModelo.Name = "lbl_NomeNovoModelo";
            this.lbl_NomeNovoModelo.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomeNovoModelo.TabIndex = 1;
            this.lbl_NomeNovoModelo.Text = "Nome:";
            this.lbl_NomeNovoModelo.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_NomeNovoModelo
            // 
            this.txt_NomeNovoModelo.Location = new System.Drawing.Point(62, 27);
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
            this.groupBox2.Location = new System.Drawing.Point(21, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faixa de numeração";
            // 
            // NumFaixa_FINAL
            // 
            this.NumFaixa_FINAL.Location = new System.Drawing.Point(162, 22);
            this.NumFaixa_FINAL.Name = "NumFaixa_FINAL";
            this.NumFaixa_FINAL.Size = new System.Drawing.Size(37, 20);
            this.NumFaixa_FINAL.TabIndex = 6;
            this.NumFaixa_FINAL.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // NumFaixa_INICIAL
            // 
            this.NumFaixa_INICIAL.Location = new System.Drawing.Point(80, 22);
            this.NumFaixa_INICIAL.Name = "NumFaixa_INICIAL";
            this.NumFaixa_INICIAL.Size = new System.Drawing.Size(37, 20);
            this.NumFaixa_INICIAL.TabIndex = 5;
            this.NumFaixa_INICIAL.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_De
            // 
            this.lbl_De.AutoSize = true;
            this.lbl_De.Location = new System.Drawing.Point(50, 24);
            this.lbl_De.Name = "lbl_De";
            this.lbl_De.Size = new System.Drawing.Size(24, 13);
            this.lbl_De.TabIndex = 3;
            this.lbl_De.Text = "De:";
            this.lbl_De.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_Ate
            // 
            this.lbl_Ate.AutoSize = true;
            this.lbl_Ate.Location = new System.Drawing.Point(129, 24);
            this.lbl_Ate.Name = "lbl_Ate";
            this.lbl_Ate.Size = new System.Drawing.Size(26, 13);
            this.lbl_Ate.TabIndex = 4;
            this.lbl_Ate.Text = "Até:";
            this.lbl_Ate.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_NovoModelo
            // 
            this.btn_NovoModelo.Location = new System.Drawing.Point(127, 38);
            this.btn_NovoModelo.Name = "btn_NovoModelo";
            this.btn_NovoModelo.Size = new System.Drawing.Size(217, 63);
            this.btn_NovoModelo.TabIndex = 12;
            this.btn_NovoModelo.Text = "Adicionar um novo modelo";
            this.btn_NovoModelo.UseVisualStyleBackColor = true;
            this.btn_NovoModelo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_OModeloENovo
            // 
            this.lbl_OModeloENovo.AutoSize = true;
            this.lbl_OModeloENovo.Location = new System.Drawing.Point(28, 66);
            this.lbl_OModeloENovo.Name = "lbl_OModeloENovo";
            this.lbl_OModeloENovo.Size = new System.Drawing.Size(94, 13);
            this.lbl_OModeloENovo.TabIndex = 11;
            this.lbl_OModeloENovo.Text = "O modelo é novo?";
            // 
            // list_Modelo
            // 
            this.list_Modelo.FormattingEnabled = true;
            this.list_Modelo.Items.AddRange(new object[] {
            "TOP (Tira grossa)",
            "SLIM (Tira fina)",
            "KIDS (Pequenos)",
            "BABY (Bebês)"});
            this.list_Modelo.Location = new System.Drawing.Point(128, 118);
            this.list_Modelo.Name = "list_Modelo";
            this.list_Modelo.Size = new System.Drawing.Size(216, 21);
            this.list_Modelo.TabIndex = 10;
            this.list_Modelo.SelectedIndexChanged += new System.EventHandler(this.list_modelo_SelectedIndexChanged);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(128, 190);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(216, 20);
            this.txt_Quantidade.TabIndex = 7;
            this.txt_Quantidade.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
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
            this.list_Numeracao.Location = new System.Drawing.Point(128, 154);
            this.list_Numeracao.Name = "list_Numeracao";
            this.list_Numeracao.Size = new System.Drawing.Size(216, 21);
            this.list_Numeracao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numeração:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tab_Compras
            // 
            this.tab_Compras.Location = new System.Drawing.Point(4, 22);
            this.tab_Compras.Name = "tab_Compras";
            this.tab_Compras.Size = new System.Drawing.Size(768, 339);
            this.tab_Compras.TabIndex = 1;
            this.tab_Compras.Text = "Compras";
            this.tab_Compras.UseVisualStyleBackColor = true;
            // 
            // tab_Vendas
            // 
            this.tab_Vendas.Location = new System.Drawing.Point(4, 22);
            this.tab_Vendas.Name = "tab_Vendas";
            this.tab_Vendas.Size = new System.Drawing.Size(768, 339);
            this.tab_Vendas.TabIndex = 2;
            this.tab_Vendas.Text = "Vendas";
            this.tab_Vendas.UseVisualStyleBackColor = true;
            // 
            // tab_Estoque
            // 
            this.tab_Estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_Estoque.Name = "tab_Estoque";
            this.tab_Estoque.Size = new System.Drawing.Size(768, 339);
            this.tab_Estoque.TabIndex = 3;
            this.tab_Estoque.Text = "Estoque";
            this.tab_Estoque.UseVisualStyleBackColor = true;
            // 
            // tab_Relatorios
            // 
            this.tab_Relatorios.Location = new System.Drawing.Point(4, 22);
            this.tab_Relatorios.Name = "tab_Relatorios";
            this.tab_Relatorios.Size = new System.Drawing.Size(768, 339);
            this.tab_Relatorios.TabIndex = 4;
            this.tab_Relatorios.Text = "Relatórios";
            this.tab_Relatorios.UseVisualStyleBackColor = true;
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.btn_Sair);
            this.Name = "F_Menu";
            this.Text = "Havaianas, AS LEGÍTIMAS  –  Controle de Estoque";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            this.abas.ResumeLayout(false);
            this.tab_Cadastro.ResumeLayout(false);
            this.tab_Cadastro.PerformLayout();
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
        private System.Windows.Forms.TabPage tab_Compras;
        private System.Windows.Forms.TabPage tab_Vendas;
        private System.Windows.Forms.TabPage tab_Estoque;
        private System.Windows.Forms.TabPage tab_Relatorios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox list_Numeracao;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.ComboBox list_Modelo;
        private System.Windows.Forms.GroupBox group_AddModelo;
        private System.Windows.Forms.Label lbl_NomeNovoModelo;
        private System.Windows.Forms.TextBox txt_NomeNovoModelo;
        private System.Windows.Forms.Button btn_NovoModelo;
        private System.Windows.Forms.Label lbl_OModeloENovo;
        private System.Windows.Forms.NumericUpDown NumFaixa_INICIAL;
        private System.Windows.Forms.Label lbl_Ate;
        private System.Windows.Forms.Label lbl_De;
        private System.Windows.Forms.NumericUpDown NumFaixa_FINAL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AdicionarModelo;
        private System.Windows.Forms.Button btn_CancelaAddModelo;
    }
}