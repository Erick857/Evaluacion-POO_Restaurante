using System;
using System.Data;
using Evaluacion_POO_Restaurante.Models;


namespace Evaluacion_POO_Restaurante.Controllers
{
    public class OrdenesController
    {
        private OrdenesModels ordenesModel;
        private PlatosModels platosModel;

        public OrdenesController()
        {
            ordenesModel = new OrdenesModels();
            platosModel = new PlatosModels(); 
        }

        public DataTable ObtenerOrdenes()
        {
            return ordenesModel.ObtenerOrdenes();
        }

        public bool AgregarOrden(int idPlato, DateTime fecha)
        {
            return ordenesModel.AgregarOrden(idPlato, fecha);
        }

        public bool EditarOrden(int idOrden, int idPlato, DateTime fecha)
        {
            return ordenesModel.EditarOrden(idOrden, idPlato, fecha);
        }

        public bool EliminarOrden(int idOrden)
        {
            return ordenesModel.EliminarOrden(idOrden);
        }

        public DataTable ObtenerPlatos()
        {
            return ordenesModel.ObtenerPlatos(); 
        }
    }
}
