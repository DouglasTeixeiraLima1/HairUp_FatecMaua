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
    public partial class DeletarServiços : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private SqlCommand comando;
        private DataTable tblcategorias;
        private string strsql, strconex;

        public DeletarServiços()
        {
            InitializeComponent();
        }

        private void DeletarServiços_Load(object sender, EventArgs e)
        {
            //Define a configuração inicial das GroupBox
            grupo1.Enabled = true; //ativa a groupbox1
            grupo2.Visible = false;// torna invisivel a groupbox2
        }

        private void grupo1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btexcluir_Click(object sender, EventArgs e)
        {

            //Faz a conexão com o banco de dados
            strconex = "data source=localhost\\SQLEXPRESS;initial catalog=HairUp;" +
                                                "integrated security=sspi";
            conexao = new SqlConnection(strconex);
            conexao.Open();

            //instância o DataTable
            tblcategorias = new DataTable();

            //Define através do código da categoria o registro
            //que será exibido 
            strsql = "select * from Servicos where id_servico='" +
                                                txtcodservico.Text + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblcategorias);


            //se a quantidade de registros for igla a 1,
            if (tblcategorias.Rows.Count == 1)
            {
                //mostra o conteúdo das colunas nas caixas de texto 
                txtcodservico.Text = tblcategorias.Rows[0]["id_servico"].ToString();
                txtnomeservico.Text = tblcategorias.Rows[0]["nome_servico"].ToString();
                txtdescricao.Text = tblcategorias.Rows[0]["descricao"].ToString();
                txtpreco.Text = tblcategorias.Rows[0]["preco"].ToString();
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

        private void btnao_Click(object sender, EventArgs e)
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;
        }

        private void btsim_Click(object sender, EventArgs e)
        {
            try
            {
                grupo1.Enabled = true;
                grupo2.Visible = false;

                // APAGA PRIMEIRO DA AGENDA
                strsql = "delete from Agenda " +
                         "where id_servico='" +
                         txtcodservico.Text + "'";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();

                // DEPOIS APAGA O SERVIÇO
                strsql = "delete from Servicos " +
                         "where id_servico='" +
                         txtcodservico.Text + "'";

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
private void txtcodservico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
       e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
