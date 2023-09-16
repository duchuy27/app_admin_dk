using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Stock_lot;

namespace WindowsFormsApp1.stock_product
{
    internal class json_product
    {
        public string jsonrpc { get; set; }
        public string id { get; set; }
        public List<stock_product_DTO> result { get; set; }

    }
}
