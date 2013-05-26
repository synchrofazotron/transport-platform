using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class AddBookFrom : Form
    {
        List<string> get_ware_temp_string = new List<string>();
        List<string> get_book_temp_string = new List<string>();
        
        public AddBookFrom()
        {
            InitializeComponent();
            List<MainWindow.Items> get_book_temp = new List<MainWindow.Items>(MainWindow.DBConnect.reader_column_2x("SELECT sbs.goods.book_name, sbs.goods.item_id FROM sbs.goods WHERE sbs.goods.item_id <> ALL (SELECT avaliable_t.item_id FROM sbs.avaliable avaliable_t WHERE warehouse_id = '3')"));
            this.listBox_BookName.DataSource = get_book_temp;
            for (int i = 0; i < get_book_temp.Count; i++)
                get_book_temp_string.Add(string.Format("{0}", get_book_temp[i].reader1));
            get_book_temp = MainWindow.DBConnect.reader_column_2x("SELECT sbs.warehouse.warehouse_name, sbs.warehouse.warehouse_id FROM sbs.warehouse WHERE warehouse_id NOT LIKE '0' ORDER BY warehouse_name");
            for (int i = 0; i < get_book_temp.Count; i++)
                get_ware_temp_string.Add(string.Format("{0}", get_book_temp[i].reader1));
            this.comboBox_AddNewBook_WarehouseName.DataSource = get_book_temp;
        }

        private void listBoxMouseMoved(object sender, MouseEventArgs e)
        {
            int index = listBox_BookName.IndexFromPoint(e.Location);

            if (index != -1 && index < listBox_BookName.Items.Count)
            {
                if (toolTip_BookAdd.GetToolTip(listBox_BookName) != listBox_BookName.Items[index].ToString())
                {
                    toolTip_BookAdd.SetToolTip(listBox_BookName, listBox_BookName.Items[index].ToString());
                }
            }
            else
            {
                toolTip_BookAdd.SetToolTip(this.listBox_BookName, string.Empty);
            }
        }

        private void button_AddNewBook_Accept_Click(object sender, EventArgs e)
        {
            byte status = MainWindow.instance.DBQuery("INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'" + get_book_temp_string[listBox_BookName.SelectedIndex] + "', N'"+ get_ware_temp_string[comboBox_AddNewBook_WarehouseName.SelectedIndex]+ "', N'"+ textBox_AddNewBook_Amount.Text +"');");
            if (status == 1)
                return;
            MessageBox.Show("Successfully!");
            MainWindow.instance.comboBox2SelectionChanged(sender, e);
        }
    }
}
