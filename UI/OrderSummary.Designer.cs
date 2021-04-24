
namespace BillingNowDemo.UI
{
    partial class OrderSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelThankYou = new System.Windows.Forms.Label();
            this.dataGridViewOrderSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Item";
            // 
            // labelThankYou
            // 
            this.labelThankYou.AutoSize = true;
            this.labelThankYou.Location = new System.Drawing.Point(347, 412);
            this.labelThankYou.Name = "labelThankYou";
            this.labelThankYou.Size = new System.Drawing.Size(138, 13);
            this.labelThankYou.TabIndex = 1;
            this.labelThankYou.Text = "Thank you for the purchase";
            // 
            // dataGridViewOrderSummary
            // 
            this.dataGridViewOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderSummary.Location = new System.Drawing.Point(130, 69);
            this.dataGridViewOrderSummary.Name = "dataGridViewOrderSummary";
            this.dataGridViewOrderSummary.Size = new System.Drawing.Size(585, 311);
            this.dataGridViewOrderSummary.TabIndex = 2;
            this.dataGridViewOrderSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderSummary_CellContentClick);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewOrderSummary);
            this.Controls.Add(this.labelThankYou);
            this.Controls.Add(this.label1);
            this.Name = "OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Summary";
            this.Load += new System.EventHandler(this.OrderSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThankYou;
        private System.Windows.Forms.DataGridView dataGridViewOrderSummary;
    }
}