
namespace BillingNowDemo
{
    partial class CustomerDetail
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
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textOrderID = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.buttonSelectItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(205, 138);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(178, 20);
            this.textCustomerName.TabIndex = 0;
            this.textCustomerName.TextChanged += new System.EventHandler(this.textCustomerName_TextChanged);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(79, 141);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 1;
            this.labelCustomerName.Text = "Customer Name";
            this.labelCustomerName.Click += new System.EventHandler(this.labelCustomerName_Click);
            // 
            // textOrderID
            // 
            this.textOrderID.Location = new System.Drawing.Point(522, 137);
            this.textOrderID.Name = "textOrderID";
            this.textOrderID.Size = new System.Drawing.Size(178, 20);
            this.textOrderID.TabIndex = 2;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(205, 240);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(178, 20);
            this.textPhoneNumber.TabIndex = 3;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(443, 140);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(47, 13);
            this.labelOrderID.TabIndex = 4;
            this.labelOrderID.Text = "Order ID";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(79, 247);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Phone Number";
            this.labelPhoneNumber.Click += new System.EventHandler(this.labelPhoneNumber_Click);
            // 
            // buttonSelectItem
            // 
            this.buttonSelectItem.Location = new System.Drawing.Point(522, 237);
            this.buttonSelectItem.Name = "buttonSelectItem";
            this.buttonSelectItem.Size = new System.Drawing.Size(178, 24);
            this.buttonSelectItem.TabIndex = 6;
            this.buttonSelectItem.Text = "Select Item";
            this.buttonSelectItem.UseVisualStyleBackColor = true;
            this.buttonSelectItem.Click += new System.EventHandler(this.buttonSelectItem_Click);
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectItem);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.textPhoneNumber);
            this.Controls.Add(this.textOrderID);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.textCustomerName);
            this.Name = "CustomerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Details";
            this.Load += new System.EventHandler(this.CustomerDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textOrderID;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonSelectItem;
    }
}

