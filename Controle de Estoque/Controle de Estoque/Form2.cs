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
            this.Close();

        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            F_Cadastro novofcadastro = new F_Cadastro();
            novofcadastro.ShowDialog();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }

        private void tab_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void F_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Modelo.SelectedIndex == 0)
            {
                list_Numeracao.Items.Clear();
                list_Numeracao.Items.Add("33");
                list_Numeracao.Items.Add("34");
                list_Numeracao.Items.Add("35");
                list_Numeracao.Items.Add("36");
                list_Numeracao.Items.Add("37");
                list_Numeracao.Items.Add("38");
                list_Numeracao.Items.Add("39");
                list_Numeracao.Items.Add("40");
                list_Numeracao.Items.Add("41");
                list_Numeracao.Items.Add("42");
                list_Numeracao.Items.Add("43");
                list_Numeracao.Items.Add("44");
                list_Numeracao.Items.Add("45");
                list_Numeracao.Items.Add("46");
                list_Numeracao.Items.Add("47");
            }
            if (list_Modelo.SelectedIndex == 1) {
                list_Numeracao.Items.Clear();
                list_Numeracao.Items.Add("33");
                list_Numeracao.Items.Add("34");
                list_Numeracao.Items.Add("35");
                list_Numeracao.Items.Add("36");
                list_Numeracao.Items.Add("37");
                list_Numeracao.Items.Add("38");
                list_Numeracao.Items.Add("39");
                list_Numeracao.Items.Add("40");
                list_Numeracao.Items.Add("41");
                list_Numeracao.Items.Add("42");
                list_Numeracao.Items.Add("43");
                list_Numeracao.Items.Add("44");
                list_Numeracao.Items.Add("45");
                list_Numeracao.Items.Add("46");
                list_Numeracao.Items.Add("47");
            }
            if (list_Modelo.SelectedIndex == 2)
            {
                list_Numeracao.Items.Clear();
                list_Numeracao.Items.Add("23");
                list_Numeracao.Items.Add("24");
                list_Numeracao.Items.Add("25");
                list_Numeracao.Items.Add("26");
                list_Numeracao.Items.Add("27");
                list_Numeracao.Items.Add("28");
                list_Numeracao.Items.Add("29");
                list_Numeracao.Items.Add("30");
                list_Numeracao.Items.Add("31");
                list_Numeracao.Items.Add("32");
            }
            if (list_Modelo.SelectedIndex == 3)
            {
                list_Numeracao.Items.Clear();
                list_Numeracao.Items.Add("17");
                list_Numeracao.Items.Add("18");
                list_Numeracao.Items.Add("19");
                list_Numeracao.Items.Add("20");
                list_Numeracao.Items.Add("21");
                list_Numeracao.Items.Add("22");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            group_AddModelo.Visible = true;
            btn_CancelaAddModelo.Visible = true;
        }

        private void btn_AdicionarModelo_Click(object sender, EventArgs e)
        {
            group_AddModelo.Visible = false;
            btn_CancelaAddModelo.Visible = false;
            if(txt_NomeNovoModelo.Text != "")list_Modelo.Items.Add(txt_NomeNovoModelo.Text);
        }

        private void btn_CancelaAddModelo_Click(object sender, EventArgs e)
        {
            group_AddModelo.Visible = false;
            btn_CancelaAddModelo.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
