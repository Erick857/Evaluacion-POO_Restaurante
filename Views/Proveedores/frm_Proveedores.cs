
using System;
using System.Data;
using System.Windows.Forms;
using Evaluacion_POO_Restaurante.Controllers;
using Evaluacion_POO_Restaurante.Models;
using Evaluacion_POO_Restaurante.config;
using Evaluacion_POO_Restaurante.Reporte;

namespace Evaluacion_POO_Restaurante.Views.Proveedores
{
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
            CargarProveedores(); 
        }

        private void CargarProveedores()
        {
            try
            {
                DataTable dtProveedores = ProveedoresModel.ObtenerProveedores();
                lst_Proveedores.DataSource = dtProveedores;
                lst_Proveedores.DisplayMember = "Nombre";  
                lst_Proveedores.ValueMember = "ID_Proveedor"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedoresModel proveedor = new ProveedoresModel();
                proveedor.Nombre = txt_nombreProveedor.Text; 

                if (proveedor.AgregarProveedor())
                {
                    MessageBox.Show("Proveedor agregado correctamente.");
                    CargarProveedores(); 
                }
                else
                {
                    MessageBox.Show("Error al agregar el proveedor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_Proveedores.SelectedValue != null)
                {
                    ProveedoresModel proveedor = new ProveedoresModel();
                    proveedor.ID_Proveedor = (int)lst_Proveedores.SelectedValue;
                    proveedor.Nombre = txt_nombreProveedor.Text; 

                    if (proveedor.EditarProveedor())
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.");
                        CargarProveedores(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el proveedor.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un proveedor para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //txt_IDProveedor.Text = "";
           // txt_nombreProveedor.Text = "";
        }

        
        private void lst_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Proveedores.SelectedValue != null)
            {
               // txt_IDProveedor.Text = lst_Proveedores.SelectedValue.ToString();
                txt_nombreProveedor.Text = lst_Proveedores.Text; 
            }
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            //frm_Reporte _Reportes_Usuarios = new frm_Reporte();
            //_Reportes_Usuarios.ShowDialog();
            frm_Reporte _Reporte = new frm_Reporte();
            _Reporte.ShowDialog();
        }

    }
}