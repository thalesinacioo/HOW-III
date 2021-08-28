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
    public partial class F_Menu : Form
    {
        private Form3 form3;

        public F_Menu()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close(); //comentario

        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            F_Cadastro novofcadastro = new F_Cadastro();
            novofcadastro.ShowDialog();

        }
    }
}
