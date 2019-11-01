using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaWS
{
    public struct sells
    {
        public int q1;
        public int q2;
        public int q3;
    }
    public class Producto
    {
        private string name;
        private string itemID;
        private sells ventas;

        public Producto(string pname, string pnoInv, sells pventas)
        {
            this.name = pname;
            this.itemID = pnoInv;
            this.ventas = pventas;

        }

        public string getName()
        {
            return this.name;
        }

        public string getItemID()
        {
            return this.itemID;
        }

        public sells getSells()
        {
            return this.ventas;
        }

        public float AverageSells()
        {
            return (ventas.q1 + ventas.q2+ ventas.q3 ) / 3;

        }
    }
}