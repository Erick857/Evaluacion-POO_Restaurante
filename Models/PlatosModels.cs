using Evaluacion_POO_Restaurante.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_POO_Restaurante.Models
{
    public class PlatosModels
    {
        public int ID_Plato { get; set; }
        public string Nombre { get; set; }

        public static DataTable ObtenerPlatos()
        {
            DataTable platos = new DataTable();
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "SELECT ID_Plato, Nombre FROM Platos";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(platos);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener platos: " + ex.Message);
                }
            }
            return platos;
        }

        public bool AgregarPlato()
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Platos (Nombre) VALUES (@Nombre)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);

                    conexion.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar plato: " + ex.Message);
                }
            }
        }

        public bool EditarPlato()
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "UPDATE Platos SET Nombre = @Nombre WHERE ID_Plato = @ID_Plato";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@ID_Plato", ID_Plato);

                    conexion.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al editar plato: " + ex.Message);
                }
            }
        }

        public bool EliminarPlato()
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "DELETE FROM Platos WHERE ID_Plato = @ID_Plato";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ID_Plato", ID_Plato);

                    conexion.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar plato: " + ex.Message);
                }
            }
        }
    }
}
