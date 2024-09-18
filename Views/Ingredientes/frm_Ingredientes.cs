using Evaluacion_POO_Restaurante.Controllers;
using Evaluacion_POO_Restaurante.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Evaluacion_POO_Restaurante.Views.Ingredientes
{
    public partial class frm_Ingredientes : Form
    {
        private IngredientesController ingredientesController;
        private int idIngredienteSeleccionado = -1; 

        public frm_Ingredientes()
        {
            InitializeComponent();
            ingredientesController = new IngredientesController();
            CargarIngredientes();
            CargarProveedores();
        }

        private void CargarIngredientes()
        {
            try
            {
                DataTable dtIngredientes = ingredientesController.ObtenerIngredientes();
                lst_ingredientes.DisplayMember = "Nombre";
                lst_ingredientes.ValueMember = "ID_Ingrediente";
                lst_ingredientes.DataSource = dtIngredientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ingredientes: " + ex.Message);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                DataTable dtProveedores = ingredientesController.ObtenerProveedores();
                cmb_IDProveedor.DisplayMember = "Nombre";
                cmb_IDProveedor.ValueMember = "ID_Proveedor";
                cmb_IDProveedor.DataSource = dtProveedores;
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
                string nombre = txt_Nombre.Text;
                int idProveedor = (int)cmb_IDProveedor.SelectedValue;

                if (idIngredienteSeleccionado == -1)
                {
                    // Agregar nuevo ingrediente
                    bool resultado = ingredientesController.AgregarIngrediente(nombre, idProveedor);
                    if (resultado)
                    {
                        MessageBox.Show("Ingrediente agregado con éxito.");
                        CargarIngredientes();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar ingrediente.");
                    }
                }
                else
                {
                    bool resultado = ingredientesController.EditarIngrediente(idIngredienteSeleccionado, nombre, idProveedor);
                    if (resultado)
                    {
                        MessageBox.Show("Ingrediente actualizado con éxito.");
                        CargarIngredientes();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar ingrediente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idIngredienteSeleccionado != -1)
                {
                    bool resultado = ingredientesController.EliminarIngrediente(idIngredienteSeleccionado);
                    if (resultado)
                    {
                        MessageBox.Show("Ingrediente eliminado con éxito.");
                        CargarIngredientes();
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar ingrediente.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un ingrediente para eliminar.");
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
        }

        private void LimpiarFormulario()
        {
            txt_Nombre.Clear();
            cmb_IDProveedor.SelectedIndex = -1;
            idIngredienteSeleccionado = -1;
        }

        private void lst_ingredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ingredientes.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)lst_ingredientes.SelectedItem;
                idIngredienteSeleccionado = (int)selectedRow["ID_Ingrediente"];
                txt_Nombre.Text = selectedRow["Nombre"].ToString();
                cmb_IDProveedor.SelectedValue = selectedRow["ID_Proveedor"];
            }
        }
    }
}