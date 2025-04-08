using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableNumber;

            Console.Write("tablo numarası girin: ");
            tableNumber= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=ASUS-PROART;initial Catalog=EgitimKampiDb;integrated security=true");
            SqlConnection connection = new SqlConnection("Data Source=E06H14M054;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
        
    }
}
