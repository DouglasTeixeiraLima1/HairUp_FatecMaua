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
    public partial class GerenciarServicos : Form
    {
        public GerenciarServicos()
        {
            InitializeComponent();
        }

        private void GerenciarServicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HairUpDataSet1_Servicos.SERVICOS' table. You can move, or remove it, as needed.
            this.sERVICOSTableAdapter.Fill(this.dB_HairUpDataSet1_Servicos.SERVICOS);

        }
    }
}
