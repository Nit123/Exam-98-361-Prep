using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithDataSet();
        }

        static void WorkingWithDataSet()
        {
            string cString = 
                @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename=" +
                @"C:\Northwind\NORTHWND.MDF;" +
                @"Integrated Security=True;" +
                @"Connect Timeout=30";

            SqlConnection northwindConnection = new SqlConnection(cString);
            string customerCommandText = "SELECT * FROM Customers";
            SqlDataAdapter customerAdapter = new SqlDataAdapter(customerCommandText, northwindConnection);
            string ordersCommandText = "SELECT * FROM Orders";
            SqlDataAdapter ordersAdapter = new SqlDataAdapter(ordersCommandText, northwindConnection);

            //Filling DataSet
            DataSet customerOrders = new DataSet();
            customerAdapter.Fill(customerOrders, "Customers");
            ordersAdapter.Fill(customerOrders, "Orders");

            //Added a relationship between Orders and Customer with Customer ID column  
            DataRelation relation =
                customerOrders.Relations.Add("CustomerOrders", customerOrders.Tables["Customers"].Columns["CustomerID"],
                                                               customerOrders.Tables["Orders"].Columns["CustomerID"]);

            foreach(DataRow customerRow in customerOrders.Tables["Customers"].Rows)
            {
                Console.WriteLine(customerRow["CustomerID"]);
                foreach (DataRow orderRow in customerRow.GetChildRows(relation))
                    Console.WriteLine("\t" + orderRow["OrderID"]);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
