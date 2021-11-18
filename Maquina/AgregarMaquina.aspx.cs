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
    public partial class AgregarMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            basedatos bd = new basedatos();
            bd.Abrir();
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox11.Text != "")
            {
                string sql = "insert into Maquinas values('" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox4.Text + ",'" + TextBox3.Text + "'," + TextBox11.Text + ")";
                OracleCommand cmd = new OracleCommand(sql, bd.Conexion());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                Label4.Text = "!Guardado!";
                bd.Cerrar();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox11.Text = "";
            }
            else
            {
                Label4.Text = "!Ingrese Datos!";
            }
        }
    }
}