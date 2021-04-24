using BillingNowDemo.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingNowDemo.DAL
{
    class CustomerDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Data in Database
        public bool Insert(CustomerBLL customer)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO customer (name, mobile) VALUES (@name, @mobile)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", customer.name);
                cmd.Parameters.AddWithValue("@mobile", customer.mobile);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                // If query successful, value of rows > 0, else rows < 0
                if(rows > 0)
                {
                    // Query Successful
                    isSuccess = true;
                }
                else
                {
                    // Query Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); 
            }

            return isSuccess;

        }
        #endregion
    }
}
