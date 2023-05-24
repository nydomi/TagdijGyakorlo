using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConsoleAppTagdij
{
    internal class Database
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        private string server = "localhost";
        private string user = "root";
        private string password = "";
        private string databaseName="tagdij";

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = databaseName;

            conn = new MySqlConnection(builder.ConnectionString);
            cmd = conn.CreateCommand();
        }

        public void nyit()
        {
            if (conn.State!=System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }
        private void zar()
        {
            if (conn.State!=System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        internal List<Ugyfel> getUgyfel()
        {
            List<Ugyfel> temp = new List<Ugyfel>();
            cmd.CommandText = "SELECT * FROM `ugyfel`";
            try
            {
                nyit();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Ugyfel uj = new Ugyfel(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"),dr.GetInt32("irszam"),dr.GetString("orsz"));
                        temp.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return temp;
        }

        internal List<Befiz> getBefiz()
        {
            List<Befiz> temp = new List<Befiz>();
            cmd.CommandText = "SELECT * FROM `befiz`";
            try
            {
                nyit();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Befiz uj = new Befiz(dr.GetInt32("azon"),dr.GetString("datum"),dr.GetInt32("osszeg"));
                        temp.Add(uj);
                    }
                }
                zar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return temp;
        }
        public void hozzaAdDB(int nev,int ossz, string date)
        {
            try
            {
                nyit();
                    cmd.CommandText = $"INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES ('{nev}','{date}','{ossz}')";
                    cmd.ExecuteNonQuery();
                zar();
                MessageBox.Show("Adat sikeresen hozzá adva!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
