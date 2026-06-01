using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairUp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAgenda tela = new CadastrarAgenda();
            tela.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarClientes tela = new CadastrarClientes();
            tela.Show();
        }

        private void profissionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProfissional tela = new CadastrarProfissional();
            tela.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarServicos tela = new CadastrarServicos();
            tela.Show();
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtualizarAgenda tela = new AtualizarAgenda();
            tela.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtualizarClientes tela = new AtualizarClientes();
            tela.Show();
        }

        private void profissionaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtualizarProfissionais tela = new AtualizarProfissionais();
            tela.Show();
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtualizarServicos tela = new AtualizarServicos();
            tela.Show();
        }

        private void agendaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeletarAgenda tela = new DeletarAgenda();
            tela.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExcluirClientes tela = new ExcluirClientes();
            tela.Show();
        }

        private void profissionaisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeletarProfissionais tela = new DeletarProfissionais();
            tela.Show();
        }

        private void serviçosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeletarServiços tela = new DeletarServiços();
            tela.Show();
        }

        private void agendaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VisualizarAgenda tela = new VisualizarAgenda();
            tela.Show();
        }

        private void clientesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VisualizarClientes tela = new VisualizarClientes();
            tela.Show();
        }

        private void profissionaisToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VisualizarProfissionais tela = new VisualizarProfissionais();
            tela.Show();
        }

        private void serviçosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VisualizarServiços tela = new VisualizarServiços();
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
