﻿using System;
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
            combobox_exp_books.SelectionChanged += new SelectionChangedEventHandler(comboBox2SelectionChanged);
            combobox_warehouse_select.SelectionChanged +=new SelectionChangedEventHandler(combobox_warehouse_loc_select_SelectionChanged);
            txtbox_client_surr.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
            txt_box_client_name.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
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

        // ---- EXECUT sacalar function - START
        static public int ExecutScalarQuery(string sql)
        {
            Int32 ID = 0;
            using (SqlConnection conn = new SqlConnection(Global.connectionString[0]))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    ID = (Int32)cmd.ExecuteScalar();
                }
                catch //(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    //return 0;
                }
            }
            return (int)ID;
        }
        // ---- EXECUT sacalar function - END



        // ---- Query function - START
        public byte DBQuery(String commandText)
        {
            byte status = 0;
            SqlConnection conn = new SqlConnection(Global.connectionString[0]);
            try
            {
                conn.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Connection error: {0}", se.Message, MessageBoxButton.OK);
                status = 1;
                return status;
            }


            SqlCommand cmd = new SqlCommand(commandText, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Request error!");
                status = 1;
                return status;
            } 
            conn.Close();
            conn.Dispose();
            return status;
        }
        // ---- Query function - END


       
        // ---- Datagrid fill function for client's - START
        public class DBConnect  {

            public static List<Items> reader_column_2x(String commandText)
            {

                
                List<Items> table = new List<Items>();
                using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                                table.Add(item);
                            }
                        }
                    }
                    connection.Close();
                    connection.Dispose();
                }
                return table;
            }


            public static List<Items> reader_column_6x(String commandText)
        {

            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                connection.Close();
                connection.Dispose();
            }
            return table;
        }


            public static List<Items> reader_column_5x(String commandText)
            {

                List<Items> table = new List<Items>();
                using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                                table.Add(item);
                            }
                        }
                    }
                    connection.Close();
                    connection.Dispose();
                }
                return table;
            }


        /// ---- Datagrid fill function for EXPEDITOR's - START

            public static List<Items> reader_column_7x(String commandText)
        {

            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                connection.Close();
                connection.Dispose();
            }
            return table;
        }

            ///  ---- Datagrid fill function for EXPEDITOR's - END


        /// ---- Datagrid fill BOOKS function for EXPEDITOR's - START

            public static List<Items> reader_column_4x(String commandText)
        {

            List<Items> table = new List<Items>();
            using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                connection.Close();
                connection.Dispose();
            }
            return table;
        }

            ///  ---- Datagrid fill BOOKS function for EXPEDITOR's - END


            public static List<Items> reader_column_3x(String commandText)
            {

                List<Items> table = new List<Items>();
                using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                    connection.Close();
                    connection.Dispose();
                }
                return table;
            }


            public static List<Items> reader_column_1x(string combobox_sql_command)
            {
                List<Items> table = new List<Items>();
                using (SqlConnection connection = new SqlConnection(Global.connectionString[0]))
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
                    connection.Close();
                    connection.Dispose();
                }
                return table;
            }


     }
        // ---- Datagrid fill function for client's - END

      
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
            this.datagrid1.ItemsSource = DBConnect.reader_column_6x("SELECT subquery.book_name, subquery.price, subquery.genre, subquery.authors, subquery.shop_name, subquery.shop_amount  FROM (SELECT goods_t.book_name, goods_t.price, goods_t.genre, goods_t.authors, shops_t.shop_name, shopassort.shop_amount FROM sbs.shop_assort shopassort LEFT JOIN sbs.goods goods_t ON shopassort.item_id = goods_t.item_id LEFT JOIN sbs.shops shops_t ON shopassort.shop_id = shops_t.shop_id) subquery WHERE shop_name LIKE " + shop_namestring + " ORDER BY shop_name");
        }
        // ---- COMBOX reed index for client's - END

        // ---- COMBOX reed index for EXPEDITOR's - START
        public void comboBox2SelectionChanged(object sender, EventArgs e)  //SelectionChanged
        {

            if (combobox_exp_books.SelectedIndex < 0)
            {
                combobox_exp_books.SelectedIndex = 0;
            }

            string shop_namestring = "'" + this.combobox_exp_books.SelectedItem.ToString() + "'";
            if (shop_namestring == "'<All shops>'")
                shop_namestring = "'%'";
            this.datagrid_books.ItemsSource = DBConnect.reader_column_4x("SELECT shops_t.shop_name, warehouse_t.warehouse_name, goods_t.book_name, avaliable_t.warehouse_amount FROM sbs.avaliable avaliable_t LEFT JOIN sbs.warehouse warehouse_t ON avaliable_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.goods goods_t ON avaliable_t.item_id = goods_t.item_id LEFT JOIN sbs.shop_warehouse shop_warehouse_t ON avaliable_t.warehouse_id = shop_warehouse_t.warehouse_id LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id WHERE shop_name LIKE " + shop_namestring + " ORDER BY shop_name");
        }
        // ---- COMBOX reed index for EXPEDITOR's - END



        // ---- EXPEDITOR CheckBoxes - START
        public void checkboxselect(object sender, EventArgs e)
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

            this.datagrid_orderstatus.ItemsSource = DBConnect.reader_column_7x("SELECT subquery.order_id, subquery.book_name, subquery.amount, subquery.last_name +' '+ subquery.first_name AS name, subquery.warehouse_name, subquery.last_name_exp + ' ' + subquery.first_name_exp AS name2, subquery.order_status FROM (SELECT orders_t.order_id, orders_t.order_status, orders_t.amount, goods_t.book_name, client_info_t.last_name, client_info_t.first_name, warehouse_t.warehouse_name, expeditor_t.last_name_exp, expeditor_t.first_name_exp FROM sbs.orders orders_t LEFT JOIN sbs.goods goods_t ON orders_t.item_id = goods_t.item_id LEFT JOIN sbs.client_info client_info_t ON orders_t.client_id = client_info_t.client_id LEFT JOIN sbs.warehouse warehouse_t ON orders_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.expeditor expeditor_t ON orders_t.expeditor_id = expeditor_t.expeditor_id) subquery WHERE order_status " + order_filter + " ORDER BY order_id");
            this.datagrid_orderstatus.Items.Refresh();
            this.complete_order.IsEnabled = false;
            this.reject_order.IsEnabled = false;
            this.order_status_change.IsEnabled = false;
        }
        // ---- EXPEDITOR CheckBoxes - END


        // ---- CLIENT button - START
        private void Button_ClientLogin(object sender, RoutedEventArgs e)
        {
            this.combo1.Visibility = System.Windows.Visibility.Visible;
            this.datagrid1.Visibility = System.Windows.Visibility.Visible;
            this.back.Visibility = System.Windows.Visibility.Visible;
            this.client_orders.Visibility = System.Windows.Visibility.Visible;
            this.user.Visibility = System.Windows.Visibility.Hidden;
            this.img_openbook.Visibility = System.Windows.Visibility.Hidden;
            this.expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.admin.Visibility = System.Windows.Visibility.Hidden;
            this.label_c.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_warehouse.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;

            this.datagrid1.ItemsSource = DBConnect.reader_column_6x("SELECT subquery.book_name, subquery.price, subquery.genre, subquery.authors, subquery.shop_name, subquery.shop_amount  FROM (SELECT goods_t.book_name, goods_t.price, goods_t.genre, goods_t.authors, shops_t.shop_name, shopassort.shop_amount FROM sbs.shop_assort shopassort LEFT JOIN sbs.goods goods_t ON shopassort.item_id = goods_t.item_id LEFT JOIN sbs.shops shops_t ON shopassort.shop_id = shops_t.shop_id) subquery WHERE shop_name LIKE '%' ORDER BY shop_name");
            this.datagrid1.Items.Refresh();
            this.combo1.ItemsSource = DBConnect.reader_column_1x("SELECT shop_name FROM sbs.shops ORDER BY shop_name");
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
            this.order_status_change.IsEnabled = false;
            this.order_status_expander.IsExpanded = false;
            this.Warehouse_expander.IsExpanded = false;
            this.Books_expander.IsExpanded = false;
            this.admin_warehouse.IsExpanded = false;
            this.img_expeditor.Visibility = System.Windows.Visibility.Hidden;
            this.admin_panel_left.Visibility = System.Windows.Visibility.Hidden;
            this.admin_img_png.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_books.Visibility = System.Windows.Visibility.Hidden;
            this.Admin12.Visibility = System.Windows.Visibility.Hidden;
            this.Admin12.Height = 0;
            this.datagrid_admin12.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid_client_5.Visibility = System.Windows.Visibility.Hidden;
            this.client_orders.Visibility = System.Windows.Visibility.Hidden;

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
            this.order_status_change.IsEnabled = false;


        }
        // ---- EXPEDITOR button - END


        //admin button
        private void admin_Click(object sender, RoutedEventArgs e)
        {
            this.back.Visibility = System.Windows.Visibility.Visible;
            this.admin_panel_left.Visibility = System.Windows.Visibility.Visible;
            this.admin_img_png.Visibility = System.Windows.Visibility.Visible;
            this._dialogShow.IsEnabled = true;
            this.admin_img_png.Opacity = 100;

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

            Items item = (Items)datagrid_orderstatus.SelectedItem;
            if (!item.reader6.Equals("Нова"))
            {
                MessageBox.Show("You can modify orders with 'Нова' status only!");
                return;
            }
            Order_Form order_form = new Order_Form();
            Order_Form.instance.textBox_Order_id.Text = item.reader0;
            Order_Form.instance.textBox_Amount.Text = item.reader2;
            Order_Form.instance.richTextBox_book_name.Text = item.reader1;
            List<Items> get_warehouse_propery_item = new List<Items>(DBConnect.reader_column_3x("SELECT subquery.warehouse_name, subquery.warehouse_id, subquery.item_id FROM (SELECT warehouse_t.warehouse_name, warehouse_t.warehouse_id, goods_t.book_name, avaliable_t.warehouse_amount, goods_t.item_id FROM sbs.warehouse warehouse_t LEFT JOIN sbs.avaliable avaliable_t ON avaliable_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.goods goods_t ON avaliable_t.item_id = goods_t.item_id) subquery WHERE subquery.book_name LIKE '" + item.reader1 + "' AND subquery.warehouse_amount >= '" + item.reader2 + "' ORDER BY warehouse_name"));
            for (int i = 0; i < get_warehouse_propery_item.Count; i++)
                Global.get_warehouse_propery_string.Add(string.Format("{0}", get_warehouse_propery_item[i].reader1));
            Global.get_bookID_propery_string = get_warehouse_propery_item[0].reader2;

            Order_Form.instance.comboBox_warehouse.DataSource = get_warehouse_propery_item;
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
            this.order_status_change.IsEnabled = true;
        }
        // ---- Selection chandeg, orders datagrid, for EXPEDITOR - END


        // -- Expanded func for Orders - START
        private void Orders_Expanded(object sender, RoutedEventArgs e)
        {
            this.datagrid_orderstatus.ItemsSource = DBConnect.reader_column_7x("SELECT subquery.order_id, subquery.book_name, subquery.amount, subquery.last_name +' '+ subquery.first_name AS name, subquery.warehouse_name, subquery.last_name_exp + ' ' + subquery.first_name_exp AS name2, subquery.order_status FROM (SELECT orders_t.order_id, orders_t.order_status, orders_t.amount, goods_t.book_name, client_info_t.last_name, client_info_t.first_name, warehouse_t.warehouse_name, expeditor_t.last_name_exp, expeditor_t.first_name_exp FROM sbs.orders orders_t LEFT JOIN sbs.goods goods_t ON orders_t.item_id = goods_t.item_id LEFT JOIN sbs.client_info client_info_t ON orders_t.client_id = client_info_t.client_id LEFT JOIN sbs.warehouse warehouse_t ON orders_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.expeditor expeditor_t ON orders_t.expeditor_id = expeditor_t.expeditor_id) subquery WHERE order_status LIKE '%' ORDER BY order_id");
            this.datagrid_orderstatus.Items.Refresh();
            this.complete_order.IsEnabled = false;
            this.reject_order.IsEnabled = false;
            this.order_status_change.IsEnabled = false;
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
            this.datagrid_warehouse.ItemsSource = DBConnect.reader_column_3x("SELECT shops_t.shop_name, warehouse_t.warehouse_name, warehouse_t.location FROM sbs.shop_warehouse shop_warehouse_t LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id LEFT JOIN sbs.warehouse warehouse_t ON shop_warehouse_t.warehouse_id = warehouse_t.warehouse_id ORDER BY shop_name");
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
            this.datagrid_books.ItemsSource = DBConnect.reader_column_4x("SELECT shops_t.shop_name, warehouse_t.warehouse_name, goods_t.book_name, avaliable_t.warehouse_amount FROM sbs.avaliable avaliable_t LEFT JOIN sbs.warehouse warehouse_t ON avaliable_t.warehouse_id = warehouse_t.warehouse_id LEFT JOIN sbs.goods goods_t ON avaliable_t.item_id = goods_t.item_id LEFT JOIN sbs.shop_warehouse shop_warehouse_t ON avaliable_t.warehouse_id = shop_warehouse_t.warehouse_id LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id WHERE shop_name LIKE '%' ORDER BY shop_name");
            this.datagrid_books.Items.Refresh();
            this.combobox_exp_books.ItemsSource = DBConnect.reader_column_1x("SELECT shop_name FROM sbs.shops ORDER BY shop_name");
            this.combobox_exp_books.Items.Refresh();
            
        }

        private void book_add_new_Click_1(object sender, RoutedEventArgs e)
        {
            AddBookFrom add_book_form = new AddBookFrom();
            add_book_form.Show();
        }

        private void shop_ware_show_dialog(object sender, RoutedEventArgs e)
        {



            this.label_type.Visibility = System.Windows.Visibility.Hidden;
            
            List<Items> shop_ware_temp = new List<Items>(DBConnect.reader_column_1x("SELECT DISTINCT sbs.warehouse.warehouse_name FROM sbs.warehouse WHERE warehouse_id NOT LIKE '0' ORDER BY warehouse_name"));


            this.combobox_shop_Select.ItemsSource = DBConnect.reader_column_1x("SELECT shop_name FROM sbs.shops WHERE shop_id NOT LIKE '0' ORDER BY shop_name");
            this.combobox_warehouse_select.ItemsSource = shop_ware_temp;
            this.datagrid_admin12.ItemsSource = DBConnect.reader_column_3x("SELECT shops_t.shop_name, warehouse_t.warehouse_name, warehouse_t.location FROM sbs.shop_warehouse shop_warehouse_t LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id LEFT JOIN sbs.warehouse warehouse_t ON shop_warehouse_t.warehouse_id = warehouse_t.warehouse_id ORDER BY shop_name");

         
            this.Admin12.Visibility = System.Windows.Visibility.Visible;
            this.datagrid_admin12.Visibility = System.Windows.Visibility.Visible;
            this.Admin12.Height = 220;
            this._dialogShow.IsEnabled = false;
            if (combobox_shop_Select.SelectedIndex == -1)
                combobox_shop_Select.SelectedIndex = 0;
            if (combobox_warehouse_loc_select.SelectedIndex == -1)
                combobox_warehouse_loc_select.SelectedIndex = 0;
            if (combobox_warehouse_select.SelectedIndex == -1)
                combobox_warehouse_select.SelectedIndex = 0;
        }//Uggly code. notime for optimisation

        public void combobox_warehouse_loc_select_SelectionChanged(object sender, EventArgs e)
        {
            if (combobox_warehouse_select.SelectedIndex < 0)
            {
                combobox_warehouse_select.SelectedIndex = 0;
            }

            

            string shop_namestring = "'" + this.combobox_warehouse_select.SelectedItem.ToString() + "'";
            List<string> _temp_string = new List<string>();
            this.datagrid_admin12.ItemsSource = DBConnect.reader_column_3x("SELECT shops_t.shop_name, warehouse_t.warehouse_name, warehouse_t.location FROM sbs.shop_warehouse shop_warehouse_t LEFT JOIN sbs.shops shops_t ON shop_warehouse_t.shop_id = shops_t.shop_id LEFT JOIN sbs.warehouse warehouse_t ON shop_warehouse_t.warehouse_id = warehouse_t.warehouse_id WHERE warehouse_name LIKE"+ shop_namestring +" ORDER BY shop_name");

            List<Items> _temp = new List<Items>(DBConnect.reader_column_1x("SELECT DISTINCT warehouse_t.location FROM sbs.warehouse warehouse_t LEFT JOIN sbs.shop_warehouse shop_warehouse_t ON shop_warehouse_t.warehouse_id = warehouse_t.warehouse_id WHERE warehouse_name LIKE" + shop_namestring + " ORDER BY location"));
            this.combobox_warehouse_loc_select.ItemsSource = _temp;

            if (combobox_warehouse_loc_select.SelectedIndex < 0)
                combobox_warehouse_loc_select.SelectedIndex = 0;

        }//Uggly code. notime for optimisation

        private void button_add_shop_to_ware_Click(object sender, RoutedEventArgs e)
        {
            int _temp_id =  ExecutScalarQuery("SELECT shops_t.shop_id FROM sbs.shops shops_t WHERE shop_name LIKE '" + combobox_shop_Select.SelectedValue +"'");
            int _temp_ware = ExecutScalarQuery("SELECT warehouse_t.warehouse_id FROM sbs.warehouse warehouse_t WHERE warehouse_name LIKE '"+combobox_warehouse_select.SelectedValue+"' AND location LIKE '"+combobox_warehouse_loc_select.SelectedValue+"'");
            DBQuery("INSERT INTO [sbs].[shop_warehouse] ([shop_id], [warehouse_id]) VALUES (N'"+_temp_id +"', N'"+_temp_ware+"')");
            combobox_warehouse_loc_select_SelectionChanged(sender, e);
        }//Uggly code. notime for optimisation

        private void button_delete_shop_from_ware_Click(object sender, RoutedEventArgs e) 
        {
            if (combobox_shop_Select.SelectedIndex == -1)
                combobox_shop_Select.SelectedIndex = 0;
            
            int _temp_id = ExecutScalarQuery("SELECT shops_t.shop_id FROM sbs.shops shops_t WHERE shop_name LIKE '" + combobox_shop_Select.SelectedValue + "'");
            int _temp_ware = ExecutScalarQuery("SELECT warehouse_t.warehouse_id FROM sbs.warehouse warehouse_t WHERE warehouse_name LIKE '" + combobox_warehouse_select.SelectedValue + "' AND location LIKE '" + combobox_warehouse_loc_select.SelectedValue + "'");
            int _temp_status = ExecutScalarQuery("SELECT order_id FROM sbs.orders WHERE warehouse_id = '"+_temp_ware+"' AND order_status = 'У виконанні' AND expeditor_id IN (SELECT sbs.expeditor.expeditor_id FROM sbs.expeditor WHERE shop_id = '"+_temp_id+"')");
            if (_temp_status == 0)
            {
                _temp_status = DBQuery("DELETE FROM sbs.shop_warehouse WHERE shop_id = '" + _temp_id + "' AND warehouse_id = '" + _temp_ware + "'");
                combobox_warehouse_loc_select_SelectionChanged(sender, e);

            }
            else
            {
                MessageBox.Show("Delete error! Please, finish all order's for that warehouse.");
            }

        }//Uggly code. notime for optimisation


        private void txt_box_client_name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (this.txt_box_client_name.Text == "Name")
                this.txt_box_client_name.Clear();
        }

        private void txt_box_client_name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (this.txt_box_client_name.Text == "")
                this.txt_box_client_name.Text = "Name";

        }

        private void txtbox_client_surr_LostFocus(object sender, RoutedEventArgs e)
        {
            if (this.txtbox_client_surr.Text == "")
                this.txtbox_client_surr.Text = "Surname";
        }

        private void txtbox_client_surr_GotFocus(object sender, RoutedEventArgs e)
        {
            if (this.txtbox_client_surr.Text == "Surname")
                this.txtbox_client_surr.Clear();
        }

        private void client_expander_exp(object sender, RoutedEventArgs e)
        {
                this.datagrid_client_5.Visibility = System.Windows.Visibility.Visible;
                this.datagrid1.Visibility = System.Windows.Visibility.Hidden;


        }

        private void client_orders_Collapsed(object sender, RoutedEventArgs e)
        {
            this.datagrid_client_5.Visibility = System.Windows.Visibility.Hidden;
            this.datagrid1.Visibility = System.Windows.Visibility.Visible;
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsLetter(e.Text, 0)) e.Handled = true;
        }

        private void txtbox_client_surr_TextChanged(object sender, RoutedEventArgs e)
        {
            string name = this.txt_box_client_name.Text.Trim();
            string surn = this.txtbox_client_surr.Text.Trim();
            this.datagrid_client_5.ItemsSource = DBConnect.reader_column_5x("SELECT goods_t.book_name, orders_t.amount, shops_t.shop_name, orders_t.order_status, orders_t.[date] FROM sbs.orders orders_t LEFT JOIN sbs.goods goods_t on orders_t.item_id = goods_t.item_id LEFT JOIN sbs.client_info client_info_t ON orders_t.client_id = client_info_t.client_id LEFT JOIN sbs.expeditor expeditor_t ON orders_t.expeditor_id = expeditor_t.expeditor_id LEFT JOIN sbs.shops shops_t ON expeditor_t.shop_id = shops_t.shop_id WHERE first_name = '"+name+"' AND last_name = '"+surn+"'");
        }

        

 
	}
}
 
