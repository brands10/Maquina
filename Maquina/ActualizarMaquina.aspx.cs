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
    public partial class ActualizarMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            bd.Abrir();
            if (TextBox10.Text != "")
            {
                Label8.Text = "";
                if (TextBox6.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
                {
                    Label7.Text = "";
                    string sql = "UPDATE Maquinas SET id = '" + TextBox6.Text + "', nombre = '" + TextBox7.Text + "', precio = " + TextBox9.Text + ", descripcion = '" + TextBox8.Text + "' WHERE id = '" + TextBox10.Text + "'";
                    OracleCommand cmd = new OracleCommand(sql, bd.Conexion());
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    Label7.Text = "!Actualizado!";
                    bd.Cerrar();
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                }
                else
                {
                    Label7.Text = "!Ingrese Datos!";
                }
            }
            else
            {
                Label8.Text = "!Ingrese Codigo!";
            }
        }
    }
}