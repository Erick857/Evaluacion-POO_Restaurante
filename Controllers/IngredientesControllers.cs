using Evaluacion_POO_Restaurante.Models;
using System;
using System.Data;

namespace Evaluacion_POO_Restaurante.Controllers
{
    public class IngredientesController
    {
        private IngredientesModels ingredientesModel;

        public IngredientesController()
        {
            ingredientesModel = new IngredientesModels();
        }

        // Obtiene todos los ingredientes
        public DataTable ObtenerIngredientes()
        {
            return ingredientesModel.ObtenerIngredientes();
        }

        // Agrega un nuevo ingrediente
        public bool AgregarIngrediente(string nombre, int idProveedor)
        {
            return ingredientesModel.AgregarIngrediente(nombre, idProveedor);
        }

        // Actualiza un ingrediente existente
        public bool EditarIngrediente(int idIngrediente, string nombre, int idProveedor)
        {
            return ingredientesModel.EditarIngrediente(idIngrediente, nombre, idProveedor);
        }

        // Elimina un ingrediente
        public bool EliminarIngrediente(int idIngrediente)
        {
            return ingredientesModel.EliminarIngrediente(idIngrediente);
        }

        // Obtiene la lista de proveedores para el ComboBox
        public DataTable ObtenerProveedores()
        {
            return ProveedoresModel.ObtenerProveedores(); // Llamada estática
        }
    }
}
