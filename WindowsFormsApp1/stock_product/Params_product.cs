using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.stock_product
{
    internal class Params_product
    {
        public string sEPC { get; set; }
        public string product_name { get; set; }
        public string sdt { get; set; }
        public Params_product(string sEPC, string product_name, string sdt)
        {
            this.sEPC = sEPC;
            this.product_name = product_name;
            this.sdt = sdt;
        }
    }
}
