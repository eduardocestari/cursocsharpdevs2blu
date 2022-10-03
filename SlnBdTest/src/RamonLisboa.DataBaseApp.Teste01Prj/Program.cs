using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RamonLisboa.DataBaseApp.Teste01Prj
{
    class Program
    {
        static void Main(string[] args)
        {
            var mDataSet = new DataSet();
            var mConn = GetConnection();

            if (mConn.State == ConnectionState.Open)
            {
                //SQL Query to execute
                //selecting only first 10 rows for demo
                string sql = "select * from filmes.genero limit 0,10;";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //read the data
                while (rdr.Read())
                {
                    Console.WriteLine($@"|{rdr.GetInt32("id")}  | {rdr.GetString("nome")}   | {rdr.GetString("flstatus")}   |");
                }

                mConn.Close();

            }

        }

        public static MySqlConnection GetConnection()
        {
            var mConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=filmes;uid=root;server=localhost;database=filmes;uid=root;pwd='root'");
            try
            {
                mConn.Open();
                Console.WriteLine("Conexão Realizada!");
            }
            catch (MySqlException myEx)
            {
                Console.WriteLine("Não foi possível conectar:" + myEx.Message);
                throw;
            }

            return mConn;
        }
    }
}
