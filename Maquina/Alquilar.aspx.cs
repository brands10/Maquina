using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Net.Mail;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text;

namespace Maquina
{
    public partial class Alquilar : System.Web.UI.Page
    {
        basedatos bd = new basedatos();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bd.Abrir();
                string str = "select * from Alquiler where usuario = '"+Session["usuario"].ToString()+"'";
                OracleDataAdapter da = new OracleDataAdapter(str, bd.Conexion());
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //bd.Cerrar();

                //bd.Abrir();
                AlqMaquina.Text = Session["Maquina"].ToString();
                if (Session["Maquina"].ToString() != "")
                {
                    string sql = "select descripcion, precio, cantidad from maquinas where id= '" + Session["Maquina"].ToString() + "'";
                    OracleCommand cmd = new OracleCommand(sql, bd.Conexion());
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr;
                    dr = cmd.ExecuteReader();
                    string cantidad = "";
                    if (dr.Read())
                    {
                        NoEncontrado.Text = "";
                        Encontrado.Text = "Maquina Existente";
                        cantidad = dr["cantidad"].ToString();                        
                        TextBox3.Text = dr["descripcion"].ToString();
                        TextBox4.Text = dr["precio"].ToString();
                        if (cantidad == "0")
                        {
                            Encontrado.Text = "Maquina Existente PERO NO DISPONIBLE EN ALQUILER";
                            btnAlquilar.Enabled = false;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Encontrado.Text = "";
                        NoEncontrado.Text = "Maquina NO Existente";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        btnAlquilar.Enabled = false;
                    }
                    bd.Cerrar();
                }
                else
                {
                    btnAlquilar.Enabled = false;
                }
            }
        }

        protected void btnAlquilar_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text != "" && TextBox12.Text != "")
            {
                miservicio.ServicioSoapClient miservicio2 = new miservicio.ServicioSoapClient();               
                miservicio2.insertarAlquiler(Session["usuario"].ToString(),TextBox2.Text,Session["Maquina"].ToString(),TextBox12.Text,TxtCorreo.Text,TextBox4.Text);
                Label3.Text = "!Guardado!";         
            }
            else
            {
                Label3.Text = "!Ingrese Datos!";
            }
        }

        private void exportPdf() 
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.pdf");
            
            Response.End();
        }
    }
}

