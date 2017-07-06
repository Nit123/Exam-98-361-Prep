using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterizedSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTotalSalesButton_Click(object sender, EventArgs e)
        {
            TotalSalesLabel.Text = String.Format("Total Sales: {0}", GetTotalSales(CustomerIdTextBox.Text));
        }

        private double GetTotalSales(string customerId)
        {
            double totalSales = -1;
            try
            {
                //Connection String
                string connectionString =
                @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename =" +
                @"C:\Northwind\NORTHWND.MDF;" +
                @"Integrated Security = True;" +
                @"Connect Timeout = 30";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetCustomerSales";
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@TotalSales", null);
                command.Parameters["@TotalSales"].DbType = DbType.Currency;
                command.Parameters["@TotalSales"].Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();
                totalSales = Double.Parse(command.Parameters["@TotalSales"].Value.ToString());
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return totalSales;
        }
    }
}
