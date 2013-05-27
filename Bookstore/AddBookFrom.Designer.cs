﻿namespace Bookstore
{
    partial class AddBookFrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookFrom));
            this.comboBox_AddNewBook_WarehouseName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AddNewBook_Amount = new System.Windows.Forms.TextBox();
            this.button_AddNewBook_Accept = new System.Windows.Forms.Button();
            this.toolTip_BookAdd = new System.Windows.Forms.ToolTip(this.components);
            this.listBox_BookName = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_increase_amount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox_AddNewBook_WarehouseName
            // 
            this.comboBox_AddNewBook_WarehouseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AddNewBook_WarehouseName.FormattingEnabled = true;
            this.comboBox_AddNewBook_WarehouseName.Location = new System.Drawing.Point(12, 30);
            this.comboBox_AddNewBook_WarehouseName.Name = "comboBox_AddNewBook_WarehouseName";
            this.comboBox_AddNewBook_WarehouseName.Size = new System.Drawing.Size(260, 21);
            this.comboBox_AddNewBook_WarehouseName.TabIndex = 1;
            this.comboBox_AddNewBook_WarehouseName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Warehouse Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(177, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // textBox_AddNewBook_Amount
            // 
            this.textBox_AddNewBook_Amount.Location = new System.Drawing.Point(220, 196);
            this.textBox_AddNewBook_Amount.Name = "textBox_AddNewBook_Amount";
            this.textBox_AddNewBook_Amount.Size = new System.Drawing.Size(52, 20);
            this.textBox_AddNewBook_Amount.TabIndex = 3;
            this.textBox_AddNewBook_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // button_AddNewBook_Accept
            // 
            this.button_AddNewBook_Accept.Location = new System.Drawing.Point(12, 231);
            this.button_AddNewBook_Accept.Name = "button_AddNewBook_Accept";
            this.button_AddNewBook_Accept.Size = new System.Drawing.Size(96, 23);
            this.button_AddNewBook_Accept.TabIndex = 4;
            this.button_AddNewBook_Accept.Text = "Accept";
            this.button_AddNewBook_Accept.UseVisualStyleBackColor = true;
            this.button_AddNewBook_Accept.Click += new System.EventHandler(this.button_AddNewBook_Accept_Click);
            // 
            // listBox_BookName
            // 
            this.listBox_BookName.FormattingEnabled = true;
            this.listBox_BookName.Location = new System.Drawing.Point(12, 80);
            this.listBox_BookName.Name = "listBox_BookName";
            this.listBox_BookName.Size = new System.Drawing.Size(260, 95);
            this.listBox_BookName.TabIndex = 7;
            this.listBox_BookName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxMouseMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Name:";
            // 
            // checkBox_increase_amount
            // 
            this.checkBox_increase_amount.AutoSize = true;
            this.checkBox_increase_amount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_increase_amount.Location = new System.Drawing.Point(15, 199);
            this.checkBox_increase_amount.Name = "checkBox_increase_amount";
            this.checkBox_increase_amount.Size = new System.Drawing.Size(105, 17);
            this.checkBox_increase_amount.TabIndex = 8;
            this.checkBox_increase_amount.Text = "Increase amount";
            this.checkBox_increase_amount.UseVisualStyleBackColor = true;
            this.checkBox_increase_amount.CheckedChanged += new System.EventHandler(this.checkBox_check_change);
            // 
            // AddBookFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.checkBox_increase_amount);
            this.Controls.Add(this.listBox_BookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddNewBook_Accept);
            this.Controls.Add(this.textBox_AddNewBook_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_AddNewBook_WarehouseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_AddNewBook_WarehouseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AddNewBook_Amount;
        private System.Windows.Forms.Button button_AddNewBook_Accept;
        private System.Windows.Forms.ToolTip toolTip_BookAdd;
        private System.Windows.Forms.ListBox listBox_BookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_increase_amount;
    }
}