using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;


namespace SQLDBConnection
{
    public class DatabaseConnector
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Server=AZARA-qa;Database=RMx_Development; User ID=npriceserviceaccount;Password=pass@word1");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP(1) rmx_Code, rmx_Name from [RMx_Development].[dbo].[rmx_TradeAgreementVersion] Order By CreatedOn desc", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            connection.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
       }
    }
}
