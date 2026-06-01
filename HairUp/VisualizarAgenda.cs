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
    public partial class VisualizarAgenda : Form
    {
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable tabela;

        string strconex = @"Data Source=.\SQLEXPRESS;Initial Catalog=HairUp;Integrated Security=True;";

        string strsql;

        public VisualizarAgenda()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualizarAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hairUpDataSet2agenda.AGENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.aGENDATableAdapter.Fill(this.hairUpDataSet2agenda.AGENDA);

        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização Cancelada");
            MessageBox.Show("Encerrada a visualização da agenda!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btmenu_Click(object sender, EventArgs e)
        {
            Menu tela = new Menu();
            tela.Show();
            this.Hide();
        }

        private void btpesquisar_Click(object sender, EventArgs e)
        {

            conexao = new SqlConnection(strconex);
            conexao.Open();

            tabela = new DataTable();

            strsql = "SELECT * FROM agenda WHERE id_agenda LIKE '%" +
                     txtcodagenda.Text + "%'";

            adapter = new SqlDataAdapter(strsql, conexao);

            adapter.Fill(tabela);

            dgvVisualizarAgenda.DataSource = tabela;

            conexao.Close();
        }
    }
}
