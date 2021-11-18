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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["IsAdmin"] = "NO";
            }
        }

        protected void Inicio_Click(object sender, EventArgs e)
        {
            OracleCommand com;
            string UserName = usuario.Text.Trim();
            string Password = contra.Text.Trim();
            basedatos bd = new basedatos();
            bd.Abrir();


            string str = "SELECT * FROM Clientes WHERE usuario = '" + UserName + "' AND contra = '" + Password + "'";            
            com = new OracleCommand(str, bd.Conexion());
            OracleDataReader leer = com.ExecuteReader();

            if (leer.Read())
            {
                    Session["usuario"] = UserName;
                //Para ver si es administrador
                string admin = "SELECT Isadmin FROM Clientes WHERE usuario = '" + usuario.Text + "'";
                OracleCommand cmd2 = new OracleCommand(admin, bd.Conexion());
                cmd2.CommandType = CommandType.Text;
                OracleDataReader dr;
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    Session["IsAdmin"] = dr["Isadmin"].ToString();
                }


                Response.Redirect("Inicio.aspx");

            }
            else
            {
                usuario.Text = "ERROR";
                contra.Text = "ERROR";
            }
            bd.Cerrar();
            
        }
    }
}