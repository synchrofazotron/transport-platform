using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Global
    {
        public static List<string> get_warehouse_propery_string = new List<string>();
        public static string get_bookID_propery_string;
        public static string[] connectionString = File.ReadAllLines("config.txt");
    }
}
