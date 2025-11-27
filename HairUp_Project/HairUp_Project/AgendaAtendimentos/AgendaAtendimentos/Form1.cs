using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaAtendimentos
{
    public partial class AgendaAtendimento : Form
    {
        public AgendaAtendimento()
        {
            InitializeComponent();
        }

        private void AgendaAtendimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HairUpDataSet_Agenda.AGENDA' table. You can move, or remove it, as needed.
            this.aGENDATableAdapter.Fill(this.dB_HairUpDataSet_Agenda.AGENDA);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
