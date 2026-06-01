using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairUp
{
    public partial class AtualizarServicos : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblservicos;

        private string strsql;
        private string strconex;


        public AtualizarServicos()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AtualizarServicos_Load(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                strconex = @"Data Source=.\SQLEXPRESS;
                             Initial Catalog=HairUp;
                             Integrated Security=True";


                conexao = new SqlConnection(strconex);
                conexao.Open();

                tblservicos = new DataTable();

                strsql = "select * from servicos where id_servico='" +
                          txtcodservico.Text + "'";

                adapter = new SqlDataAdapter(strsql, conexao);

                adapter.Fill(tblservicos);

                if (tblservicos.Rows.Count == 1)
                {
                    txtnomeservico.Text =
                        tblservicos.Rows[0]["nome_servico"].ToString();

                    txtdescricao.Text =
                        tblservicos.Rows[0]["descricao"].ToString();

                    txtpreco.Text =
                        tblservicos.Rows[0]["preco"].ToString();

                    grupo1.Enabled = false;
                    grupo2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Serviço não encontrado.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void btalterar_Click(object sender, EventArgs e)
        {
            try
            {
                grupo1.Enabled = true;
                grupo2.Visible = false;

                strsql = "update servicos set " +
                         "nome_servico='" + txtnomeservico.Text + "'," +
                         "descricao='" + txtdescricao.Text + "'," +
                         "preco=" + txtpreco.Text.Replace(",", ".") +
                         " where id_servico='" +
                         txtcodservico.Text + "'"; ;

                comando = new SqlCommand(strsql, conexao);

                comando.ExecuteNonQuery();

                MessageBox.Show("Serviço alterado com sucesso.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar: " + erro,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;

            txtnomeservico.Clear();
            txtdescricao.Clear();
            txtpreco.Clear();
        }

        private void txtcodservico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
       e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
