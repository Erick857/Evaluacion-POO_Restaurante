using Evaluacion_POO_Restaurante.Views.Ingredientes;
using Evaluacion_POO_Restaurante.Views.Ordenes;
using Evaluacion_POO_Restaurante.Views.Platos;
using Evaluacion_POO_Restaurante.Views.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_POO_Restaurante.Views.Dashboard
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Proveedores proveedoresForm = new frm_Proveedores();        
            proveedoresForm.Show();
        }

        private void ordenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Platos platosForm = new frm_Platos();
            platosForm.Show();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ordenes _OrdenesForm = new frm_Ordenes();
            _OrdenesForm.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ingredientes _Ingredientes = new frm_Ingredientes();
            _Ingredientes.Show();
        }
    }
}
