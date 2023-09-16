using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Stock_lot
{
    internal class Json_stock_lot
    {
        public string jsonrpc { get; set; }
        public string id { get; set; }
        public List<Stock_lot_DTO> result { get; set; }

    }
}
