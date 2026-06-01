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
    public partial class AtualizarClientes : Form
    {

        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblclientes;

        private string strsql;
        private string strconex;

        public AtualizarClientes()
        {
            InitializeComponent();
        }

        private void AtualizarClientes_Load(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;

            txtnome.Clear();
            mtbcpf.Clear();
            mtbcelular.Clear();
            txtemail.Clear();
        }

        private void txtcodcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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

                tblclientes = new DataTable();

                strsql = "select * from clientes where id_cliente='" +
                          txtcodcliente.Text + "'";

                adapter = new SqlDataAdapter(strsql, conexao);

                adapter.Fill(tblclientes);

                if (tblclientes.Rows.Count == 1)
                {
                    txtnome.Text =
                        tblclientes.Rows[0]["nome"].ToString();

                    mtbcpf.Text =
                        tblclientes.Rows[0]["cpf"].ToString();

                    mtbcelular.Text =
                        tblclientes.Rows[0]["celular"].ToString();

                    txtemail.Text =
                        tblclientes.Rows[0]["email"].ToString();

                    grupo1.Enabled = false;
                    grupo2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.",
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btalterar_Click(object sender, EventArgs e)
        {
            try
            {
                grupo1.Enabled = true;
                grupo2.Visible = false;

                strsql = "update clientes set " +
                         "nome='" + txtnome.Text + "'," +
                         "cpf='" + mtbcpf.Text + "'," +
                         "celular='" + mtbcelular.Text + "'," +
                         "email='" + txtemail.Text + "'" +
                         " where id_cliente='" +
                         txtcodcliente.Text + "'";

                comando = new SqlCommand(strsql, conexao);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso.",
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

        private void txtcodcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
      e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
