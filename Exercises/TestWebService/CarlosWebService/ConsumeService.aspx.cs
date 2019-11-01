using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarlosWebService
{
    public partial class ConsumeService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void showFecha()
        {
            CarlosWebService.Service1 myws = new CarlosWebService.Service1();
            string date = myws.gatDateTime();
            string name = myws.HelloUser(txtName.Text);
            lblDateTime.Text = name + ". La fecha de hoy es " + date + ".";
        }
    }
}