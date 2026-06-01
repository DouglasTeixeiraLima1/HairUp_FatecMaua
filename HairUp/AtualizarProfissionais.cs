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
    public partial class AtualizarProfissionais : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblprofissionais;

        private string strsql;
        private string strconex;



        public AtualizarProfissionais()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarProfissionais_Load(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                strconex = @"Data Source=.\SQLEXPRESS;
                             Initial Catalog=HairUp;
                             Integrated Security=True";


                conexao = new SqlConnection(strconex);
                conexao.Open();

                tblprofissionais = new DataTable();

                strsql = "select * from profissionais where id_profissional='" +
                          txtcodprofissional.Text + "'";

                adapter = new SqlDataAdapter(strsql, conexao);

                adapter.Fill(tblprofissionais);

                if (tblprofissionais.Rows.Count == 1)
                {
                    txtnome.Text =
                        tblprofissionais.Rows[0]["nome"].ToString();

                    mtbcelular.Text =
                        tblprofissionais.Rows[0]["celular"].ToString();

                    mtbcpf.Text =
                        tblprofissionais.Rows[0]["cpf"].ToString();

                    txtcargo.Text =
                        tblprofissionais.Rows[0]["cargo"].ToString();

                    grupo1.Enabled = false;
                    grupo2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Profissional não encontrado.",
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btalterar_Click(object sender, EventArgs e)
        {
            try
            {
                grupo1.Enabled = true;
                grupo2.Visible = false;

                strsql = "update profissionais set " +
                         "nome='" + txtnome.Text + "'," +
                         "celular='" + mtbcelular.Text + "'," +
                         "cpf='" + mtbcpf.Text + "'," +
                         "cargo='" + txtcargo.Text + "'" +
                         " where id_profissional='" +
                         txtcodprofissional.Text + "'";

                comando = new SqlCommand(strsql, conexao);

                comando.ExecuteNonQuery();

                MessageBox.Show("Profissional alterado com sucesso.",
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

            txtnome.Clear();
            mtbcelular.Clear();
            mtbcpf.Clear();
            txtcargo.Clear();
        }

        private void txtcodprofissional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
       e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
