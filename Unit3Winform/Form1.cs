using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Unit3Winform
{
  
    public partial class Form1 : Form
    {

        DB database;
        public Form1()
        {
            InitializeComponent();

        }


        private void buttonInitDBConn_Click(object sender, EventArgs e)
        {
            database = new DB($@"server = CALLEE01\SQLEXPRESS;Trusted_Connection=true;Database=Northwind;User Instance=false;Connection Timeout=30");

            MessageBox.Show("Database connection initialized");
        }

        private void buttonCNumber_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Please initailze the database connection");
            }
            else
            {
                try
                {
                    string cCount = database.getCustomerCount();
                    MessageBox.Show(cCount, "Customer Count");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void buttonCName_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Please initailze the database connection");
            }
            else
            {
                try
                {
                    string cNames = database.getCustomerName();
                    MessageBox.Show(cNames, "Customer Name");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    class DB
    {
        string dbConnecionString;
        SqlConnection dbConnection;

        public DB(string conn)
        {
            dbConnecionString = conn;
        }

        public string getCustomerCount()
        {
            Int32 cCount = 0;

            dbConnection = new SqlConnection(dbConnecionString);
            dbConnection.Open();
            string countQuery = "select count(*) from customers;";
            SqlCommand sqlcmd = new SqlCommand(countQuery, dbConnection);

            try
            {
                cCount = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cCount.ToString();

        }

        public string getCustomerName()
        {
            string cNames = string.Empty;
            SqlDataReader dataReader;

            dbConnection = new SqlConnection(dbConnecionString);
            dbConnection.Open();
            string cNameQuery = "select companyname from customers;";
            SqlCommand sqlcmd = new SqlCommand(cNameQuery, dbConnection);
            dataReader = sqlcmd.ExecuteReader(); ;
            while (dataReader.Read())
            {
                try
                {
                    cNames = $"{cNames}{dataReader.GetValue(0)} \n ";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return cNames;

        }

        }
    }
