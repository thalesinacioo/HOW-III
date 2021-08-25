namespace Controle_de_Estoque
{
    partial class F_Cadastro
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
            this.btn_voltar_cadastro_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(600, 390);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(167, 33);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_voltar_cadastro_menu
            // 
            this.btn_voltar_cadastro_menu.Location = new System.Drawing.Point(47, 390);
            this.btn_voltar_cadastro_menu.Name = "btn_voltar_cadastro_menu";
            this.btn_voltar_cadastro_menu.Size = new System.Drawing.Size(167, 33);
            this.btn_voltar_cadastro_menu.TabIndex = 8;
            this.btn_voltar_cadastro_menu.Text = "Voltar";
            this.btn_voltar_cadastro_menu.UseVisualStyleBackColor = true;
            this.btn_voltar_cadastro_menu.Click += new System.EventHandler(this.btn_voltar_cadastro_menu_Click);
            // 
            // F_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar_cadastro_menu);
            this.Controls.Add(this.btn_Sair);
            this.Name = "F_Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_voltar_cadastro_menu;
    }
}