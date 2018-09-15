using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RetrieveRecords
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True");

                // write Query to retrieve records
                SqlCommand cmd = new SqlCommand("Select * from Student1", con);

                // open connection
                con.Open();
                //Execute DataReader
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    Console.WriteLine(dr["id"] + " " + dr["name"] + " " + dr["email"]+ " " + dr["join_date"]);
                }
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.WriteLine("OOps Something went wrong:" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
