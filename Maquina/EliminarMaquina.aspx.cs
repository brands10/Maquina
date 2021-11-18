using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Maquina
{
    public partial class EliminarMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            bd.Abrir();
            if (TextBox5.Text != "")
            {
                string sql = "DELETE FROM Maquinas WHERE id = '" + TextBox5.Text + "'";
                OracleCommand cmd = new OracleCommand(sql, bd.Conexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                Label3.Text = "!Eliminado!";
                bd.Cerrar();
                TextBox5.Text = "";
            }
            else
            {
                Label3.Text = "!Ingrese Datos!";
            }
        }
    }
}