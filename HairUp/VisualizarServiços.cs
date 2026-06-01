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
    public partial class VisualizarServiços : Form
    {
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable tabela;

        string strconex = @"Data Source=.\SQLEXPRESS;Initial Catalog=HairUp;Integrated Security=True;";

        string strsql;


        public VisualizarServiços()
        {
            InitializeComponent();
        }

        private void VisualizarServiços_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hairUpDataSet2servicos.SERVICOS'. Você pode movê-la ou removê-la conforme necessário.
            this.sERVICOSTableAdapter.Fill(this.hairUpDataSet2servicos.SERVICOS);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            Menu tela = new Menu();
            tela.Show();
            this.Hide();
        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização Cancelada");
            MessageBox.Show("Encerrada a visualização dos serviços!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {

            conexao = new SqlConnection(strconex);
            conexao.Open();

            tabela = new DataTable();

            strsql = "SELECT * FROM Servicos WHERE nome_servico LIKE '%" +
                     txtservico.Text + "%'";

            adapter = new SqlDataAdapter(strsql, conexao);

            adapter.Fill(tabela);

            dtvServicos.DataSource = tabela;

            conexao.Close();

        }
    }
}
