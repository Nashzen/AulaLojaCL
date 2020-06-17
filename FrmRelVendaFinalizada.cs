using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaCL
{
    public partial class FrmRelVendaFinalizada : Form
    {
        public FrmRelVendaFinalizada()
        {
            InitializeComponent();
        }

        private void FrmRelVendaFinalizada_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DbLojaDataSet1.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.DbLojaDataSet1.venda);

            this.reportViewer1.RefreshReport();
        }
    }
}
