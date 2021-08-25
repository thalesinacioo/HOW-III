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
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_Estoque = new System.Windows.Forms.Button();
            this.Btn_Vendas = new System.Windows.Forms.Button();
            this.btn_Compras = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Location = new System.Drawing.Point(24, 23);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(174, 55);
            this.btn_Cadastro.TabIndex = 0;
            this.btn_Cadastro.Text = "Cadastro";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cadastro_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.Location = new System.Drawing.Point(311, 132);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(174, 55);
            this.btn_relatorios.TabIndex = 1;
            this.btn_relatorios.Text = "Relatorios";
            this.btn_relatorios.UseVisualStyleBackColor = true;
            // 
            // btn_Estoque
            // 
            this.btn_Estoque.Location = new System.Drawing.Point(24, 132);
            this.btn_Estoque.Name = "btn_Estoque";
            this.btn_Estoque.Size = new System.Drawing.Size(174, 55);
            this.btn_Estoque.TabIndex = 2;
            this.btn_Estoque.Text = "Estoque";
            this.btn_Estoque.UseVisualStyleBackColor = true;
            // 
            // Btn_Vendas
            // 
            this.Btn_Vendas.Location = new System.Drawing.Point(568, 23);
            this.Btn_Vendas.Name = "Btn_Vendas";
            this.Btn_Vendas.Size = new System.Drawing.Size(174, 55);
            this.Btn_Vendas.TabIndex = 3;
            this.Btn_Vendas.Text = "Vendas";
            this.Btn_Vendas.UseVisualStyleBackColor = true;
            // 
            // btn_Compras
            // 
            this.btn_Compras.Location = new System.Drawing.Point(311, 23);
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Size = new System.Drawing.Size(174, 55);
            this.btn_Compras.TabIndex = 4;
            this.btn_Compras.Text = "Compras";
            this.btn_Compras.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(568, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 55);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(575, 368);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(167, 33);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Compras);
            this.Controls.Add(this.Btn_Vendas);
            this.Controls.Add(this.btn_Estoque);
            this.Controls.Add(this.btn_relatorios);
            this.Controls.Add(this.btn_Cadastro);
            this.Name = "F_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_Estoque;
        private System.Windows.Forms.Button Btn_Vendas;
        private System.Windows.Forms.Button btn_Compras;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Sair;
    }
}