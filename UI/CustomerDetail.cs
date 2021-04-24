using BillingNowDemo.BLL;
using BillingNowDemo.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingNowDemo
{
    public partial class CustomerDetail : Form
    {
        public CustomerDetail()
        {
            InitializeComponent();
        }
        CustomerBLL customerBll = new CustomerBLL();
        CustomerDAL customerDal = new CustomerDAL();
        private void labelCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void labelPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectItem_Click(object sender, EventArgs e)
        {
            // Get data from UI
            customerBll.name = textCustomerName.Text;
            customerBll.mobile = textPhoneNumber.Text;

            // Insert data into database
            bool success = customerDal.Insert(customerBll);

            // If successful then value is true, else false
            if(success== true)
            {
                // Data successfully inserted
                MessageBox.Show("Entry successful");
            }
            else
            {
                // Data failed to be inserted
                MessageBox.Show("Entry failed");
            }

            AddItem addItem = new AddItem();
            addItem.Show();
            this.Hide();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {

        }

        private void textCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
