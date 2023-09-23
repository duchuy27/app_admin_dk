using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Stock_lot
{
    internal class Stock_lot_DTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public List<object> location_id { get; set; }
        public List<object> product_id { get; set; }
        public string bien_so { get; set; }
    }
    internal class Product_and_cars
    {
        public int id { get; set; }
        public string cmnd_cccd { get; set; }
        public string sdt { get; set; }
        public string name { get; set; }
        public List<object> cars { get; set; }
    }
}
