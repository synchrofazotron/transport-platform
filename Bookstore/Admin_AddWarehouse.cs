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
    public partial class Admin_AddWarehouse : Form
    {

        public static Admin_AddWarehouse instance;
        public Admin_AddWarehouse()
        {
            InitializeComponent();
            instance = this;
        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            if (this.textBox_location.ContainsFocus == true)
                if (this.textBox_location.Text == "LOCATION")
                {
                    this.textBox_location.Clear();
                    this.textBox_location.ForeColor = Color.Black;
                }

            if (this.textBox_name.ContainsFocus == true)
                if (this.textBox_name.Text == "NAME")
                {
                    this.textBox_name.Clear();
                    this.textBox_name.ForeColor = Color.Black;
                }

        }

        private void TextBoxLostFocus(object sender, EventArgs e)
        {
            if (this.textBox_location.Text == "")
            {
                this.textBox_location.Text = "LOCATION";
                this.textBox_location.ForeColor = Color.Gray;
            }

            if (this.textBox_name.Text == "")
            {
                this.textBox_name.Text = "NAME";
                this.textBox_name.ForeColor = Color.Gray;
            }
        }

        private void accept_btn_Click(object sender, EventArgs e)
        {
            if (this.textBox_name.Text == "NAME" || this.textBox_location.Text == "LOCATION")
            {
                MessageBox.Show("You must input all values!", "Error!");
                return;
            }
            byte status = MainWindow.instance.DBQuery("INSERT INTO [sbs].[warehouse] ([warehouse_id], [warehouse_name], [location]) VALUES (N'" + this.textBox_id.Text + "', N'" + this.textBox_name.Text + "', N'" + this.textBox_location.Text + "')");
            if (status == 0)
            {
                warehouse_ID_get(Convert.ToInt32(this.textBox_id.Text));
                MessageBox.Show("Record added!");
            }
            this.textBox_name.Text = "NAME";
            this.textBox_name.ForeColor = Color.Gray;
            this.textBox_location.Text = "LOCATION";
            this.textBox_location.ForeColor = Color.Gray;

        }

        private void decline_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void warehouse_ID_get(Int32 id)
        {
            id++;
            this.textBox_id.Text = id.ToString();
        }
    }
}
