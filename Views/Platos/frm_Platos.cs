using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion_POO_Restaurante.Controllers;

namespace Evaluacion_POO_Restaurante.Views.Platos
{
    public partial class frm_Platos : Form
    {
        public frm_Platos()
        {
            InitializeComponent();
            CargarPlatos();
        }

        private void CargarPlatos()
        {
            try
            {
                PlatosControllers controlador = new PlatosControllers(); 
                DataTable dtPlatos = controlador.ObtenerPlatos(); 
                lst_platos.DataSource = dtPlatos;
                lst_platos.DisplayMember = "Nombre";
                lst_platos.ValueMember = "ID_Plato";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los platos: " + ex.Message);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePlato = txt_nombrePlato.Text.Trim();
                if (!string.IsNullOrEmpty(nombrePlato))
                {
                    PlatosControllers controlador = new PlatosControllers(); 
                    if (controlador.AgregarPlato(nombrePlato)) 
                    {
                        MessageBox.Show("Plato agregado correctamente.");
                        CargarPlatos();
                        txt_nombrePlato.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el plato.");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre del plato no puede estar vacío.");
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
                if (lst_platos.SelectedValue != null)
                {
                    int idPlato = (int)lst_platos.SelectedValue;
                    string nombrePlato = txt_nombrePlato.Text.Trim();
                    if (!string.IsNullOrEmpty(nombrePlato))
                    {
                        PlatosControllers controlador = new PlatosControllers(); 
                        if (controlador.EditarPlato(idPlato, nombrePlato)) 
                        {
                            MessageBox.Show("Plato actualizado correctamente.");
                            CargarPlatos();
                            txt_nombrePlato.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el plato.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre del plato no puede estar vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un plato para actualizar.");
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

        private void lst_platos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_platos.SelectedValue != null)
            {
                txt_nombrePlato.Text = lst_platos.Text;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_platos.SelectedValue != null)
                {
                    int idPlato = (int)lst_platos.SelectedValue; 

                    DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este plato?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        PlatosControllers controlador = new PlatosControllers(); 
                        if (controlador.EliminarPlato(idPlato)) 
                        {
                            MessageBox.Show("Plato eliminado correctamente.");
                            CargarPlatos(); 
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el plato.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona un plato para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}