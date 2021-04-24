
namespace BillingNowDemo
{
    partial class AddItem
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
            this.labelSelectItem = new System.Windows.Forms.Label();
            this.comboBoxSelectItem = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.dataGridViewAddItem = new System.Windows.Forms.DataGridView();
            this.labelDisplayTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectItem
            // 
            this.labelSelectItem.AutoSize = true;
            this.labelSelectItem.Location = new System.Drawing.Point(78, 68);
            this.labelSelectItem.Name = "labelSelectItem";
            this.labelSelectItem.Size = new System.Drawing.Size(60, 13);
            this.labelSelectItem.TabIndex = 0;
            this.labelSelectItem.Text = "Select Item";
            // 
            // comboBoxSelectItem
            // 
            this.comboBoxSelectItem.FormattingEnabled = true;
            this.comboBoxSelectItem.Location = new System.Drawing.Point(155, 65);
            this.comboBoxSelectItem.Name = "comboBoxSelectItem";
            this.comboBoxSelectItem.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSelectItem.TabIndex = 1;
            this.comboBoxSelectItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectItem_SelectedIndexChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(451, 68);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(515, 65);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(169, 20);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(155, 113);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(152, 390);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.labelTotalAmount.TabIndex = 5;
            this.labelTotalAmount.Text = "Total Amount";
            this.labelTotalAmount.Click += new System.EventHandler(this.labelTotalAmount_Click);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(609, 385);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceOrder.TabIndex = 6;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // dataGridViewAddItem
            // 
            this.dataGridViewAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddItem.Location = new System.Drawing.Point(155, 155);
            this.dataGridViewAddItem.Name = "dataGridViewAddItem";
            this.dataGridViewAddItem.Size = new System.Drawing.Size(529, 210);
            this.dataGridViewAddItem.TabIndex = 7;
            // 
            // labelDisplayTotalPrice
            // 
            this.labelDisplayTotalPrice.AutoSize = true;
            this.labelDisplayTotalPrice.Location = new System.Drawing.Point(228, 390);
            this.labelDisplayTotalPrice.Name = "labelDisplayTotalPrice";
            this.labelDisplayTotalPrice.Size = new System.Drawing.Size(28, 13);
            this.labelDisplayTotalPrice.TabIndex = 8;
            this.labelDisplayTotalPrice.Text = "0.00";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDisplayTotalPrice);
            this.Controls.Add(this.dataGridViewAddItem);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.comboBoxSelectItem);
            this.Controls.Add(this.labelSelectItem);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectItem;
        private System.Windows.Forms.ComboBox comboBoxSelectItem;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.DataGridView dataGridViewAddItem;
        private System.Windows.Forms.Label labelDisplayTotalPrice;
    }
}