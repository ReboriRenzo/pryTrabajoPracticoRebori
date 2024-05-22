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
    public partial class frmInicioObras : Form
    {
        public frmInicioObras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInicio Quenkas = new frmInicio();
            Quenkas.ShowDialog();
        }

        private void btnOnas_Click(object sender, EventArgs e)
        {
            frmOnas Onas = new frmOnas();
            Onas.ShowDialog();
        }

        private void btnTobas_Click(object sender, EventArgs e)
        {
            frmTobas Tobas = new frmTobas();
            Tobas.ShowDialog();
        }
    }
}
