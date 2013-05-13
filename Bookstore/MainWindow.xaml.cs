using System;
using System.IO;
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
	
	
     // ---- Window control function's - START
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
    // ---- Window control function's - END





      // ---- MAIN WINDOW FUNC - START
        public MainWindow()
        {
            InitializeComponent();
            combo1.SelectionChanged += new SelectionChangedEventHandler(comboBox1SelectionChanged);


        }
      // ---- MAIN WINDOW FUNC - END

        
        
        

       
        
        // ---- Class for all items from DB - START
        public class Items
        {
            public String reader0 { get; set; }
            public String reader1 { get; set; }
            public String reader2 { get; set; }
            public String reader3 { get; set; }
            public String reader4 { get; set; }
            public String reader5 { get; set; }
            public override String ToString()
            {
                return reader0;
            }
        }
        // ---- Class for all items from DB - END

        // ---- Datagrid fill function for client's - START
        public class DBConnect  {

        public static List<Items> viewAll(string shop_name_string)
        {
            if (shop_name_string == "'<All shops>'")
                shop_name_string = "'%'";
            string[] connectionString = File.ReadAllLines("config.txt");
            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(connectionString[0]))
            {
                //String commandText = "SELECT goods_t.book_name, goods_t.price, goods_t.genre, goods_t.authors, shops_t.shop_name, shopassort.shop_amount FROM sbs.shop_assort shopassort LEFT JOIN sbs.goods goods_t ON shopassort.item_id = goods_t.item_id LEFT JOIN sbs.shops shops_t ON shopassort.shop_id = shops_t.shop_id ORDER BY shop_name";
                String commandText = "SELECT subquery.book_name, subquery.price, subquery.genre, subquery.authors, subquery.shop_name, subquery.shop_amount  FROM (SELECT goods_t.book_name, goods_t.price, goods_t.genre, goods_t.authors, shops_t.shop_name, shopassort.shop_amount FROM sbs.shop_assort shopassort LEFT JOIN sbs.goods goods_t ON shopassort.item_id = goods_t.item_id LEFT JOIN sbs.shops shops_t ON shopassort.shop_id = shops_t.shop_id) subquery WHERE shop_name LIKE"+ shop_name_string +" ORDER BY shop_name";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Items item = new Items();
                            item.reader0 = reader[0].ToString();
                            item.reader1 = reader[1].ToString();
                            item.reader2 = reader[2].ToString();
                            item.reader3 = reader[3].ToString();
                            item.reader4 = reader[4].ToString();
                            item.reader5 = reader[5].ToString();
                            table.Add(item);
                        }
                    }
                }
            }
            return table;
        }
            }
        // ---- Datagrid fill function for client's - END



        // ---- COMBOX fill function for client's - START
        public class combobox
        {
            public static List<Items> viewbox()
            {
                string [] connectionString = File.ReadAllLines("config.txt") ;
                    List<Items> table = new List<Items>();
                    using (SqlConnection connection = new SqlConnection(connectionString[0]))
                    {
                        String commandText = "SELECT shop_name FROM sbs.shops ORDER BY shop_name";
                        using (SqlCommand command = new SqlCommand(commandText, connection))
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Items item = new Items();
                                    item.reader0 = reader[0].ToString();
                                    table.Add(item);
                                }
                            }
                        }
                }
            return table;
            }
        
       }
        // ---- COMBOX fill function for client's - START
        
        // ---- COMBOX reed index for client's - START
        void comboBox1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (combo1.SelectedIndex < 0)
            {
                combo1.SelectedIndex = 0;
            }

            string shop_namestring = "'" + this.combo1.SelectedItem.ToString() + "'";
            this.datagrid1.ItemsSource = DBConnect.viewAll(shop_namestring);
        }
        // ---- COMBOX reed index for client's - END


        // ---- CLIENT button - START
        private void Button_ClientLogin(object sender, RoutedEventArgs e)
        {
            this.combo1.Visibility = System.Windows.Visibility.Visible;
            this.datagrid1.Visibility = System.Windows.Visibility.Visible;
            this.back.Visibility = System.Windows.Visibility.Visible;
            this.user.Visibility = System.Windows.Visibility.Hidden;
            this.img_openbook.Visibility = System.Windows.Visibility.Hidden;
            this.expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.admin.Visibility = System.Windows.Visibility.Hidden;
            this.label_c.Visibility = System.Windows.Visibility.Hidden;

            this.datagrid1.ItemsSource = DBConnect.viewAll("'%'");
            this.datagrid1.Items.Refresh();
            this.combo1.ItemsSource = combobox.viewbox();
            this.combo1.Items.Refresh();
            
        }
        // ---- CLIENT button - END

        // ---- Return button - START
        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.combo1.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid1.Visibility = System.Windows.Visibility.Hidden;
            this.back.Visibility = System.Windows.Visibility.Hidden;
            this.user.Visibility = System.Windows.Visibility.Visible;
            this.img_openbook.Visibility = System.Windows.Visibility.Visible;
            this.expeditor.Visibility = System.Windows.Visibility.Visible;
            this.admin.Visibility = System.Windows.Visibility.Visible;
            this.label_c.Visibility = System.Windows.Visibility.Visible;
        }
        // ---- Return button - END

        // ---- EXPEDITOR button - START
        private void expeditor_Click(object sender, RoutedEventArgs e)
        {
            const string message =
        "This function is already in progress...";
            const string caption = "Expeditor";
           MessageBox.Show(message, caption, MessageBoxButton.OK);

            
        }
        // ---- EXPEDITOR button - END


        //admin button
        private void admin_Click(object sender, RoutedEventArgs e)
        {
            const string message =
        "This function is already in progress...";
            const string caption = "Administrator";
            MessageBox.Show(message, caption, MessageBoxButton.OK);
        }
	}
}


/* код от тестовой кнопки
            this.datagrid1.ItemsSource = DBConnect.viewAll();
            this.datagrid1.Items.Refresh();
            this.combo1.ItemsSource = combobox.viewbox();
            this.combo1.Items.Refresh();
*/