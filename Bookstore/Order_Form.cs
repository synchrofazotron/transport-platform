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
    public partial class Order_Form : Form
    {

        public static Order_Form instance;
        public Order_Form()
        {
            InitializeComponent();
            instance = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Orderform_accept_btn_Click(object sender, EventArgs e)
        {
            if (comboBox_warehouse.SelectedIndex < 0)
            {
                comboBox_warehouse.SelectedIndex = 0;
            }

            byte status = MainWindow.instance.DBQuery("UPDATE sbs.orders SET warehouse_id = '" + Global.get_warehouse_propery_string[this.comboBox_warehouse.SelectedIndex] + "' WHERE order_id = '" + textBox_Order_id.Text + "' AND item_id = '" + Global.get_bookID_propery_string[0] + "'");
            if (status == 1)
                return;
            status = MainWindow.instance.DBQuery("UPDATE sbs.orders SET order_status = 'У виконанні' WHERE order_id = '" + textBox_Order_id.Text + "' AND item_id = '" + Global.get_bookID_propery_string[0] + "'");
            if (status == 1)
                return;
            this.Close();
            MessageBox.Show("Successfully!");
            MainWindow.instance.checkboxselect(sender, e);
        }
    }
}
