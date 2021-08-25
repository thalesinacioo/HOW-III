using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class F_Cadastro : Form
    {
        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_voltar_cadastro_menu_Click(object sender, EventArgs e)
        {
            F_Menu voltarmenu = new F_Menu();
            voltarmenu.ShowDialog();
            this.Close();
        }
    }
}
