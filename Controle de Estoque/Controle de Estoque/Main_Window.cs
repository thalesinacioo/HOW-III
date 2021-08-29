using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * para depois: 
 * using MySql.Data.MySqlClient;
 */



namespace Controle_de_Estoque
{
    public partial class F_Menu : Form
    {
        
        public F_Menu()
        {
            InitializeComponent();
        }
        
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        /*
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }
        */
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
        private void babylist()
        {
            list_Numeracao.Items.Clear();
            list_Numeracao.Items.Add("17");
            list_Numeracao.Items.Add("18");
            list_Numeracao.Items.Add("19");
            list_Numeracao.Items.Add("20");
            list_Numeracao.Items.Add("21");
            list_Numeracao.Items.Add("22");
        }
        private void kidslist()
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
        private void adultlist()
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
        private void list_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Modelo.SelectedIndex == 0) adultlist();
            if (list_Modelo.SelectedIndex == 1) adultlist(); 
            if (list_Modelo.SelectedIndex == 2) kidslist();
            if (list_Modelo.SelectedIndex == 3) babylist();
            if (list_Modelo.SelectedIndex == list_Modelo.Items.Count-1){} ;
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

        }

        private void btn_AdicionarModelo_Click(object sender, EventArgs e)
        {
            if(txt_NomeNovoModelo.Text != "") list_Modelo.Items.Add(txt_NomeNovoModelo.Text);
            list_NovaLista.Items.Clear();

            int i,
                f_inicial = Convert.ToInt32(NumFaixa_INICIAL.Text), 
                f_final = Convert.ToInt32(NumFaixa_FINAL.Text);
            for (i = f_inicial; i <= f_final; i++) list_NovaLista.Items.Add(i);            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_NomeNovoModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AdicionarModelo_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
