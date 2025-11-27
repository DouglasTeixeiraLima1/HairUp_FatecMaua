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
    public partial class CadastrarClientes : Form
    {
        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HairUpDataSet1_GerenciarClientes1.CLIENTES' table. You can move, or remove it, as needed.
            this.cLIENTESTableAdapter.Fill(this.dB_HairUpDataSet1_GerenciarClientes1.CLIENTES);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
