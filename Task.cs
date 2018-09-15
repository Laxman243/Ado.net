using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Microsoft SQL Server");
            Console.WriteLine("Wants to create Table : Enter 1");
            Console.WriteLine("Wants to Retrieve Records : Enter 2");
            Console.WriteLine("Wants to Delete Table : Enter 3");
            Console.WriteLine("What action you want to perform -- please choose your option");


            var num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 1)
            {
               createTable();
            }
            else if(num1 == 2)
            {
                retrieveRecords();
            }
            else if(num1 == 3)
            {
                deleteTable();
            }
            else
            {
                Console.WriteLine("Enter Wrong Choice , try again");
            }
        }    
        public static void createTable()
        {
            Console.WriteLine("Enter the Table Name which you want to create");
            //Console.WriteLine("Please Enter columns size in numbers");
            string tableName = Console.ReadLine();

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True"))
                {
                    Console.WriteLine("DB connected");
                    //SqlCommand command = new SqlCommand("create table " + tableName + "(customerId int not null, customerName varchar(100), customerAge int, address varchar(100))", con);
                    SqlCommand command = new SqlCommand("create table " + tableName + "(Id int not null, UserName varchar(100))", con);
                    con.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("table created sucessfully");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("something went wrong :" + e);
                Console.WriteLine("Wants to Try again : yes/no ");
                string n1 = Console.ReadLine();
                if(n1 == "yes")
                {
                    createTable();
                }
            }

            Console.Read();
        }
        public static void retrieveRecords()
        {

        }
        public static void deleteTable()
        {

        }
    }
}
