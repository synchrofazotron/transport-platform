namespace Bookstore
{
    partial class Order_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Form));
            this.Orderform_accept_btn = new System.Windows.Forms.Button();
            this.orderform_decline_btn = new System.Windows.Forms.Button();
            this.textBox_Order_id = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.comboBox_warehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_book_name = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Orderform_accept_btn
            // 
            this.Orderform_accept_btn.Location = new System.Drawing.Point(35, 149);
            this.Orderform_accept_btn.Name = "Orderform_accept_btn";
            this.Orderform_accept_btn.Size = new System.Drawing.Size(75, 23);
            this.Orderform_accept_btn.TabIndex = 0;
            this.Orderform_accept_btn.Text = "Accept";
            this.Orderform_accept_btn.UseVisualStyleBackColor = true;
            this.Orderform_accept_btn.Click += new System.EventHandler(this.Orderform_accept_btn_Click);
            // 
            // orderform_decline_btn
            // 
            this.orderform_decline_btn.Location = new System.Drawing.Point(173, 149);
            this.orderform_decline_btn.Name = "orderform_decline_btn";
            this.orderform_decline_btn.Size = new System.Drawing.Size(75, 23);
            this.orderform_decline_btn.TabIndex = 1;
            this.orderform_decline_btn.Text = "Decline";
            this.orderform_decline_btn.UseVisualStyleBackColor = true;
            this.orderform_decline_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Order_id
            // 
            this.textBox_Order_id.Location = new System.Drawing.Point(79, 6);
            this.textBox_Order_id.Name = "textBox_Order_id";
            this.textBox_Order_id.ReadOnly = true;
            this.textBox_Order_id.Size = new System.Drawing.Size(43, 20);
            this.textBox_Order_id.TabIndex = 2;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(238, 6);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.ReadOnly = true;
            this.textBox_Amount.Size = new System.Drawing.Size(31, 20);
            this.textBox_Amount.TabIndex = 2;
            // 
            // comboBox_warehouse
            // 
            this.comboBox_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_warehouse.Location = new System.Drawing.Point(117, 101);
            this.comboBox_warehouse.Name = "comboBox_warehouse";
            this.comboBox_warehouse.Size = new System.Drawing.Size(152, 21);
            this.comboBox_warehouse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // richTextBox_book_name
            // 
            this.richTextBox_book_name.Location = new System.Drawing.Point(79, 35);
            this.richTextBox_book_name.Name = "richTextBox_book_name";
            this.richTextBox_book_name.ReadOnly = true;
            this.richTextBox_book_name.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_book_name.Size = new System.Drawing.Size(193, 45);
            this.richTextBox_book_name.TabIndex = 5;
            this.richTextBox_book_name.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose Warehouse:";
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox_book_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_warehouse);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.textBox_Order_id);
            this.Controls.Add(this.orderform_decline_btn);
            this.Controls.Add(this.Orderform_accept_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Order_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit order...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Orderform_accept_btn;
        private System.Windows.Forms.Button orderform_decline_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_Order_id;
        public System.Windows.Forms.TextBox textBox_Amount;
        public System.Windows.Forms.RichTextBox richTextBox_book_name;
        public System.Windows.Forms.ComboBox comboBox_warehouse;
    }
}