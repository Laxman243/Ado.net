using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConnectionClassExample1
    {
        static void Main(string[] args)
        {         
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True"))
            {
                con.Open();
                Console.WriteLine("Connection Established");
            }          
        }
    }
}
