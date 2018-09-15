using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // decalre the SqlConnection
            SqlConnection con;
            // define connection object
            con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True");
            con.Open();
            Console.WriteLine("connected");
            con.Close();
        }
    }
}
