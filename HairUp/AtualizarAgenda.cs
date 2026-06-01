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
    public partial class AtualizarAgenda : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter, adapter2, adapter3;
        private SqlCommand comando;

        private DataTable tblagenda;
        private DataTable tblclientes;
        private DataTable tblprofissionais;
        private DataTable tblservicos;

        private string strsql;
        private string strconex;

        
        private bool carregando = false;


        public AtualizarAgenda()
        {
            InitializeComponent();
        }

        private void AtualizarAgenda_Load(object sender, EventArgs e)
        {

            grupo1.Enabled = true;
            grupo2.Visible = false;

            strconex = @"Data Source=.\SQLEXPRESS;
                         Initial Catalog=HairUp;
                         Integrated Security=True";

            conexao = new SqlConnection(strconex);
            conexao.Open();

            tblclientes = new DataTable();
            tblprofissionais = new DataTable();
            tblservicos = new DataTable();

            adapter = new SqlDataAdapter("SELECT * FROM clientes", conexao);
            adapter2 = new SqlDataAdapter("SELECT * FROM profissionais", conexao);
            adapter3 = new SqlDataAdapter("SELECT * FROM servicos", conexao);

            adapter.Fill(tblclientes);
            adapter2.Fill(tblprofissionais);
            adapter3.Fill(tblservicos);

            carregando = true;

            cboboxcodcliente.DataSource = tblclientes;
            cboboxcodcliente.DisplayMember = "nome";
            cboboxcodcliente.ValueMember = "id_cliente";

            cboboxcodprofissional.DataSource = tblprofissionais;
            cboboxcodprofissional.DisplayMember = "nome";
            cboboxcodprofissional.ValueMember = "id_profissional";

            cboboxcodservico.DataSource = tblservicos;
            cboboxcodservico.DisplayMember = "nome_servico";
            cboboxcodservico.ValueMember = "id_servico";

            carregando = false;

            AtualizarLabels();
        }

        private void AtualizarLabels()
        {
            if (cboboxcodcliente.SelectedValue != null &&
                cboboxcodcliente.SelectedValue.ToString() != "System.Data.DataRowView")
                lblcodcliente.Text = cboboxcodcliente.SelectedValue.ToString();

            if (cboboxcodprofissional.SelectedValue != null &&
                cboboxcodprofissional.SelectedValue.ToString() != "System.Data.DataRowView")
                lblcodprofissional.Text = cboboxcodprofissional.SelectedValue.ToString();

            if (cboboxcodservico.SelectedValue != null &&
                cboboxcodservico.SelectedValue.ToString() != "System.Data.DataRowView")
                lblcodservico.Text = cboboxcodservico.SelectedValue.ToString();
        }


        private void cboboxcodcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregando) return;

            if (cboboxcodcliente.SelectedValue != null &&
                cboboxcodcliente.SelectedValue.ToString() != "System.Data.DataRowView")
                lblcodcliente.Text = cboboxcodcliente.SelectedValue.ToString();
        }

        private void cboboxcodprofissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregando) return;

            if (cboboxcodprofissional.SelectedValue != null &&
                cboboxcodprofissional.SelectedValue.ToString() != "System.Data.DataRowView")
                lblcodprofissional.Text = cboboxcodprofissional.SelectedValue.ToString();
        }

        private void cboboxcodservico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregando) return;

            if (cboboxcodservico.SelectedValue != null &&
                cboboxcodservico.SelectedValue.ToString() != "System.Data.DataRowView")
                lblcodservico.Text = cboboxcodservico.SelectedValue.ToString();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btalterar_Click(object sender, EventArgs e)
        {
            try
            {
                strsql = "UPDATE agenda SET " +
                         "id_cliente='" + cboboxcodcliente.SelectedValue + "'," +
                         "id_profissional='" + cboboxcodprofissional.SelectedValue + "'," +
                         "id_servico='" + cboboxcodservico.SelectedValue + "'," +
                         "data_agenda='" + mtbdateagenda.Text + "'," +
                         "hora='" + mtbhora.Text + "'" +
                         " WHERE id_agenda=" + txtcodagenda.Text;

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();

                MessageBox.Show("Agenda alterada com sucesso!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                
                LimparTela();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar: " + erro.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcodagenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
      e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void LimparTela()
        {
            grupo1.Enabled = true;
            grupo2.Visible = false;

            txtcodagenda.Clear();
            mtbdateagenda.Clear();
            mtbhora.Clear();

            
            carregando = true;
            if (cboboxcodcliente.Items.Count > 0) cboboxcodcliente.SelectedIndex = 0;
            if (cboboxcodprofissional.Items.Count > 0) cboboxcodprofissional.SelectedIndex = 0;
            if (cboboxcodservico.Items.Count > 0) cboboxcodservico.SelectedIndex = 0;
            carregando = false;

            
            lblcodcliente.Text = "..";
            lblcodprofissional.Text = "..";
            lblcodservico.Text = "..";
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodagenda.Text))
            {
                MessageBox.Show("Digite o código da agenda.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                tblagenda = new DataTable();

                strsql = "SELECT * FROM agenda WHERE id_agenda = " +
                         txtcodagenda.Text;

                adapter = new SqlDataAdapter(strsql, conexao);
                adapter.Fill(tblagenda);

                if (tblagenda.Rows.Count == 1)
                {
                    
                    carregando = true;

                    cboboxcodcliente.SelectedValue =
                        tblagenda.Rows[0]["id_cliente"];

                    cboboxcodprofissional.SelectedValue =
                        tblagenda.Rows[0]["id_profissional"];

                    cboboxcodservico.SelectedValue =
                        tblagenda.Rows[0]["id_servico"];

                    carregando = false;

                    
                    AtualizarLabels();

                    
                    DateTime dataAgenda = Convert.ToDateTime(
                        tblagenda.Rows[0]["data_agenda"]);
                    mtbdateagenda.Text = dataAgenda.ToString("dd/MM/yyyy");

                   
                    mtbhora.Text = tblagenda.Rows[0]["hora"].ToString();

                    grupo1.Enabled = false;
                    grupo2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Agenda não encontrada.",
                        "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao pesquisar: " + erro.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
