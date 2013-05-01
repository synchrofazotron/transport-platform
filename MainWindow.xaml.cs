using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Bookstore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {  		
	
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
	{
		base.OnMouseLeftButtonDown(e);	
		// Begin dragging the window
		this.DragMove();
	}
	
	private void Minimize(object sender, RoutedEventArgs e)
	{
		this.WindowState = WindowState.Minimized;
	}
	
		private void Closew(object sender, RoutedEventArgs e)
	{
		this.Close();
	}



        public MainWindow()
        {
            InitializeComponent();


        }

        public class DBConnect  {

        public static List<Items> viewAll()
        {
            string connectionString = @"Data Source=BMW\SQLEXPRESS;Integrated security=SSPI;Initial Catalog=Bookstore";
            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String commandText = "SELECT * FROM sbs.goods";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Items item = new Items();
                            item.id = reader[0].ToString();
                            item.name = reader[1].ToString();
                            table.Add(item);
                        }
                    }
                }
            }
            return table;
        }
            }

    public class Items
    {
        public String id { get; set; }
        public String name { get; set; }
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //string connectionString = "Data Source=BMW\SQLEXPRESS;Integrated security=SSPI;Initial Catalog=Bookstore";
            //string connectionString = @"Data Source=BMW\SQLEXPRESS;Initial Catalog=Bookstore;Integrated Security=TrueConnect Timeout=30";
            //string sqlSelect = "SELECT * FROM sbs.goods";

            this.datagrid1.ItemsSource = DBConnect.viewAll();
            this.datagrid1.Items.Refresh();

            string connectionString = @"Data Source=BMW\SQLEXPRESS;Integrated security=SSPI;Initial Catalog=Bookstore";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT shop_id FROM sbs.shops", connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        combo1.Items.Add(new string[] { dr[0].ToString() });
                    }
                }
            }
    
        }
		
	}
}
