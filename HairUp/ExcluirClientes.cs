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
    public partial class ExcluirClientes : Form
    {

        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblcategorias;
        private string strsql, strconex;


        public ExcluirClientes()
        {
            InitializeComponent();
        }

        private void ExcluirClientes_Load(object sender, EventArgs e)
        {
            //Define a configuração inicial das GroupBox
            grupo1.Enabled = true; //ativa a groupbox1
            grupo2.Visible = false;// torna invisivel a groupbox2

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnao_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {
            //No botao BtExcluir 

            //Faz a conexão com o banco de dados
            strconex = "data source=localhost\\SQLEXPRESS;initial catalog=HairUp;" +
                                                "integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            //instância o DataTable
            tblcategorias = new DataTable();

            //Define através do código da categoria o registro
            //que será exibido 
            strsql = "select * from Clientes where id_cliente='" +
                                                txtcodcliente.Text + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblcategorias);


            //se a quantidade de registros for igla a 1,
            if (tblcategorias.Rows.Count == 1)
            {
                //mostra o conteúdo das colunas nas caixas de texto 
                txtcodcliente.Text = tblcategorias.Rows[0]["id_cliente"].ToString();
                txtnome.Text = tblcategorias.Rows[0]["nome"].ToString();
                mtbcpf.Text = tblcategorias.Rows[0]["cpf"].ToString();
                mtbcelular.Text = tblcategorias.Rows[0]["celular"].ToString();
                txtemail.Text = tblcategorias.Rows[0]["email"].ToString();
                grupo1.Enabled = false;
                grupo2.Visible = true;
            }
            else
            {
                //      mostra mensagem de erro
                MessageBox.Show("Registro não encontrado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btsim_Click(object sender, EventArgs e)
        {
            try
            {
                grupo1.Enabled = true;
                grupo2.Visible = false;

                // APAGA PRIMEIRO DA AGENDA
                strsql = "delete from Agenda " +
                         "where id_cliente='" +
                         txtcodcliente.Text + "'";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();

                // DEPOIS APAGA O CLIENTE
                strsql = "delete from Clientes " +
                         "where id_cliente='" +
                         txtcodcliente.Text + "'";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluído com sucesso.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Registro não pode ser excluído. " +
                er.Message,
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            }


        }
    }
}
