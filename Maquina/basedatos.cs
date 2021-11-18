using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Maquina
{
    public class basedatos
    {
        private OracleConnection conexionOracle;

        public void Abrir()
        {                   
            conexionOracle = new OracleConnection("User Id =system; Password =admin; Data Source= localhost:1521/XE;");
            conexionOracle.Open();
        }

        public void Cerrar()
        {
            conexionOracle.Close();            
        }

        public OracleConnection Conexion()
        {
            return conexionOracle;
        }
    }
}