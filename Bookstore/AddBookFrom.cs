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

            List<MainWindow.Items> get_book_temp = new List<MainWindow.Items>(MainWindow.DBConnect.reader_column_2x("SELECT sbs.warehouse.warehouse_name, sbs.warehouse.warehouse_id FROM sbs.warehouse WHERE warehouse_id NOT LIKE '0' ORDER BY warehouse_name"));
            for (int i = 0; i < get_book_temp.Count; i++)
                get_ware_temp_string.Add(string.Format("{0}", get_book_temp[i].reader1));
            this.comboBox_AddNewBook_WarehouseName.DataSource = get_book_temp;

            this.comboBox_AddNewBook_WarehouseName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionChanged);
            this.checkBox_increase_amount.CheckedChanged += new System.EventHandler(this.checkBox_check_change);

        }


        public void comboBoxSelectionChanged(object sender, EventArgs e)
        {
            List<MainWindow.Items> get_book_temp = new List<MainWindow.Items>();

            if (comboBox_AddNewBook_WarehouseName.SelectedIndex < 0)
            {
                comboBox_AddNewBook_WarehouseName.SelectedIndex = 0;
            }

            if (checkBox_increase_amount.Checked)
            {
                get_book_temp = MainWindow.DBConnect.reader_column_2x("SELECT goods_t.book_name, avaliable_t.item_id FROM sbs.avaliable avaliable_t LEFT JOIN sbs.goods goods_t ON avaliable_t.item_id = goods_t.item_id WHERE warehouse_id = '" + get_ware_temp_string[comboBox_AddNewBook_WarehouseName.SelectedIndex] + "' ORDER BY book_name");        
            }
            else
            {
                get_book_temp = MainWindow.DBConnect.reader_column_2x("SELECT sbs.goods.book_name, sbs.goods.item_id FROM sbs.goods WHERE sbs.goods.item_id <> ALL (SELECT avaliable_t.item_id FROM sbs.avaliable avaliable_t WHERE warehouse_id = '" + get_ware_temp_string[comboBox_AddNewBook_WarehouseName.SelectedIndex] + "') ORDER BY book_name");        
            }

            for (int i = 0; i < get_book_temp.Count; i++)
                get_book_temp_string.Add(string.Format("{0}", get_book_temp[i].reader1));
            this.listBox_BookName.DataSource = get_book_temp;
        }

        public void checkBox_check_change(object sender, EventArgs e)
        {
            comboBoxSelectionChanged(sender, e);
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
            if (checkBox_increase_amount.Checked)
            {
                if (listBox_BookName.SelectedIndex == -1)
                {
                    MessageBox.Show("No available books at that warehouse!");
                    return;
                }

                byte status = MainWindow.instance.DBQuery("UPDATE sbs.avaliable SET warehouse_amount = (warehouse_amount + '" + textBox_AddNewBook_Amount.Text + "') WHERE item_id = '" + get_book_temp_string[listBox_BookName.SelectedIndex] + "' AND warehouse_id = '" + get_ware_temp_string[comboBox_AddNewBook_WarehouseName.SelectedIndex] + "'");
                if (status == 1)
                    return;
            }
            else
            {
                if (listBox_BookName.SelectedIndex == -1)
                {
                    MessageBox.Show("All available books were already added to that warehouse!");
                    return;
                }

                byte status = MainWindow.instance.DBQuery("INSERT INTO [sbs].[avaliable] ([item_id], [warehouse_id], [warehouse_amount]) VALUES (N'" + get_book_temp_string[listBox_BookName.SelectedIndex] + "', N'" + get_ware_temp_string[comboBox_AddNewBook_WarehouseName.SelectedIndex] + "', N'" + textBox_AddNewBook_Amount.Text + "');");
                if (status == 1)
                    return;
            }
            
            MessageBox.Show("Successfully!");
            MainWindow.instance.comboBox2SelectionChanged(sender, e);
            this.Close();
        }
    }
}
