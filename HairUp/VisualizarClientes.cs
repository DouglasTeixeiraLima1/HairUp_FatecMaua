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
    public partial class VisualizarClientes : Form
    {
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable tabela;

        string strconex = @"Data Source=.\SQLEXPRESS;Initial Catalog=HairUp;Integrated Security=True;";

        string strsql;

        public VisualizarClientes()
        {
            InitializeComponent();
        }

        private void VisualizarClientes_Load(object sender, EventArgs e)
        {
             
            this.cLIENTESTableAdapter.Fill(this.hairUpDataSet.CLIENTES);

        }

        private void btfechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualização Cancelada");
            MessageBox.Show("Encerrada a visualização dos clientes!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            strsql = "SELECT * FROM clientes WHERE nome LIKE '%" +
                     txtnome.Text + "%'";

            adapter = new SqlDataAdapter(strsql, conexao);

            adapter.Fill(tabela);

            dgvClientes.DataSource = tabela;

            conexao.Close();
        }
    }
}
