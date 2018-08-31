using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using MySql.Data.MySqlClient;

namespace teste_Cep
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            txtId.Visible = false;
            lblId.Visible = false;
            
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Correios.AtendeClienteClient consulta = new
                    Correios.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(txtCep.Text);
                if (resultado != null)
                {
                    txtEndereco.Text = resultado.end;
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtUf.Text = resultado.uf;
                    
                }
                txtCep.Focus();
                
            }
            catch (FaultException)
            {
                //Mensagem de CEP invalido
                MessageBox.Show("CEP NÃO ENCONTRADO OU INVALIDO.","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possivel completar a operação" +
                    "\nVerifique sua conexão com a internet","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtUf.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCep != null)
            {
                MessageBox.Show("Preencha os campos", "atenção");
            }
            else
            {
                MessageBox.Show("Correto", "ATENÇÃO");
            }

            MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_cep;Uid=root;Pwd=usbw;");

            conexao.Open();

            MySqlCommand comando;
            if (txtId.Text == String.Empty)
            {
                comando = new MySqlCommand("INSERT INTO tb_cep(ID, CEP, UF, BAIRRO, CIDADE, ENDERECO)"+"VALUES('" + txtId.Text + "','" + txtCep.Text + "','" + txtUf.Text + "','" + txtBairro.Text + "','" + txtCidade.Text + "','" + txtEndereco.Text + "');", conexao);

            }
            else
            {
                comando = new MySqlCommand("Update tb_cep SET CEP = '" + txtCep.Text + "' ,UF='" + txtUf.Text + "' ,BAIRRO='" + txtBairro.Text + "' ,CIDADE='" + txtCidade.Text + "' ,ENDERECO='" + txtEndereco.Text + "' WHERE ID='" + txtId.Text + "'", conexao);
            }
            comando.ExecuteNonQuery();
            conexao.Close();


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view tela = new view(this);
            tela.Show();
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnRetorna_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_cep;Uid=root;Pwd=usbw;");

            conexao.Open();

            MySqlCommand pesquisa = new MySqlCommand("SELECT * FROM tb_cep", conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(pesquisa);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgv.DataSource = dt;

            conexao.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            string cep = dgv.CurrentRow.Cells[1].Value.ToString();
            string uf = dgv.CurrentRow.Cells[2].Value.ToString();
            string bairro = dgv.CurrentRow.Cells[3].Value.ToString();
            string cidade = dgv.CurrentRow.Cells[4].Value.ToString();
            string endereco = dgv.CurrentRow.Cells[5].Value.ToString();

            txtId.Text = id.ToString();
            txtCep.Text = cep;
            txtUf.Text = uf;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtEndereco.Text = endereco;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtIdDel.Visible = true;
            MySqlConnection conexao = new MySqlConnection("Persist Security info=False;Server=127.0.0.1;Port=3307;" + "Database=bd_cep;Uid=root;Pwd=usbw;");

            conexao.Open();

            MySqlCommand deletar = new MySqlCommand("DELETE FROM tb_cep WHERE ID='" + txtId.Text + "';", conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(deletar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            conexao.Close();
        }

        private void btnEnde_Click(object sender, EventArgs e)
        {
            try
            {
                Correios.AtendeClienteClient consulta = new
                    Correios.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(txtEndereco.Text);
                if (resultado != null)
                {
                    txtEndereco.Text = resultado.end;
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtUf.Text = resultado.uf;

                }
                txtEndereco.Focus();

            }
            catch (FaultException)
            {
                //Mensagem de CEP invalido
                MessageBox.Show("CEP NÃO ENCONTRADO OU INVALIDO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possivel completar a operação" +
                    "\nVerifique sua conexão com a internet", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
