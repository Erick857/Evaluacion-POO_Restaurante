using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_POO_Restaurante.Reporte
{
    public partial class frm_Reporte : Form
    {
        public frm_Reporte()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds1.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.ds1.Proveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
