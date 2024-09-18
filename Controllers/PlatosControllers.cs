using Evaluacion_POO_Restaurante.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_POO_Restaurante.Controllers
{
    public class PlatosControllers
    {
        public DataTable ObtenerPlatos()
        {
            return PlatosModels.ObtenerPlatos();
        }

        public bool AgregarPlato(string nombre)
        {
            PlatosModels plato = new PlatosModels
            {
                Nombre = nombre
            };
            return plato.AgregarPlato();
        }

        public bool EditarPlato(int idPlato, string nombre)
        {
            PlatosModels plato = new PlatosModels
            {
                ID_Plato = idPlato,
                Nombre = nombre
            };
            return plato.EditarPlato();
        }
        public bool EliminarPlato(int idPlato)
        {
            PlatosModels plato = new PlatosModels
            {
                ID_Plato = idPlato
            };
            return plato.EliminarPlato();
        }
    }
}
