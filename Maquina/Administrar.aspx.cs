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
    public partial class Administrar : System.Web.UI.Page
    {
        basedatos bd = new basedatos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMaquina.aspx");
        }

        protected void EliminarM_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarMaquina.aspx");
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActualizarMaquina.aspx");
        }
    }
}