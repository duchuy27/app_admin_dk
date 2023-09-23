using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.stock_product
{
    internal class stock_product_DTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string sdt { get; set; }
        public string ma_dinh_danh { get; set; }
        public string cmnd_cccd { get; set; }
        public List<object> cars { get; set; }
    }
}
