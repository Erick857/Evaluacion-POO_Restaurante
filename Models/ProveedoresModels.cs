using Evaluacion_POO_Restaurante.config;
using System;
using System.Data;
using System.Data.SqlClient;

public class ProveedoresModel
{
    public int ID_Proveedor { get; set; }
    public string Nombre { get; set; }

    // Obtiene todos los proveedores
    public static DataTable ObtenerProveedores()
    {
        DataTable proveedores = new DataTable();
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            try
            {
                string query = "SELECT ID_Proveedor, Nombre FROM Proveedores";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        conexion.Open();
                        adapter.Fill(proveedores);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener proveedores: " + ex.Message);
            }
        }
        return proveedores;
    }

    // Agrega un nuevo proveedor
    public bool AgregarProveedor()
    {
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            try
            {
                string query = "INSERT INTO Proveedores (Nombre) VALUES (@Nombre)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);

                    conexion.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo específico para errores SQL
                throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo genérico para otros errores
                throw new Exception("Error al agregar proveedor: " + ex.Message);
            }
        }
    }

    // Actualiza un proveedor existente
    public bool EditarProveedor()
    {
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            try
            {
                string query = "UPDATE Proveedores SET Nombre = @Nombre WHERE ID_Proveedor = @ID_Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);

                    conexion.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo específico para errores SQL
                throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo genérico para otros errores
                throw new Exception("Error al editar proveedor: " + ex.Message);
            }
        }
    }

    // Elimina un proveedor
    public bool EliminarProveedor()
    {
        using (SqlConnection conexion = Conexion.GetConnection())
        {
            try
            {
                string query = "DELETE FROM Proveedores WHERE ID_Proveedor = @ID_Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);

                    conexion.Open();
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo específico para errores SQL
                throw new Exception("Error en la consulta SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo genérico para otros errores
                throw new Exception("Error al eliminar proveedor: " + ex.Message);
            }
        }
    }
}