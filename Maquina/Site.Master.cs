using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maquina
{
    public partial class SiteMaster : MasterPage
    {
        Literal literal;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["IsAdmin"].ToString() == "SI")
                {
                    literal = new Literal();
                    literal.Text = "<li><a runat='server' href='Administrar'>Administrar</a></li>";
                    brandon.Controls.Add(literal);
                }
            }                       
        }
    }
}