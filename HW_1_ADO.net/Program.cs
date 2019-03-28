using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_ADO.net
{
    class Program
    {
        //public static string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //SqlConnection conn = new SqlConnection(connStr);
        //SqlCommand cmd = null;



        SqlConnection conn = null;
        public Program() //(localdb)\v11.0
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost; Initial Catalog = ITCollage; Integrated Security = SSPI;";
        }
        static void Main(string[] args)
        {
          new Program().Show();
        }
        public void Show()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Подключение открыто");
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", conn.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", conn.Database);
                Console.WriteLine("\tСервер: {0}", conn.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", conn.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", conn.State);
                Console.WriteLine("\tВремя ожидания : {0}", conn.ConnectionTimeout);

            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong"+e);
                
            }
            finally
            {
                conn.Close(); 
            }
          
        }
    }
}
