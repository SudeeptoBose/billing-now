using BillingNowDemo.BLL;
using BillingNowDemo.DAL;
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

namespace BillingNowDemo.UI
{
    public partial class OrderSummary : Form
    {
        public OrderSummary()
        {
            InitializeComponent();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(myconnstrng);
        DataTable Summarydt = new DataTable();
        OrderBLL orderBLL = new OrderBLL();
        OrderDAL orderDAL = new OrderDAL();


        private void OrderSummary_Load(object sender, EventArgs e)
        {
            Summarydt = orderDAL.Select();
            
            dataGridViewOrderSummary.DataSource = Summarydt;
        }

        private void dataGridViewOrderSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
