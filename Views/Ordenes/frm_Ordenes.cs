using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Evaluacion_POO_Restaurante.Controllers;

namespace Evaluacion_POO_Restaurante.Views.Ordenes
{
    public partial class frm_Ordenes : Form
    {
        private OrdenesController controlador;

        public frm_Ordenes()
        {
            InitializeComponent();
            controlador = new OrdenesController();
            CargarOrdenes();
            CargarPlatos(); 
        }

        private void CargarOrdenes()
        {
            try
            {
                DataTable dtOrdenes = controlador.ObtenerOrdenes();
                lst_ordenes.DataSource = dtOrdenes;
                lst_ordenes.DisplayMember = "NombrePlato"; 
                lst_ordenes.ValueMember = "ID_Orden";     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las órdenes: " + ex.Message);
            }
        }

        private void CargarPlatos()
        {
            try
            {
                DataTable dtPlatos = controlador.ObtenerPlatos(); // Implementa ObtenerPlatos en el controlador
                cmb_platos.DataSource = dtPlatos;
                cmb_platos.DisplayMember = "NombrePlato"; // Mostrar el nombre del plato
                cmb_platos.ValueMember = "ID_Plato";   // Usar ID del Plato como valor
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
                if (cmb_platos.SelectedValue != null && dtp_fecha.Value != null)
                {
                    int idPlato = (int)cmb_platos.SelectedValue;
                    DateTime fecha = dtp_fecha.Value;

                    if (controlador.AgregarOrden(idPlato, fecha))
                    {
                        MessageBox.Show("Orden agregada correctamente.");
                        CargarOrdenes();
                        dtp_fecha.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la orden.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un plato y una fecha.");
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
                if (lst_ordenes.SelectedValue != null && cmb_platos.SelectedValue != null && dtp_fecha.Value != null)
                {
                    int idOrden = (int)lst_ordenes.SelectedValue;
                    int idPlato = (int)cmb_platos.SelectedValue;
                    DateTime fecha = dtp_fecha.Value;

                    if (controlador.EditarOrden(idOrden, idPlato, fecha))
                    {
                        MessageBox.Show("Orden actualizada correctamente.");
                        CargarOrdenes();
                        dtp_fecha.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la orden.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una orden, un plato y una fecha.");
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
                if (lst_ordenes.SelectedValue != null)
                {
                    int idOrden = (int)lst_ordenes.SelectedValue;

                    if (controlador.EliminarOrden(idOrden))
                    {
                        MessageBox.Show("Orden eliminada correctamente.");
                        CargarOrdenes();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la orden.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una orden para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            //cmb_platos.SelectedIndex = -1;
            //dtp_fecha.Value = DateTime.Now;
            this.Close();
        }

        private void lst_ordenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ordenes.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)lst_ordenes.SelectedItem;
                cmb_platos.SelectedValue = selectedRow["ID_Plato"];
                dtp_fecha.Value = Convert.ToDateTime(selectedRow["Fecha"]);
            }
        }
    }
}

