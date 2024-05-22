using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPracticoRebori
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio Inicio = new frmInicio();
            Inicio.ShowDialog();
            this.Close();
        }
    }
}
