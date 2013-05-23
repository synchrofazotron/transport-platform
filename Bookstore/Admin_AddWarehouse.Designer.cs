namespace Bookstore
{
    partial class Admin_AddWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddWarehouse));
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.accept_btn = new System.Windows.Forms.Button();
            this.decline_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.ForeColor = System.Drawing.Color.Gray;
            this.textBox_id.Location = new System.Drawing.Point(12, 23);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(39, 20);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Text = "ID";
            // 
            // textBox_name
            // 
            this.textBox_name.ForeColor = System.Drawing.Color.Gray;
            this.textBox_name.Location = new System.Drawing.Point(74, 23);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(155, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.Text = "NAME";
            this.textBox_name.Enter += new System.EventHandler(this.TextBoxGotFocus);
            this.textBox_name.Leave += new System.EventHandler(this.TextBoxLostFocus);
            // 
            // textBox_location
            // 
            this.textBox_location.ForeColor = System.Drawing.Color.Gray;
            this.textBox_location.Location = new System.Drawing.Point(12, 63);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(217, 20);
            this.textBox_location.TabIndex = 0;
            this.textBox_location.Text = "LOCATION";
            this.textBox_location.Enter += new System.EventHandler(this.TextBoxGotFocus);
            this.textBox_location.Leave += new System.EventHandler(this.TextBoxLostFocus);
            // 
            // accept_btn
            // 
            this.accept_btn.Location = new System.Drawing.Point(12, 115);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(100, 23);
            this.accept_btn.TabIndex = 1;
            this.accept_btn.Text = "Accept";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // decline_btn
            // 
            this.decline_btn.Location = new System.Drawing.Point(132, 115);
            this.decline_btn.Name = "decline_btn";
            this.decline_btn.Size = new System.Drawing.Size(100, 23);
            this.decline_btn.TabIndex = 1;
            this.decline_btn.Text = "Decline";
            this.decline_btn.UseVisualStyleBackColor = true;
            this.decline_btn.Click += new System.EventHandler(this.decline_btn_Click);
            // 
            // Admin_AddWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 156);
            this.ControlBox = false;
            this.Controls.Add(this.decline_btn);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_AddWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding warehouse...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.Button decline_btn;
    }
}