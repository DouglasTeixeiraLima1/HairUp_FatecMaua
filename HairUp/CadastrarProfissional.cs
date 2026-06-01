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
    public partial class CadastrarProfissional : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;


        public CadastrarProfissional()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            strsql = "insert into Profissionais(Nome, Celular, Cpf, Cargo) values  (@Nome," +
                "@Celular, @Cpf, @Cargo)";

            comando = new SqlCommand(strsql, conexao);

            comando.Parameters.Add(new SqlParameter("@Nome", txtnome.Text));
            comando.Parameters.Add(new SqlParameter("@Celular", mtbcelular.Text));
            comando.Parameters.Add(new SqlParameter("@Cpf", mtbcpf.Text));
            comando.Parameters.Add(new SqlParameter("@Cargo", txtcargo.Text));

            comando.ExecuteNonQuery();


            MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada");
            MessageBox.Show("Encerrado o cadastro de profissionais!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
