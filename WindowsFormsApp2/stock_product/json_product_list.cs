﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.stock_product
{
    internal class json_product_list
    {
        public string jsonrpc { get; set; }
        public string id { get; set; }
        public List<stock_product_DTO> result { get; set; }
    }
}
