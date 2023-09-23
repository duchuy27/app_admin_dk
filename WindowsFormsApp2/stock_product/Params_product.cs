using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.stock_product
{
    internal class Params_product
    {
        public string sEPC { get; set; }
        public string product_name { get; set; }
        public string sdt { get; set; }
        public string cmnd_cccd { get; set; }
        public int i { get; set; }
        public Params_product(string sEPC, string product_name, string sdt, string cmnd_cccd)
        {
            this.sEPC = sEPC;
            this.product_name = product_name;
            this.sdt = sdt;
            this.cmnd_cccd = cmnd_cccd;
        }
        public Params_product(string sEPC)
        {
            this.sEPC = sEPC;
        }
        public Params_product(string cmnd_cccd, int i)
        {
            this.cmnd_cccd = cmnd_cccd;
            this.i = i;
        }
        public Params_product(string sEPC, string sdt, string cmnd_cccd)
        {
            this.sEPC = sEPC;
            this.sdt = sdt;
            this.cmnd_cccd = cmnd_cccd;
        }
    }
}
