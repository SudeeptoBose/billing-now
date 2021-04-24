using BillingNowDemo.BLL;
using BillingNowDemo.DAL;
using BillingNowDemo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingNowDemo
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(myconnstrng);
        DataTable AddItemdt = new DataTable();
        decimal total = 0;
        decimal totalQuantity = 0;
        ProductBLL productBLL = new ProductBLL();
        ProductDAL productDAL = new ProductDAL();
        OrderBLL orderBLL = new OrderBLL();
        OrderDAL orderDAL = new OrderDAL();

        private void AddItem_Load(object sender, EventArgs e)
        {

            comboBoxSelectItem.Items.Clear();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT productName from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxSelectItem.Items.Add(dr["productName"].ToString());
            }
            conn.Close();
            AddItemdt.Columns.Add("Product Name");
            AddItemdt.Columns.Add("Price");
            AddItemdt.Columns.Add("Quantity");
            AddItemdt.Columns.Add("Sub Total");
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string productName = comboBoxSelectItem.Text;
            decimal price = productDAL.SelectPrice(productName);
            decimal quantity = decimal.Parse(textBoxQuantity.Text);
            decimal subTotal = quantity * price;
            total += subTotal;
            totalQuantity += quantity; 


            if (productName == "")
            {
                MessageBox.Show("Error");
            }
            else
            {
                AddItemdt.Rows.Add(productName, price, quantity, subTotal);

                dataGridViewAddItem.DataSource = AddItemdt;

                comboBoxSelectItem.Text = "";
                textBoxQuantity.Text = "";
            }
            labelDisplayTotalPrice.Text = total.ToString();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            // Get data from UI and calculations
            orderBLL.productID = 1;
            orderBLL.totalPrice = total;
            orderBLL.quantity = totalQuantity;
            

            // Insert data into database
            bool success = orderDAL.Insert(orderBLL);

            // If successful then value is true, else false
            if (success == true)
            {
                // Data successfully inserted
                MessageBox.Show("Order Placed successfully");
            }
            else
            {
                // Data failed to be inserted
                MessageBox.Show("Order Failed");
            }

            OrderSummary orderSummary = new OrderSummary();
            orderSummary.Show();
            this.Hide();
        }

        

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
