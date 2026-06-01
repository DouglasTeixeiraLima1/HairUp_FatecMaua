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

    public partial class CadastrarServicos : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public CadastrarServicos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarServicos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encerrado o cadastro de serviços");
            MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            /*String para buscar banco de dados locadora de forma local na máquina*/
            string strconex = @"Data Source=.\SQLEXPRESS;Initial Catalog=HairUp;Integrated Security=True;";
            //Login com windows

            conexao = new SqlConnection(strconex); // Nova instância do banco de dados
            conexao.Open();                        //Abre o banco de dados

            /*String para inserir dados SQL Server*/
            strsql = "insert into Servicos(nome_servico, descricao, preco) values  (@nome_servico," +
                "@descricao, @preco)";

            comando = new SqlCommand(strsql, conexao);

            comando.Parameters.Add(new SqlParameter("@nome_servico", txtservico.Text));
            comando.Parameters.Add(new SqlParameter("@descricao", txtdescricao.Text));
            comando.Parameters.Add(new SqlParameter("@preco", txtpreco.Text));
            
            comando.ExecuteNonQuery();


            MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtpreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
       e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
