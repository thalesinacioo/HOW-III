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
        /* <param name="disposing"> true if managed resources should be disposed; otherwise, false.</param>*/

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_Estoque = new System.Windows.Forms.TabPage();
            this.tbNum_estoq = new System.Windows.Forms.TextBox();
            this.tbCor_estoq = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tbID_estoq = new System.Windows.Forms.TextBox();
            this.btnDelete_estoq = new System.Windows.Forms.Button();
            this.UpdateBDView = new System.Windows.Forms.Button();
            this.btnInsert_estoq = new System.Windows.Forms.Button();
            this.mtbValor_estoq = new System.Windows.Forms.MaskedTextBox();
            this.rtDesc_estoq = new System.Windows.Forms.RichTextBox();
            this.btnLimpar_estoq = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbQtd_estoq = new System.Windows.Forms.TextBox();
            this.tbModelo_estoq = new System.Windows.Forms.TextBox();
            this.tbNome_estoq = new System.Windows.Forms.TextBox();
            this.dgEstoqueSandalias = new System.Windows.Forms.DataGridView();
            this.sandaliaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sandaliaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.rd_gerente = new System.Windows.Forms.RadioButton();
            this.rd_estoquista = new System.Windows.Forms.RadioButton();
            this.group_entrarcomo = new System.Windows.Forms.GroupBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_passenter = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoqueSandalias)).BeginInit();
            this.AllTabs.SuspendLayout();
            this.group_entrarcomo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Estoque
            // 
            this.tab_Estoque.Controls.Add(this.tbNum_estoq);
            this.tab_Estoque.Controls.Add(this.tbCor_estoq);
            this.tab_Estoque.Controls.Add(this.lbl_ID);
            this.tab_Estoque.Controls.Add(this.tbID_estoq);
            this.tab_Estoque.Controls.Add(this.btnDelete_estoq);
            this.tab_Estoque.Controls.Add(this.UpdateBDView);
            this.tab_Estoque.Controls.Add(this.btnInsert_estoq);
            this.tab_Estoque.Controls.Add(this.mtbValor_estoq);
            this.tab_Estoque.Controls.Add(this.rtDesc_estoq);
            this.tab_Estoque.Controls.Add(this.btnLimpar_estoq);
            this.tab_Estoque.Controls.Add(this.label16);
            this.tab_Estoque.Controls.Add(this.label15);
            this.tab_Estoque.Controls.Add(this.label14);
            this.tab_Estoque.Controls.Add(this.label13);
            this.tab_Estoque.Controls.Add(this.label12);
            this.tab_Estoque.Controls.Add(this.label11);
            this.tab_Estoque.Controls.Add(this.label10);
            this.tab_Estoque.Controls.Add(this.tbQtd_estoq);
            this.tab_Estoque.Controls.Add(this.tbModelo_estoq);
            this.tab_Estoque.Controls.Add(this.tbNome_estoq);
            this.tab_Estoque.Controls.Add(this.dgEstoqueSandalias);
            this.tab_Estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_Estoque.Name = "tab_Estoque";
            this.tab_Estoque.Size = new System.Drawing.Size(399, 485);
            this.tab_Estoque.TabIndex = 3;
            this.tab_Estoque.Text = "Controle de Estoque";
            this.tab_Estoque.UseVisualStyleBackColor = true;
            // 
            // tbNum_estoq
            // 
            this.tbNum_estoq.Location = new System.Drawing.Point(88, 213);
            this.tbNum_estoq.Name = "tbNum_estoq";
            this.tbNum_estoq.Size = new System.Drawing.Size(100, 20);
            this.tbNum_estoq.TabIndex = 39;
            // 
            // tbCor_estoq
            // 
            this.tbCor_estoq.Location = new System.Drawing.Point(88, 187);
            this.tbCor_estoq.Name = "tbCor_estoq";
            this.tbCor_estoq.Size = new System.Drawing.Size(100, 20);
            this.tbCor_estoq.TabIndex = 38;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(61, 21);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 37;
            this.lbl_ID.Text = "ID:";
            // 
            // tbID_estoq
            // 
            this.tbID_estoq.Location = new System.Drawing.Point(88, 18);
            this.tbID_estoq.Name = "tbID_estoq";
            this.tbID_estoq.Size = new System.Drawing.Size(100, 20);
            this.tbID_estoq.TabIndex = 19;
            // 
            // btnDelete_estoq
            // 
            this.btnDelete_estoq.Location = new System.Drawing.Point(205, 245);
            this.btnDelete_estoq.Name = "btnDelete_estoq";
            this.btnDelete_estoq.Size = new System.Drawing.Size(92, 23);
            this.btnDelete_estoq.TabIndex = 35;
            this.btnDelete_estoq.Text = "Excluir";
            this.btnDelete_estoq.UseVisualStyleBackColor = true;
            this.btnDelete_estoq.Click += new System.EventHandler(this.btnDelete_estoq_Click);
            // 
            // UpdateBDView
            // 
            this.UpdateBDView.Location = new System.Drawing.Point(303, 245);
            this.UpdateBDView.Name = "UpdateBDView";
            this.UpdateBDView.Size = new System.Drawing.Size(92, 23);
            this.UpdateBDView.TabIndex = 34;
            this.UpdateBDView.Text = "Atualizar";
            this.UpdateBDView.UseVisualStyleBackColor = true;
            this.UpdateBDView.Click += new System.EventHandler(this.btnUpdate_estoq_Click);
            // 
            // btnInsert_estoq
            // 
            this.btnInsert_estoq.Location = new System.Drawing.Point(101, 245);
            this.btnInsert_estoq.Name = "btnInsert_estoq";
            this.btnInsert_estoq.Size = new System.Drawing.Size(98, 23);
            this.btnInsert_estoq.TabIndex = 27;
            this.btnInsert_estoq.Text = "Inserir";
            this.btnInsert_estoq.UseVisualStyleBackColor = true;
            this.btnInsert_estoq.Click += new System.EventHandler(this.btnInsert_estoq_Click);
            // 
            // mtbValor_estoq
            // 
            this.mtbValor_estoq.Location = new System.Drawing.Point(278, 213);
            this.mtbValor_estoq.Name = "mtbValor_estoq";
            this.mtbValor_estoq.Size = new System.Drawing.Size(100, 20);
            this.mtbValor_estoq.TabIndex = 26;
            this.mtbValor_estoq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbValor_estoq_KeyPress);
            this.mtbValor_estoq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbValor_estoq_KeyUp);
            this.mtbValor_estoq.Leave += new System.EventHandler(this.mtbValor_estoq_Leave);
            // 
            // rtDesc_estoq
            // 
            this.rtDesc_estoq.Location = new System.Drawing.Point(88, 70);
            this.rtDesc_estoq.Name = "rtDesc_estoq";
            this.rtDesc_estoq.Size = new System.Drawing.Size(291, 83);
            this.rtDesc_estoq.TabIndex = 21;
            this.rtDesc_estoq.Text = "";
            // 
            // btnLimpar_estoq
            // 
            this.btnLimpar_estoq.Location = new System.Drawing.Point(3, 245);
            this.btnLimpar_estoq.Name = "btnLimpar_estoq";
            this.btnLimpar_estoq.Size = new System.Drawing.Size(92, 23);
            this.btnLimpar_estoq.TabIndex = 28;
            this.btnLimpar_estoq.Text = "Limpar";
            this.btnLimpar_estoq.UseVisualStyleBackColor = true;
            this.btnLimpar_estoq.Click += new System.EventHandler(this.btnLimpar_estoq_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Valor (UN):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(207, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Quantidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Descrição:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Numeração:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Cor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 164);
            this.label11.Name = "lblModelo";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Modelo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 47);
            this.label10.Name = "lblNome";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nome:";
            // 
            // tbQtd_estoq
            // 
            this.tbQtd_estoq.Location = new System.Drawing.Point(278, 187);
            this.tbQtd_estoq.Name = "tbQtd_estoq";
            this.tbQtd_estoq.Size = new System.Drawing.Size(100, 20);
            this.tbQtd_estoq.TabIndex = 25;
            // 
            // tbModelo_estoq
            // 
            this.tbModelo_estoq.Location = new System.Drawing.Point(88, 161);
            this.tbModelo_estoq.Name = "tbModelo_estoq";
            this.tbModelo_estoq.Size = new System.Drawing.Size(290, 20);
            this.tbModelo_estoq.TabIndex = 22;
            // 
            // tbNome_estoq
            // 
            this.tbNome_estoq.Location = new System.Drawing.Point(88, 44);
            this.tbNome_estoq.Name = "tbNome_estoq";
            this.tbNome_estoq.Size = new System.Drawing.Size(290, 20);
            this.tbNome_estoq.TabIndex = 20;
            // 
            // dgEstoqueSandalias
            // 
            this.dgEstoqueSandalias.AllowDrop = true;
            this.dgEstoqueSandalias.AllowUserToOrderColumns = true;
            this.dgEstoqueSandalias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoqueSandalias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sandaliaID,
            this.sandaliaNome,
            this.sandaliaModelo,
            this.sandaliaCor,
            this.sandaliaNum,
            this.sandaliaDescricao,
            this.sandaliaQuantidade,
            this.sandaliaValor});
            this.dgEstoqueSandalias.Location = new System.Drawing.Point(3, 280);
            this.dgEstoqueSandalias.Name = "dgEstoqueSandalias";
            this.dgEstoqueSandalias.ReadOnly = true;
            this.dgEstoqueSandalias.Size = new System.Drawing.Size(392, 201);
            this.dgEstoqueSandalias.TabIndex = 19;
            this.dgEstoqueSandalias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEstoqueSandalias_CellContentClick);
            // 
            // sandaliaID
            // 
            this.sandaliaID.HeaderText = "ID";
            this.sandaliaID.Name = "sandaliaID";
            this.sandaliaID.ReadOnly = true;
            this.sandaliaID.Width = 40;
            // 
            // sandaliaNome
            // 
            this.sandaliaNome.HeaderText = "Nome";
            this.sandaliaNome.Name = "sandaliaNome";
            this.sandaliaNome.ReadOnly = true;
            // 
            // sandaliaModelo
            // 
            this.sandaliaModelo.HeaderText = "Modelo";
            this.sandaliaModelo.Name = "sandaliaModelo";
            this.sandaliaModelo.ReadOnly = true;
            // 
            // sandaliaCor
            // 
            this.sandaliaCor.HeaderText = "Cor";
            this.sandaliaCor.Name = "sandaliaCor";
            this.sandaliaCor.ReadOnly = true;
            // 
            // sandaliaNum
            // 
            this.sandaliaNum.HeaderText = "Numeração";
            this.sandaliaNum.Name = "sandaliaNum";
            this.sandaliaNum.ReadOnly = true;
            // 
            // sandaliaDescricao
            // 
            this.sandaliaDescricao.HeaderText = "Descrição";
            this.sandaliaDescricao.Name = "sandaliaDescricao";
            this.sandaliaDescricao.ReadOnly = true;
            this.sandaliaDescricao.Width = 200;
            // 
            // sandaliaQuantidade
            // 
            this.sandaliaQuantidade.HeaderText = "Quantidade";
            this.sandaliaQuantidade.Name = "sandaliaQuantidade";
            this.sandaliaQuantidade.ReadOnly = true;
            // 
            // sandaliaValor
            // 
            this.sandaliaValor.HeaderText = "Valor";
            this.sandaliaValor.Name = "sandaliaValor";
            this.sandaliaValor.ReadOnly = true;
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.tab_Estoque);
            this.AllTabs.Location = new System.Drawing.Point(12, 27);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(407, 511);
            this.AllTabs.TabIndex = 7;
            this.AllTabs.Visible = false;
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
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 20);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 550);
            this.Controls.Add(this.AllTabs);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.group_entrarcomo);
            this.Name = "F_Menu";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havaianas, AS LEGÍTIMAS  –  Controle de Estoque";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            this.tab_Estoque.ResumeLayout(false);
            this.tab_Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoqueSandalias)).EndInit();
            this.AllTabs.ResumeLayout(false);
            this.group_entrarcomo.ResumeLayout(false);
            this.group_entrarcomo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tab_Estoque;
        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.RadioButton rd_gerente;
        private System.Windows.Forms.RadioButton rd_estoquista;
        private System.Windows.Forms.GroupBox group_entrarcomo;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_passenter;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.DataGridView dgEstoqueSandalias;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbQtd_estoq;
        private System.Windows.Forms.TextBox tbModelo_estoq;
        private System.Windows.Forms.TextBox tbNome_estoq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLimpar_estoq;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtDesc_estoq;
        private System.Windows.Forms.MaskedTextBox mtbValor_estoq;
        private System.Windows.Forms.Button btnInsert_estoq;
        private System.Windows.Forms.Button UpdateBDView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn sandaliaValor;
        private System.Windows.Forms.Button btnDelete_estoq;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tbID_estoq;
        private System.Windows.Forms.TextBox tbNum_estoq;
        private System.Windows.Forms.TextBox tbCor_estoq;
    }
}