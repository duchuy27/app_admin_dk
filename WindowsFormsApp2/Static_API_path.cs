using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Static_API_path
    {
        public static string url_server = "http://192.168.1.50:8069";
        public static string api_post_move_history = "/parking/post/move_history";
        public static string api_post_keep_alive = "/parking/keep/alive";
        public static string api_check_product = "/parking/post/check_product";
        public static string api_post_out_move_history = "/parking/post/out/move_history";
        public static string api_post_product_first_time = "/parking/post/product_first_time";
        public static string api_post_in_move_history = "/parking/post/in/move_history";
        public static string api_get_all_move_history = "/parking/get/all/move_history";
        public static string api_get_all_stock_lot = "/parking/get/all/stock/lot";
        public static string api_get_all_stock_location = "/parking/get/all/stock/location";
        public static string api_save_Ng = "/parking/post/save/person";
        public static string api_get_all_product = "/parking/get/all/product";
        public static string api_save_Xe = "/parking/post/save/car";
        public static string api_get_person_by_epc = "/parking/get/person_by_epc";
        public static string api_get_person_by_cmnd_cccd = "/parking/get/person_by_cmnd_cccd";
        public static string api_post_update_person = "/parking/update/person";
        public static string api_post_update_car = "/parking/update/car";
        public static string api_get_car_by_epc_nguoi = "/parking/get/car_by_the_nguoi";
    }
}
