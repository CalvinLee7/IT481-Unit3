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

            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxServerName.Text) || string.IsNullOrEmpty(textBoxDatabaseName.Text))
            {
                MessageBox.Show("Please make sure all text box are filled with the required information");
            }
            else
            {

                //database = new DB($@"server = CALLEE01\SQLEXPRESS;Trusted_Connection=true;Database=Northwind;User Instance=false;Connection Timeout=30");
                database = new DB($@"server = {textBoxServerName.Text};Database={textBoxDatabaseName.Text};User Id = {textBoxUsername.Text};Password = {textBoxPassword.Text};Integrated Security=False;Trusted_Connection=False;Connection Timeout=30");
                MessageBox.Show("Database connection initialized");
            }
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

        private void buttonEName_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Please initailze the database connection");
            }
            else
            {
                try
                {
                    string cNames = database.getEmployeeName();
                    MessageBox.Show(cNames, "Employee Name");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void buttonECount_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Please initailze the database connection");
            }
            else
            {
                try
                {
                    string eCount = database.getEmployeeCount();
                    MessageBox.Show(eCount, "Employee Count");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void buttonOCount_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Please initailze the database connection");
            }
            else
            {
                try
                {
                    string eCount = database.getOrderCount();
                    MessageBox.Show(eCount, "Order Count");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void buttonSName_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Please initailze the database connection");
            }
            else
            {
                try
                {
                    string eCount = database.getShipName();
                    MessageBox.Show(eCount, "Ship Name");
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

        public string getCompanyName()
        {
            string cNames = string.Empty;

            try
            {
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
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string getCustomerCount()
        {
            Int32 cCount = 0;

            try
            {
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
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string getEmployeeCount()
        {
            Int32 eCount = 0;

            try
            {
                dbConnection = new SqlConnection(dbConnecionString);
                dbConnection.Open();
                string countQuery = "select count(*) from employees;";
                SqlCommand sqlcmd = new SqlCommand(countQuery, dbConnection);

                try
                {
                    eCount = Convert.ToInt32(sqlcmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return eCount.ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string getCustomerName()
        {
            string cNames = string.Empty;

            try
            {
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
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string getEmployeeName()
        {
            string eNames = string.Empty;

            try
            {
                SqlDataReader dataReader;

                dbConnection = new SqlConnection(dbConnecionString);
                dbConnection.Open();
                string cNameQuery = $"select FirstName LastName from employees;";
                SqlCommand sqlcmd = new SqlCommand(cNameQuery, dbConnection);
                dataReader = sqlcmd.ExecuteReader(); ;
                while (dataReader.Read())
                {
                    try
                    {
                        eNames = $"{eNames}{dataReader.GetValue(0)} \n ";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                return eNames;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string getOrderCount()
        {
            Int32 oCount = 0;

            try
            {
                dbConnection = new SqlConnection(dbConnecionString);
                dbConnection.Open();
                string countQuery = "select count(*) from orders;";
                SqlCommand sqlcmd = new SqlCommand(countQuery, dbConnection);

                try
                {
                    oCount = Convert.ToInt32(sqlcmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return oCount.ToString();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string getShipName()
        {
            string sNames = string.Empty;

            try
            {
                SqlDataReader dataReader;

                dbConnection = new SqlConnection(dbConnecionString);
                dbConnection.Open();
                string cNameQuery = "select shipname from orders;";
                SqlCommand sqlcmd = new SqlCommand(cNameQuery, dbConnection);
                dataReader = sqlcmd.ExecuteReader(); ;
                while (dataReader.Read())
                {
                    try
                    {
                        sNames = $"{sNames}{dataReader.GetValue(0)} \n ";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                return sNames;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
