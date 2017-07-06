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

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0)
            {
                SelectData(textBox1.Text);
            }
        }

        private void SelectData(string selectCommandText)
        {
            try
            {
                //Connection string
                string selectConnection =
                @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                @"AttachDbFilename=" +
                @"C:\Northwind\NORTHWND.MDF;" +
                @"Integrated Security=True;" +
                @"Connect Timeout=30;";
                SqlDataAdapter dataAdapter =
                    new SqlDataAdapter(selectCommandText, selectConnection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
