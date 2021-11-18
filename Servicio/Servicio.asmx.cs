using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Maquina;
using System.Net.Mail;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de Servicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicio : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public DataSet ObtenerTodasMaquinas()
        {
            basedatos bd = new basedatos();
            bd.Abrir();
            string sql = "SELECT id, nombre, precio, descripcion, cantidad as cantidad_disponible FROM Maquinas";
            OracleDataAdapter da = new OracleDataAdapter(sql, bd.Conexion());
            DataSet ds = new DataSet();
            da.Fill(ds);
            bd.Cerrar();
            return ds;
        }

        [WebMethod]
        public string Login(string username, string password)
        {
            string str = "SELECT * FROM Clientes WHERE usuario = '" + username + "' AND contra = '" + password + "'";
            OracleCommand com;
            basedatos bd = new basedatos();
            bd.Abrir();
            com = new OracleCommand(str, bd.Conexion());
            OracleDataReader leer = com.ExecuteReader();
            string usuario = "";
            if (leer.Read())
            { 
            }
            return usuario;


        }







        [WebMethod]
        public void insertarAlquiler(string usuario, string cliente, string idmaquina, string fecha_devolucion, string correo2, string precio)
        {
            basedatos bd = new basedatos();
            bd.Abrir();
            string sql = "insert into alquiler(usuario,cliente,idmaquina,fecha_devolucion) values('" + usuario + "','" + cliente + "','" + idmaquina + "','" + fecha_devolucion + "')";
            OracleCommand cmd = new OracleCommand(sql, bd.Conexion());
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            string srt = "update maquinas SET cantidad = ((Select cantidad from maquinas where id = '" + idmaquina + "')-1) WHERE id = '" + idmaquina + "'";
            OracleCommand c = new OracleCommand(srt, bd.Conexion());
            c.CommandType = CommandType.Text;
            c.ExecuteNonQuery();
            bd.Cerrar();

            MailMessage correo = new MailMessage();
            SmtpClient protocolo = new SmtpClient();
            correo.To.Add(correo2);
            correo.From = new MailAddress("blopezs10@miumg.edu.gt","Comprobante de Compra :D (Maquinaria S.A.)", System.Text.Encoding.UTF8);
            correo.Subject = "Compra de partes para la frabricacion de Maquina " + idmaquina;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.Body = "Buen dia estimad@ " + cliente + "  la compra del articulo" + idmaquina + " se a efectuado con exito, con el siguiente precio: Q." + precio + " dicho articulo tiene un limite de garantia el expira en la siguiente fecha : " + fecha_devolucion + " este es su comprobante, Gracias Por Elegirnos!";
            correo.BodyEncoding = System.Text.Encoding.UTF8;
            correo.IsBodyHtml = false;
            protocolo.Credentials = new System.Net.NetworkCredential("blopezs10@miumg.edu.gt","$M!BU09o");
            protocolo.Port = 587;
            protocolo.Host = "smtp.gmail.com";
            protocolo.EnableSsl = true;
            protocolo.Send(correo);

        }
    }
}
