using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Evaluacion_POO_Restaurante.Controllers
{
    public class ProveedoresController
    {
        
        public DataTable ObtenerProveedores()
        {
            return ProveedoresModel.ObtenerProveedores();
        }

        
        public bool AgregarProveedor(string nombre)
        {
            ProveedoresModel proveedor = new ProveedoresModel
            {
                Nombre = nombre
            };
            return proveedor.AgregarProveedor();
        }

        public bool EditarProveedor(int idProveedor, string nombre)
        {
            ProveedoresModel proveedor = new ProveedoresModel
            {
                ID_Proveedor = idProveedor,
                Nombre = nombre
            };
            return proveedor.EditarProveedor();
        }

        // Método para eliminar un proveedor
        public bool EliminarProveedor(int idProveedor)
        {
            ProveedoresModel proveedor = new ProveedoresModel
            {
                ID_Proveedor = idProveedor
            };
            return proveedor.EliminarProveedor();
        }
    }
}
