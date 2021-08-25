namespace Controle_de_Estoque
{
    partial class F_Login
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
            this.btn_entrar_sistema = new System.Windows.Forms.Button();
            this.btn_cancelar_acesso = new System.Windows.Forms.Button();
            this.lb_acessar_sistema = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_entrar_sistema
            // 
            this.btn_entrar_sistema.Location = new System.Drawing.Point(250, 164);
            this.btn_entrar_sistema.Name = "btn_entrar_sistema";
            this.btn_entrar_sistema.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar_sistema.TabIndex = 0;
            this.btn_entrar_sistema.Text = "Entrar";
            this.btn_entrar_sistema.UseVisualStyleBackColor = true;
            this.btn_entrar_sistema.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar_acesso
            // 
            this.btn_cancelar_acesso.Location = new System.Drawing.Point(144, 164);
            this.btn_cancelar_acesso.Name = "btn_cancelar_acesso";
            this.btn_cancelar_acesso.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_acesso.TabIndex = 1;
            this.btn_cancelar_acesso.Text = "Cancela";
            this.btn_cancelar_acesso.UseVisualStyleBackColor = true;
            this.btn_cancelar_acesso.Click += new System.EventHandler(this.btn_cancelar_acesso_Click);
            // 
            // lb_acessar_sistema
            // 
            this.lb_acessar_sistema.AutoSize = true;
            this.lb_acessar_sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_acessar_sistema.Location = new System.Drawing.Point(29, 9);
            this.lb_acessar_sistema.Name = "lb_acessar_sistema";
            this.lb_acessar_sistema.Size = new System.Drawing.Size(339, 33);
            this.lb_acessar_sistema.TabIndex = 2;
            this.lb_acessar_sistema.Text = "Digite seu Login e Senha";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(64, 59);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(64, 20);
            this.lb_usuario.TabIndex = 3;
            this.lb_usuario.Text = "Usuario";
            this.lb_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(69, 102);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(56, 20);
            this.lb_senha.TabIndex = 4;
            this.lb_senha.Text = "Senha";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(144, 59);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(181, 20);
            this.txt_usuario.TabIndex = 5;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(144, 104);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(181, 20);
            this.txt_senha.TabIndex = 6;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 215);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_acessar_sistema);
            this.Controls.Add(this.btn_cancelar_acesso);
            this.Controls.Add(this.btn_entrar_sistema);
            this.Name = "F_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar_sistema;
        private System.Windows.Forms.Button btn_cancelar_acesso;
        private System.Windows.Forms.Label lb_acessar_sistema;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
    }
}

