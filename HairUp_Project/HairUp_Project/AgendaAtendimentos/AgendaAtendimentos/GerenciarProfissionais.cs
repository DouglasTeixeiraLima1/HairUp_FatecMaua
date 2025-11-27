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



namespace AgendaAtendimentos
{
    public partial class GerenciarProfissionais : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public GerenciarProfissionais()
        {
            InitializeComponent();
        }

        private void GerenciarProfissionais_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HairUpDataSet2_Profissionais.PROFISSIONAIS' table. You can move, or remove it, as needed.
            this.pROFISSIONAISTableAdapter1.Fill(this.dB_HairUpDataSet2_Profissionais.PROFISSIONAIS);
        }

        private void dBHairUpDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*String para buscar banco de dados locadora de forma local na máquina*/
            strconex = "Data Source=DOUGLASHOC3040;Initial Catalog=DB_HairUp;Integrated Security=True;";
            //Login com windows

            conexao = new SqlConnection(strconex); // Nova instância do banco de dados
            conexao.Open();                        //Abre o banco de dados

            /*String para inserir dados SQL Server*/
            strsql = "insert into Profissionais(Nome, Celular, Cpf, Cargo) values  (@Nome," +
                "@Celular, @Cpf, @Cargo)";

            comando = new SqlCommand(strsql, conexao);

            comando.Parameters.Add(new SqlParameter("@Nome", txtnome.Text));
            comando.Parameters.Add(new SqlParameter("@Celular", txtcelular.Text));
            comando.Parameters.Add(new SqlParameter("@Cpf", txtcpf.Text));
            comando.Parameters.Add(new SqlParameter("@Cargo", txtcargo.Text));

            comando.ExecuteNonQuery();


            MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnovo_Click(object sender, EventArgs e)
        {
            txtcargo.Clear();
            txtcelular.Clear();
            txtcpf.Clear();
            txtnome.Clear();
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erro ao gravar no banco: ");
            MessageBox.Show("Operação cancelada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}