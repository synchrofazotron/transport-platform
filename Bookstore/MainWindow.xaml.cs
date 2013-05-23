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
        public static MainWindow instance;
	
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
            instance = this;
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
            public String reader6 { get; set; }
            public override String ToString()
            {
                return reader0;
            }
        }

        // ---- Class for all items from DB - END

        static public int ExecutScalarQuery(string sql)
        {
            Int32 ID = 0;
            string[] connString = File.ReadAllLines("config.txt");
            using (SqlConnection conn = new SqlConnection(connString[0]))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    ID = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return (int)ID;
        }


        // ---- EXECUT sacalar function - START





        // ---- EXECUT sacalar function - END



        // ---- Query function - START
        public void DBQuery(String commandText)
        {
            string[] connString = File.ReadAllLines("config.txt");
            SqlConnection conn = new SqlConnection(connString[0]);
            try
            {
                conn.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Connection error: {0}", se.Message, MessageBoxButton.OK);
                return;
            }


            SqlCommand cmd = new SqlCommand(commandText, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Request error!");

                return;
            }
            conn.Close();
            conn.Dispose();
        }
        // ---- Query function - END


       
        // ---- Datagrid fill function for client's - START
        public class DBConnect  {

 
        public static List<Items> viewAll(String commandText)
        {

            string[] connectionString = File.ReadAllLines("config.txt");
            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(connectionString[0]))
            {
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



        /// ---- Datagrid fill function for EXPEDITOR's - START

        public static List<Items> expeditorpanel(String commandText)
        {

            string[] connectionString = File.ReadAllLines("config.txt");
            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(connectionString[0]))
            {
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
                            item.reader6 = reader[6].ToString();
                            table.Add(item);
                        }
                    }
                }
            }
            return table;
        }

            ///  ---- Datagrid fill function for EXPEDITOR's - END


        /// ---- Datagrid fill BOOKS function for EXPEDITOR's - START

        public static List<Items> books_fill(String commandText)
        {

            string[] connectionString = File.ReadAllLines("config.txt");
            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(connectionString[0]))
            {
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
                            table.Add(item);
                        }
                    }
                }
            }
            return table;
        }

            ///  ---- Datagrid fill BOOKS function for EXPEDITOR's - END



            }
        // ---- Datagrid fill function for client's - END



        // ---- Datagrid fill function for WAREHOUSE - START
        public class warehousefill
        {

            public static List<Items> viewAll(String commandText)
            {

                string[] connectionString = File.ReadAllLines("config.txt");
                List<Items> table = new List<Items>();
                using (SqlConnection connection = new SqlConnection(connectionString[0]))
                {
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
                                table.Add(item);
                            }
                        }
                    }
                }
                return table;
            }
        }
        // ---- Datagrid fill function for WAREHOUSE - END



        // ---- COMBOX fill function for client's - START
        public class combobox
        {
            public static List<Items> viewbox(string combobox_sql_command)
            {
                string [] connectionString = File.ReadAllLines("config.txt") ;
                    List<Items> table = new List<Items>();
                    using (SqlConnection connection = new SqlConnection(connectionString[0]))
                    {
                        String commandText = combobox_sql_command;
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
            if (shop_namestring == "'<All shops>'")
                shop_namestring = "'%'";
            this.datagrid1.ItemsSource = DBConnect.viewAll("SELECT subquery.book_name, subquery.price, subquery.genre, subquery.authors, subquery.shop_name, subquery.shop_amount  FROM (SELECT goods_t.book_name, goods_t.price, goods_t.genre, goods_t.authors, shops_t.shop_name, shopassort.shop_amount FROM sbs.shop_assort shopassort LEFT JOIN sbs.goods goods_t ON shopassort.item_id = goods_t.item_id LEFT JOIN sbs.shops shops_t ON shopassort.shop_id = shops_t.shop_id) subquery WHERE shop_name LIKE " + shop_namestring + " ORDER BY shop_name");
        }
        // ---- COMBOX reed index for client's - END

        // ---- EXPEDITOR CheckBoxes - START
        public void checkboxselect(object sender, RoutedEventArgs e)
        {
             List<string> check_box_list = new List<string>();
             if (New.IsChecked == true)
                 check_box_list.Add(string.Format("{0}", New.Content));
            if (rejected.IsChecked == true)
                check_box_list.Add(string.Format("{0}", rejected.Content));
            if (canceled.IsChecked == true)
                check_box_list.Add(string.Format("{0}", canceled.Content));
            if (completed.IsChecked == true)
                check_box_list.Add(string.Format("{0}", completed.Content));
            if (inprogress.IsChecked == true)
                check_box_list.Add(string.Format("{0}", inprogress.Content));

            string order_filter = "";
            if (check_box_list.Count == 0)
                order_filter = "LIKE '%'";

            if (check_box_list.Count == 1)
                order_filter = "IN ('" + check_box_list[0] + "')";
            else if (check_box_list.Count > 1)
            {
                for (int i = 0; i < check_box_list.Count - 1; i++)
                    order_filter += "'" + check_box_list[i] + "'" + ", ";
                order_filter += "'" + check_box_list[check_box_list.Count - 1] + "'";
                order_filter = "IN (" + order_filter + ")";
            }

            this.datagrid_orderstatus.ItemsSource = DBConnect.expeditorpanel("SELECT subquery.order_id, subquery.book_name, subquery.amount, subquery.last_name, subquery.warehouse_name, subquery.last_name_exp, subquery.order_status FROM (SELECT orders_t.order_id, orders_t.order_status, orders_t.amount, goods_t.book_name, client_info_t.last_name, warehouse_t.warehouse_name, expeditor_t.last_name_exp FROM sbs.orders orders_t LEFT JOIN sbs.goods goods_t ON orders_t.item_id = goods_t.item_id LEFT JOIN sbs.client_info client_info_t ON orders_t.client_id = client_info_t.client_id LEFT JOIN sbs.warehouse warehouse_t ON orders_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.expeditor expeditor_t ON orders_t.expeditor_id = expeditor_t.expeditor_id) subquery WHERE order_status " + order_filter + " ORDER BY order_id");
            this.datagrid_orderstatus.Items.Refresh();
            this.complete_order.IsEnabled = false;
            this.reject_order.IsEnabled = false;
        }
        // ---- EXPEDITOR CheckBoxes - END


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
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;

            this.datagrid1.ItemsSource = DBConnect.viewAll("SELECT subquery.book_name, subquery.price, subquery.genre, subquery.authors, subquery.shop_name, subquery.shop_amount  FROM (SELECT goods_t.book_name, goods_t.price, goods_t.genre, goods_t.authors, shops_t.shop_name, shopassort.shop_amount FROM sbs.shop_assort shopassort LEFT JOIN sbs.goods goods_t ON shopassort.item_id = goods_t.item_id LEFT JOIN sbs.shops shops_t ON shopassort.shop_id = shops_t.shop_id) subquery WHERE shop_name LIKE '%' ORDER BY shop_name");
            this.datagrid1.Items.Refresh();
            this.combo1.ItemsSource = combobox.viewbox("SELECT shop_name FROM sbs.shops ORDER BY shop_name");
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
            this.order_list_box.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.complete_order.IsEnabled = false;
            this.reject_order.IsEnabled = false;
            this.order_status_expander.IsExpanded = false;
            this.Warehouse_expander.IsExpanded = false;
            this.img_expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.admin_panel_left.Visibility = System.Windows.Visibility.Hidden;
            this.admin_img_png.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;

        }
        // ---- Return button - END

        // ---- EXPEDITOR button - START
        private void expeditor_Click(object sender, RoutedEventArgs e)
        {

            this.order_list_box.Visibility = System.Windows.Visibility.Visible;
            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Visible;
            this.back.Visibility = System.Windows.Visibility.Visible;
            this.user.Visibility = System.Windows.Visibility.Hidden;
            this.img_openbook.Visibility = System.Windows.Visibility.Hidden;
            this.expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.admin.Visibility = System.Windows.Visibility.Hidden;
            this.label_c.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Hidden;
            this.img_expeditor.Visibility = System.Windows.Visibility.Visible;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;

            this.complete_order.IsEnabled = false;
            this.reject_order.IsEnabled = false;

        }
        // ---- EXPEDITOR button - END


        //admin button
        private void admin_Click(object sender, RoutedEventArgs e)
        {
        //    const string message =
        //"Will be added soon...";
        //    const string caption = "Administrator";
        //    MessageBox.Show(message, caption, MessageBoxButton.OK);

            this.back.Visibility = System.Windows.Visibility.Visible;
            this.admin_panel_left.Visibility = System.Windows.Visibility.Visible;
            this.admin_img_png.Visibility = System.Windows.Visibility.Visible;

            this.user.Visibility = System.Windows.Visibility.Hidden;
            this.img_openbook.Visibility = System.Windows.Visibility.Hidden;
            this.expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.admin.Visibility = System.Windows.Visibility.Hidden;
            this.label_c.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;
            
        }

        // ---- Button for editing orders, for EXPEDITOR - START
        private void order_status_change_Click(object sender, RoutedEventArgs e)
        {
            Order_Form order_form = new Order_Form();
            order_form.Show();
        }
        // ---- Button for editing orders, for EXPEDITOR - END


        // ---- Button for complete orders, for EXPEDITOR - START
        private void complete_order_Click(object sender, RoutedEventArgs e)
        {
            Items item = (Items)datagrid_orderstatus.SelectedItem;
            if (!item.reader6.Equals("У виконанні"))
            {
                MessageBox.Show("You can modify orders with 'У виконанні' status only!");
                return;
            }
            DBQuery("UPDATE sbs.orders SET order_status = 'Виконана' WHERE order_id = '" + item + "'");
            checkboxselect(sender,e);   
        }

        // ---- Button for complete orders, for EXPEDITOR - END


        // ---- Button for REJECT orders, for EXPEDITOR - START
        private void reject_order_Click(object sender, RoutedEventArgs e)
        {
            Items item = (Items)datagrid_orderstatus.SelectedItem;
            if (!item.reader6.Equals("Нова"))
            {
                MessageBox.Show("You can modify orders with 'Нова' status only!");
                return;
            }
            DBQuery("UPDATE sbs.orders SET order_status = 'Відхилена' WHERE order_id = '" + item + "'");
            checkboxselect(sender, e);
        }

        // ---- Button for REJECT orders, for EXPEDITOR - END


        // ---- Selection chandeg, orders datagrid, for EXPEDITOR - START
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.complete_order.IsEnabled = true;
            this.reject_order.IsEnabled = true;
        }
        // ---- Selection chandeg, orders datagrid, for EXPEDITOR - END


        // -- Expanded func for Orders - START
        private void Orders_Expanded(object sender, RoutedEventArgs e)
        {
            this.datagrid_orderstatus.ItemsSource = DBConnect.expeditorpanel("SELECT subquery.order_id, subquery.book_name, subquery.amount, subquery.last_name, subquery.warehouse_name, subquery.last_name_exp, subquery.order_status FROM (SELECT orders_t.order_id, orders_t.order_status, orders_t.amount, goods_t.book_name, client_info_t.last_name, warehouse_t.warehouse_name, expeditor_t.last_name_exp FROM sbs.orders orders_t LEFT JOIN sbs.goods goods_t ON orders_t.item_id = goods_t.item_id LEFT JOIN sbs.client_info client_info_t ON orders_t.client_id = client_info_t.client_id LEFT JOIN sbs.warehouse warehouse_t ON orders_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.expeditor expeditor_t ON orders_t.expeditor_id = expeditor_t.expeditor_id) subquery WHERE order_status LIKE '%' ORDER BY order_id");
            this.datagrid_orderstatus.Items.Refresh();
            this.complete_order.IsEnabled = false;
            this.reject_order.IsEnabled = false;
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Visible;
            this.img_expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;
        }
        // -- Expanded func for Orders - END

        // -- Expanded func for Warehouse - START
        private void Warehouse_Expander_Expanded(object sender, RoutedEventArgs e)
        {
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Visible;
            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_warehouse.ItemsSource = warehousefill.viewAll("SELECT shops_t.shop_name, warehouse_t.warehouse_name, shop_warehouse_t.warehouse_type FROM sbs.shop_warehouse shop_warehouse_t LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id LEFT JOIN sbs.warehouse warehouse_t ON shop_warehouse_t.warehouse_id = warehouse_t.warehouse_id ORDER BY shop_name");
            this.datagrid_warehouse.Items.Refresh();
            this.img_expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;

        }
        // -- Expanded func for Orders - END

        public void admin_warehouse_add_btn_Click_1(object sender, RoutedEventArgs e)
        {
            Admin_AddWarehouse add_warehouse_form = new Admin_AddWarehouse();
            add_warehouse_form.Show();
            Admin_AddWarehouse.instance.warehouse_ID_get(ExecutScalarQuery("SELECT MAX(warehouse.warehouse_id) FROM sbs.warehouse"));
        }

        private void Books_expander_Expanded_1(object sender, RoutedEventArgs e)
        {
            this.datagrid_books.Visibility = System.Windows.Visibility.Visible;


            this.datagrid_orderstatus.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.img_expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.ItemsSource = DBConnect.books_fill("SELECT shops_t.shop_name, warehouse_t.warehouse_name, goods_t.book_name, avaliable_t.warehouse_amount FROM sbs.avaliable avaliable_t LEFT JOIN sbs.warehouse warehouse_t ON avaliable_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.goods goods_t ON avaliable_t.item_id = goods_t.item_id LEFT JOIN sbs.shop_warehouse shop_warehouse_t ON avaliable_t.warehouse_id = shop_warehouse_t.warehouse_id LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id ORDER BY shop_name");
            this.datagrid_books.Items.Refresh();
            
        }
        

   
	}
}
 
