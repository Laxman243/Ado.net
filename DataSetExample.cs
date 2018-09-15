using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
   public class DataSetExample
    {
        public static string dataxml = null;
        static void Main(string[] args)
        {
            // store data in dataset Examples
            getdata();
            Console.ReadLine();
        }
        static void getdata()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-KUEO82L\\LAXMAN;Initial Catalog=Laxman;Integrated Security=True");
                // sqlCommand
                SqlDataAdapter cmd = new SqlDataAdapter("Select * from student",con);
                DataSet ds = new DataSet();
                cmd.Fill(ds);
                dataxml = ds.GetXml();
                ds.WriteXml(@"F:\ADO.NET_Programs\text.txt");
                Console.WriteLine(dataxml);
   
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong : " + ex);
            }
        }
    }
    /*
    class Tutorial : DataSetExample
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(dataxml);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"F:\ADO.NET_Programs\text.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, ar);
            stream.Close();

            Stream stream1 = new FileStream(@"F:\ADO.NET_Programs\text.txt", FileMode.Open, FileAccess.Read);
            formatter.Deserialize(stream1);


            Console.ReadKey();
        }
    }
    */
}
