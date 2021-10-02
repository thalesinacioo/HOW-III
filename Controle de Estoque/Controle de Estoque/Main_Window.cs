using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using MySql.Data.MySqlClient; // MySQL Client [OK]

namespace Controle_de_Estoque
{
    public partial class F_Menu : Form
    {

        public F_Menu(){ InitializeComponent(); }

        private MySqlConnectionStringBuilder connectionDB() // Conexão com Banco de Dados [OK]
        {
            MySqlConnectionStringBuilder connectionDB = new MySqlConnectionStringBuilder();
            connectionDB.Server     =   "127.0.0.1";
            connectionDB.Database   =   "sandaliashavaianas";
            connectionDB.UserID     =   "root";
            connectionDB.Password   =   "";
            connectionDB.SslMode    =   0;
            return connectionDB;
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void refreshDataGrid()  // Função que atualiza a tabela
        {
            MySqlConnectionStringBuilder connDB = connectionDB();
            MySqlConnection mkconnDB = new MySqlConnection(connDB.ToString());
            try
            {
                mkconnDB.Open();
                MySqlCommand commMySQL = mkconnDB.CreateCommand();
                commMySQL.CommandText = "SELECT * FROM estoquesandalias WHERE ativoSandalia = 1";
                MySqlDataReader reader = commMySQL.ExecuteReader();
                dgEstoqueSandalias.Rows.Clear();
                while(reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgEstoqueSandalias.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);    // ID
                    row.Cells[1].Value = reader.GetString(1);   // Nome
                    row.Cells[2].Value = reader.GetString(2);   // Modelo
                    row.Cells[3].Value = reader.GetString(3);   // Cor
                    row.Cells[4].Value = reader.GetString(4);   // Numeração
                    row.Cells[5].Value = reader.GetString(5);   // Descrição
                    row.Cells[6].Value = reader.GetInt32(6);    // Quantidade
                    row.Cells[7].Value = reader.GetString(7);   // Valor
                    dgEstoqueSandalias.Rows.Add(row);           // Add line to the table
                }
                mkconnDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível abrir conexão!");
                Console.WriteLine(ex.Message);
            }
        }

        private void clearEstoqFields()     // Limpa os campos da aba estoque
        {
            tbID_estoq.Clear();
            tbNome_estoq.Clear();
            rtDesc_estoq.Clear();
            tbModelo_estoq.Clear();
            tbCor_estoq.Clear();
            tbQtd_estoq.Clear();
            tbNum_estoq.Clear();
            mtbValor_estoq.Clear();
        }

        private void btnLimpar_estoq_Click(object sender, EventArgs e) { clearEstoqFields(); }

        int btnCRUDClicked;
        private void btnCRUD()
        {
            MySqlConnectionStringBuilder connDB = connectionDB();
            MySqlConnection mkconnDB = new MySqlConnection(connDB.ToString());
            try
            {
                mkconnDB.Open();
                MySqlCommand commMySQL = mkconnDB.CreateCommand();
                if (btnCRUDClicked == 0) // INSERIR
                {
                    commMySQL.CommandText = "INSERT INTO estoquesandalias " +
                        "(nomeSandalia, descSandalia, modeloSandalia, corSandalia, qtdSandalia, numSandalia, valorSandalia)" +
                        "VALUES('" +
                        tbNome_estoq.Text + "', '" +                        // Nome
                        rtDesc_estoq.Text + "', '" +                        // Descrição
                        tbModelo_estoq.Text + "', '" +                      // Modelo
                        tbCor_estoq.Text + "', '" +                         // Cor
                        Convert.ToInt16(tbQtd_estoq.Text) + "', '" +        // Qtd
                        tbNum_estoq.Text + "', '" +                         // Numeração
                        mtbValor_estoq.Text + "')";                         // Valor
                    Console.WriteLine("Inserido no estoque com sucesso!");

                } else if (btnCRUDClicked == 1) // ATUALIZAR
                {
                    commMySQL.CommandText = "UPDATE estoquesandalias SET " +
                        // "idSandalia = '" + tbID_estoq.Text + "', " +
                        "nomeSandalia = '" + tbNome_estoq.Text + "', " +
                        "descSandalia = '" + rtDesc_estoq.Text + "', " +
                        "modeloSandalia = '" + tbModelo_estoq.Text + "', " +
                        "corSandalia = '" + tbCor_estoq.Text + "', " +
                        "qtdSandalia = '" + Convert.ToInt16(tbQtd_estoq.Text) + "', " +
                        "numSandalia = '" + tbNum_estoq.Text + "', " +
                        "valorSandalia = '" + mtbValor_estoq.Text + "' " +
                        "WHERE estoquesandalias.idSandalia = " + tbID_estoq.Text;
                    Console.WriteLine("Inserido no estoque com sucesso!");

                } else if (btnCRUDClicked == 2) // DELETAR
                {
                    commMySQL.CommandText = "DELETE FROM estoquesandalias WHERE estoquesandalias.idSandalia = " + tbID_estoq.Text;
                    MessageBox.Show("Excluído com sucesso!");
                }
                commMySQL.ExecuteNonQuery();
                mkconnDB.Close();
                refreshDataGrid();      // Função que atualiza a tabela para quando o item for inserido;
                clearEstoqFields();     // Limpa os campos digitados para a inserção;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Erro!");
                refreshDataGrid();
                clearEstoqFields();
            }
        }
        private void btnInsert_estoq_Click(object sender, EventArgs e) // Botão 'INSERIR'
        {
            btnCRUDClicked = 0;
            btnCRUD();
        }
        private void btnUpdate_estoq_Click(object sender, EventArgs e) // Botão 'ATUALIZAR'
        {
            btnCRUDClicked = 1;
            btnCRUD();
        }
        private void btnDelete_estoq_Click(object sender, EventArgs e) // Botão 'EXCLUIR'
        {
            btnCRUDClicked = 2;
            btnCRUD();
        }
        private void dgEstoqueSandalias_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento ao clicar num item da tabela
        {
            if (dgEstoqueSandalias.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgEstoqueSandalias.CurrentRow.Selected = true;
                tbNome_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaNome"].FormattedValue.ToString();
                rtDesc_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaDescricao"].FormattedValue.ToString();
                tbModelo_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaModelo"].FormattedValue.ToString();
                tbCor_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaCor"].FormattedValue.ToString();
                tbNum_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaNum"].FormattedValue.ToString();
                tbQtd_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaQuantidade"].FormattedValue.ToString();
                mtbValor_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaValor"].FormattedValue.ToString();
                tbID_estoq.Text = dgEstoqueSandalias.Rows[e.RowIndex].Cells["sandaliaID"].FormattedValue.ToString();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {   // Função para quando der 'Enter' no teclado após digitar a senha
            if (e.KeyCode == Keys.Enter)
            {
                passenter_Click((object)sender, (EventArgs)e);
            }
        }

        private void rdGerente_CheckedChanged(object sender, EventArgs e)
        {   //  RadioButton Gerente quando selecionado
            AllTabs.Visible = false;
        }

        private void rdEstoquista_CheckedChanged(object sender, EventArgs e)
        {   //  RadioButton Estoquista quando selecionado
            AllTabs.Visible = false;
        }

        private void wrongPass()
        {   //  Função para quando a senha digitada estiver incorreta
            txt_pass.Clear();
            AllTabs.Visible = false;
            MessageBox.Show
                ("Senha incorreta.\nPor favor, tente novamente.");
        }

        private void passenter_Click(object sender, EventArgs e) //  Validação de senhas para dois usuários distintos
        {   
            string passestoquista = "123",
                   passgerente = "456";

            if (rd_gerente.Checked == true || rd_estoquista.Checked == true)
            {
                if (txt_pass.Text == passgerente || txt_pass.Text == passestoquista)
                {
                    if (txt_pass.Text == passestoquista) btnInsert_estoq.Visible = false; else btnInsert_estoq.Visible = true;
                    if (txt_pass.Text == passestoquista) btnDelete_estoq.Visible = false; else btnDelete_estoq.Visible = true;
                    if (txt_pass.Text == passgerente && rd_estoquista.Checked == true) wrongPass(); else AllTabs.Visible = true;
                    txt_pass.Clear();
                }
                else wrongPass();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) { AllTabs.Visible = false; }
        private void btnSair_Click(object sender, EventArgs e) { Application.Exit(); }

        // Aqui, criei um método para mascarar o campo de valor

        string CampoValor;
        private void mtbValor_estoq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',') e.Handled = (mtbValor_estoq.Text.Contains(",")); e.Handled = true;
            }
        }

        private void mtbValor_estoq_Leave(object sender, EventArgs e)
        {
            CampoValor = mtbValor_estoq.Text.Replace("R$", "");
            mtbValor_estoq.Text = string.Format("{0:C}", Convert.ToDouble(CampoValor));
        }

        private void mtbValor_estoq_KeyUp(object sender, KeyEventArgs e)
        {
            CampoValor = mtbValor_estoq.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (CampoValor.Length == 0) mtbValor_estoq.Text = "0,00" + CampoValor;
            if (CampoValor.Length == 1) mtbValor_estoq.Text = "0,0" + CampoValor;
            if (CampoValor.Length == 2)
            {
                mtbValor_estoq.Text = "0," + CampoValor;
            }
            else if (CampoValor.Length >= 3)
            {
                if (mtbValor_estoq.Text.StartsWith("0,"))
                {
                    mtbValor_estoq.Text = CampoValor.Insert(CampoValor.Length - 2, ",").Replace("0,", "");
                }
                else if (mtbValor_estoq.Text.Contains("00,"))
                {
                    mtbValor_estoq.Text = CampoValor.Insert(CampoValor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    mtbValor_estoq.Text = CampoValor.Insert(CampoValor.Length - 2, ",");
                }
            }
            CampoValor = mtbValor_estoq.Text;
            mtbValor_estoq.Text = string.Format("{0:C}", Convert.ToDouble(CampoValor));
            mtbValor_estoq.Select(mtbValor_estoq.Text.Length, 0);
        }
    }
}
