using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DeleteStudentRecords
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from student1 where id = 516", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs Something went wrong :" + e);
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("Record Deleted");
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
