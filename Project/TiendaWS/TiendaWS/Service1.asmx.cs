using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TiendaWS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        List<Producto> getAllProducts()
        {
            List<Producto> list = new List<Producto>();
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                sells ventas = new sells();
                ventas.q1 = rand.Next(0, 100);
                ventas.q2 = rand.Next(0, 100);
                ventas.q3 = rand.Next(0, 100);

                string mes = rand.Next(10, 12).ToString();
                string dia = rand.Next(10, 31).ToString();
                string code = rand.Next(1000, 9999).ToString();
                string itemid = String.Concat("2015", mes, dia, code);

                Producto prod = new Producto("producto " + i, itemid , ventas);
                list.Add(prod);
            }

            return list;
        }

        Producto getProduct(string name)
        {
            List<Producto> list = getAllProducts();

            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).getName() == name)
                    return list.ElementAt(i);
            }

            return null;

        }

        [WebMethod]
        public List<string> getAllProductsNames()
        {
            List<Producto> list = getAllProducts();
            List<string> names = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                names.Add(list.ElementAt(i).getName());
            }

            return names;        
        }

        [WebMethod]
        public bool ExistProduct(string name)
        {
            if (getProduct(name) != null)
                return true;
            else
                return false;

        }

        [WebMethod]
        public string getProductID(string name)
        {
            return getProduct(name).getItemID();
        }

        [WebMethod]
        public List<int> getProductSells(string name)
        {
            Producto prod = getProduct(name);
            List<int> listsells = new List<int>();

            listsells.Add(prod.getSells().q1);
            listsells.Add(prod.getSells().q2);
            listsells.Add(prod.getSells().q3);

            return listsells;

        }

        [WebMethod]
        public float getProductAverageSells(string name)
        {
            return getProduct(name).AverageSells();
        }

        [WebMethod]
        public string FormatoCorrecto(string itemID)
        {
            if (itemID.Length < 12 || itemID.Length > 12)
                return "Longitud del No. de producto incorrecta.";

            try
            {
                Int64.Parse(itemID);
            }
            catch (Exception e)
            {
                return "El No. de producto no puede contener letras o simbolos.";
            }

            int anno = Int32.Parse(itemID.Substring(0, 4));//20151212
            int mes = Int32.Parse(itemID.Substring(4, 2));
            int dia = Int32.Parse(itemID.Substring(6, 2));

            DateTime fecha = new DateTime(anno, mes, dia);

            return fecha.ToString("dd/MM/yyyy");
        }

    }
}