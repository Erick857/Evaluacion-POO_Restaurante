using Evaluacion_POO_Restaurante.config;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Evaluacion_POO_Restaurante.Models
{
    public class IngredientesModels
    {
        public int ID_Ingrediente { get; set; }
        public string Nombre { get; set; }
        public int ID_Proveedor { get; set; }

        // Obtiene todos los ingredientes
        public DataTable ObtenerIngredientes()
        {
            DataTable ingredientes = new DataTable();
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "SELECT ID_Ingrediente, Nombre, ID_Proveedor FROM Ingredientes";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conexion.Open();
                            adapter.Fill(ingredientes);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener ingredientes: " + ex.Message);
                }
            }
            return ingredientes;
        }

        // Agrega un nuevo ingrediente
        public bool AgregarIngrediente(string nombre, int idProveedor)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Ingredientes (Nombre, ID_Proveedor) VALUES (@Nombre, @ID_Proveedor)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);

                        conexion.Open();
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar ingrediente: " + ex.Message);
                }
            }
        }

        // Actualiza un ingrediente existente
        public bool EditarIngrediente(int idIngrediente, string nombre, int idProveedor)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "UPDATE Ingredientes SET Nombre = @Nombre, ID_Proveedor = @ID_Proveedor WHERE ID_Ingrediente = @ID_Ingrediente";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@ID_Proveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@ID_Ingrediente", idIngrediente);

                        conexion.Open();
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al editar ingrediente: " + ex.Message);
                }
            }
        }

        // Elimina un ingrediente
        public bool EliminarIngrediente(int idIngrediente)
        {
            using (SqlConnection conexion = Conexion.GetConnection())
            {
                try
                {
                    string query = "DELETE FROM Ingredientes WHERE ID_Ingrediente = @ID_Ingrediente";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ID_Ingrediente", idIngrediente);

                        conexion.Open();
                        int resultado = cmd.ExecuteNonQuery();
                        return resultado > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar ingrediente: " + ex.Message);
                }
            }
        }
    }
}