using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Stock_lot
{
    internal class Params_lot
    {
        public string sEPC { get; set; }
        public int product_id { get; set; }
        public string bien_so { get; set; }
        public Params_lot(string sEPC, string bienso, int product_id)
        {
            this.sEPC = sEPC;
            this.product_id = product_id;
            this.bien_so = bienso;
        }
    }
}
