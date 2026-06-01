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
    public partial class CadastrarClientes : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erro ao gravar no banco: ");
            MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void mtbcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            /*String para buscar banco de dados locadora de forma local na máquina*/
            string strconex = @"Data Source=.\SQLEXPRESS;Initial Catalog=HairUp;Integrated Security=True;";
            //Login com windows

            conexao = new SqlConnection(strconex); // Nova instância do banco de dados
            conexao.Open();                        //Abre o banco de dados

            /*String para inserir dados SQL Server*/
            strsql = "insert into Clientes(Nome, Cpf, Celular, email) values  (@Nome," +
                "@Cpf, @Celular, @email)";

            comando = new SqlCommand(strsql, conexao);

            comando.Parameters.Add(new SqlParameter("@Nome", txtnome.Text));
            comando.Parameters.Add(new SqlParameter("@Cpf", mtbcpf.Text));
            comando.Parameters.Add(new SqlParameter("@Celular", mtbcelular.Text));
            comando.Parameters.Add(new SqlParameter("@email", txtemail.Text));

            comando.ExecuteNonQuery();


            MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
