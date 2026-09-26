using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp.ISApps
{
    internal class ConnDB
    {
        public void connDb()
        {
            SqlConnection sqlConnection;

            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=useDB;Integrated Security=True";

            sqlConnection = new SqlConnection(connString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open connection: {ex.Message}");
                return; // or handle appropriately
            }

            Console.WriteLine("user: ");
            string username = Console.ReadLine();

            //Console.WriteLine("connection open");
            //Console.ReadKey();

            //if (sqlConnection.State == System.Data.ConnectionState.Open)
            //{
            //    Console.WriteLine("Connection Succeed.");
            //}
            //else
            //{
            //    Console.WriteLine("Connection Failed.");
            //}
            //Console.WriteLine("Connection Succeed.");
        }


        public int getBanksAccount(int account)
        {

            return account;
        }
    }
}
