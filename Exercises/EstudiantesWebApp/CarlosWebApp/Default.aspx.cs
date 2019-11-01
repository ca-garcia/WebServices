using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarlosWebApp.EstudiantesWS;


namespace CarlosWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        Service1 srv = new Service1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void existClick(object sender, EventArgs e)
        {
            if (srv.ExisteEstudiante(edtName.Text))
                lblExist.Text = "Existe";
            else
                lblExist.Text = "No Existe";
        }

        protected void btnFechaNac_Click(object sender, EventArgs e)
        {

        }
    }
}