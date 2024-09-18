using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evaluacion_POO_Restaurante.config;

namespace Evaluacion_POO_Restaurante.Models
{
    internal class OrdenesModels
    {
        
        public DataTable ObtenerOrdenes()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                string query = @"
            SELECT o.ID_Orden, p.Nombre AS NombrePlato, o.Fecha
            FROM Ordenes o
            JOIN Platos p ON o.ID_Plato = p.ID_Plato";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtOrdenes = new DataTable();
                adapter.Fill(dtOrdenes);
                return dtOrdenes;
            }
        }

        public bool AgregarOrden(int idPlato, DateTime fecha)
        {
            using (SqlConnection connection = Conexion.GetConnection()) 
            {
                string query = "INSERT INTO Ordenes (ID_Plato, Fecha) VALUES (@ID_Plato, @Fecha)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Plato", idPlato);
                command.Parameters.AddWithValue("@Fecha", fecha);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool EditarOrden(int idOrden, int idPlato, DateTime fecha)
        {
            using (SqlConnection connection = Conexion.GetConnection()) 
            {
                string query = "UPDATE Ordenes SET ID_Plato = @ID_Plato, Fecha = @Fecha WHERE ID_Orden = @ID_Orden";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Orden", idOrden);
                command.Parameters.AddWithValue("@ID_Plato", idPlato);
                command.Parameters.AddWithValue("@Fecha", fecha);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool EliminarOrden(int idOrden)
        {
            using (SqlConnection connection = Conexion.GetConnection()) 
            {
                string query = "DELETE FROM Ordenes WHERE ID_Orden = @ID_Orden";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Orden", idOrden);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public DataTable ObtenerPlatos()
        {
            using (SqlConnection connection = Conexion.GetConnection())
            {
                string query = "SELECT ID_Plato, Nombre AS NombrePlato FROM Platos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtPlatos = new DataTable();
                adapter.Fill(dtPlatos);
                return dtPlatos;
            }
        }
    }
}
