using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HairUp
{
    public partial class CadastrarAgenda : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter, adapter2, adapter3;
        private DataTable tblclientes, tblprofissionais, tblservicos;
        //private DataTable tblprofissionais;
        //private DataTable tblservicos;
        private SqlCommand comando;
        private string strsql, strsql2, strsql3,strconex;

        private void cboboxcodservico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcodservico.Text = cboboxcodservico.SelectedValue.ToString();
        }

        private void cboboxcodprofissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcodprofissional.Text = cboboxcodprofissional.SelectedValue.ToString();
        }

        private void lblcodcliente_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarAgenda_Load(object sender, EventArgs e)
        {
            strconex = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=HairUp;Integrated Security=True;";
            conexao = new SqlConnection(strconex);
            conexao.Open();
            tblclientes = new DataTable();
            tblprofissionais = new DataTable();
            tblservicos = new DataTable();

            strsql = "select * from clientes";
            strsql2 = "select * from profissionais";
            strsql3 = "select * from servicos";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter2 = new SqlDataAdapter(strsql2, conexao);
            adapter3 = new SqlDataAdapter(strsql3, conexao);
            adapter.Fill(tblclientes);
            adapter2.Fill(tblprofissionais);
            adapter3.Fill(tblservicos);

            cboboxcodcliente.DataSource = tblclientes;
            cboboxcodcliente.DisplayMember = "nome";
            cboboxcodcliente.ValueMember = "id_cliente";
            lblcodcliente.Text = cboboxcodcliente.SelectedValue.ToString();

            cboboxcodprofissional.DataSource = tblprofissionais;
            cboboxcodprofissional.DisplayMember = "nome";
            cboboxcodprofissional.ValueMember = "id_profissional";
            lblcodprofissional.Text = cboboxcodprofissional.SelectedValue.ToString();

            cboboxcodservico.DataSource = tblservicos;
            cboboxcodservico.DisplayMember = "nome_servico";
            cboboxcodservico.ValueMember = "id_servico";
            lblcodservico.Text = cboboxcodservico.SelectedValue.ToString();
        }

        private void cboboxcodcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboboxcodcliente.SelectedValue != null &&
       cboboxcodcliente.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                lblcodcliente.Text =
                    cboboxcodcliente.SelectedValue.ToString();
            }
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                strsql = "insert into agenda " +
                "(id_cliente, id_servico, id_profissional, data_agenda, hora) " +
                "values ('" +
                cboboxcodcliente.SelectedValue + "','" +
                cboboxcodservico.SelectedValue + "','" +
                cboboxcodprofissional.SelectedValue + "','" +
                mtbagenda.Text + "','" +
                mtbhora.Text + "')";
                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro ao gravar," + er.Message, "mensagem",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            MessageBox.Show("Encerrado o cadastro na agenda!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        public CadastrarAgenda()
        {
            InitializeComponent();
        }
    }
}
