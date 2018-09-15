using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Student_InsertData1
    {
        static void Main(string[] args)
        {
            InsertData();
        }
        public static void InsertData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True");
                // writing sql query  
                //SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('514', 'laxman', 'laxman@example.com','1/12/2017')", con);
                //SqlCommand cm1 = new SqlCommand("insert into student(id, name, email, join_date)values('516', 'Faroq', 'faroq@example.com','12/12/2018')", con);
                SqlCommand cm1 = new SqlCommand("insert into student1(id, name, email, join_date)values('521', 'saif', 'faroq@example.com','12/12/2018')", con);
                SqlCommand cm2 = new SqlCommand("insert into student1(id, name, email, join_date)values('537', 'ashique', 'faroq@example.com','12/12/2018')", con);
                SqlCommand cm3 = new SqlCommand("insert into student1(id, name, email, join_date)values('536', 'sourav', 'faroq@example.com','12/12/2018')", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm2.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm3.ExecuteNonQuery();


                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
