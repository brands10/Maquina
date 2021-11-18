using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Maquina
{
    public partial class Inicio : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Maquina"] = "";
                Servicio.ServicioSoapClient miservicio = new Servicio.ServicioSoapClient();
                DataSet ds = miservicio.ObtenerTodasMaquinas();
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        var nombre = dr["NOMBRE"].ToString();
                        var value = dr["ID"].ToString();
                        DropDownList1.Items.Add(new ListItem(nombre, value));
                    }
                }
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void Comprar_Click(object sender, EventArgs e)
        {
            Session["Maquina"] = DropDownList1.SelectedValue;
            Response.Redirect("Alquilar.aspx");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}