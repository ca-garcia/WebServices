using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaWebApp.TiendaServiceReference;

namespace TiendaWebApp
{   
    public partial class _Default : System.Web.UI.Page
    {
        Service1SoapClient srv = new Service1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            dropProdName.Items.Clear();
            //ListItem first = new ListItem("[Seleccione un producto...]", "0", true);
            //first.Selected = true;
            //dropProdName.Items.Add(first);
           

            List<string> list = srv.getAllProductsNames();

             for (int i = 0; i < list.Count; i++)
            {
                dropProdName.Items.Add(list.ElementAt(i));
                //BulletedList1.Items.Add(list.ElementAt(i));
            }
             dropProdName.Items[0].Selected = false;
             
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //if (srv.ExistProduct(dropProdName.SelectedItem.Value.ToLower()))
            if (srv.ExistProduct(txtProdName.Text.ToLower()))
            {
                lblExist.Text = "El producto esta disponible!!";
                txtProdId.Text = srv.getProductID(txtProdName.Text.ToLower());
                List<int> list = srv.getProductSells(txtProdName.Text.ToLower());
                //txtProdId.Text = srv.getProductID(dropProdName.SelectedValue.ToLower());
                //List<int> list = srv.getProductSells(dropProdName.SelectedValue.ToLower());

                txtq1.Text = list.ElementAt(0).ToString();
                txtq2.Text = list.ElementAt(1).ToString();
                txtq3.Text = list.ElementAt(2).ToString();
            }
            else
                lblExist.Text = "El producto no esta disponible!!";
        }

        protected void btnFechaAlta_Click(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha de Alta: " + srv.FormatoCorrecto(txtProdId.Text.ToLower());
        }

        protected void btnProm_Click(object sender, EventArgs e)
        {
            if (txtq1.Text != "" && txtq2.Text != "" && txtq3.Text != "")
            {
                int q1 = Int32.Parse(txtq1.Text);
                int q2 = Int32.Parse(txtq2.Text);
                int q3 = Int32.Parse(txtq3.Text);

                float ave = (q1 + q2 + q3) / 3;

                txtPromedio.Text = ave.ToString();
            }
            else
                txtPromedio.Text = "Datos vacios!";
        }

        protected void txtProdName_TextChanged(object sender, EventArgs e)
        {
            txtProdId.Text = "";
            txtq1.Text = "";
            txtq2.Text = "";
            txtq3.Text = "";
            txtPromedio.Text = "";
            lblFecha.Text = "";
        }

        protected void dropProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProdName.Text = dropProdName.SelectedValue;
            dropProdName.SelectedItem.Selected = true;
        }

        protected void dropProdName_TextChanged(object sender, EventArgs e)
        {
            txtProdName.Text = dropProdName.SelectedValue;
        }


    }
}