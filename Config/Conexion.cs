using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Evaluacion_POO_Restaurante.config
{
   
        public static class Conexion
        {
            private static string connectionString = "Server=DESKTOP-BUUJ9LF\\SQLEXPRESS01;Database=Restaurante;User Id=sa;Password=erick;";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }        

        }

}


