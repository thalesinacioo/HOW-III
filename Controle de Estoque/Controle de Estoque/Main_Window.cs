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
            list_Numeracao.Items.AddRange(
                new object[]
                {
                    "17","18","19","20","21","22"                      /*  babylist    */
                }
            );
        }
        private void kidslist()
        {
            list_Numeracao.Items.Clear();
            list_Numeracao.Items.AddRange(
                 new object[]
                 {
                    "23","24","25","26","27","28","29","30","31","32"    /*  kidslist    */
                 });
        }
        private void adultlist()
        {
            list_Numeracao.Items.Clear();
            list_Numeracao.Items.AddRange(
                new object[]
                {
                    "33","34","35","36","37","38","39","40",    /*  adultlist   */
                    "41","42","43","44","45","46","47"
                });
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

        private void btn_AdicionarModelo_Click_1(object sender, EventArgs e)
        {
            if (txt_NomeNovoModelo.Text != "") list_Modelo.Items.Add(txt_NomeNovoModelo.Text);
            list_NovaLista.Items.Clear();

            int i,
                f_inicial = Convert.ToInt32(NumFaixa_INICIAL.Text),
                f_final = Convert.ToInt32(NumFaixa_FINAL.Text);
            for (i = f_inicial; i <= f_final; i++) list_NovaLista.Items.Add(i);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void list_Numeracao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_Modelo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (list_Modelo.SelectedIndex == 0) babylist();
            if (list_Modelo.SelectedIndex == 1) kidslist();
            if (list_Modelo.SelectedIndex == 2) adultlist();
            if (list_Modelo.SelectedIndex == 3) adultlist();
            //if (list_Modelo.SelectedIndex == ModelosNovosLista.Rows[0]) ;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
