using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Operations
{
    class sql
    {
        
        public static MySqlDataReader Read(string query)
        {
              string connStr = "server=sql6.freesqldatabase.com;user=sql6415586;database=sql6415586;port=3306;password=tCncIXNIB3";
              MySqlDataReader rdr = null;
              MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
            }
            conn.Close();
            return rdr;
        }

        public static void Write(string query)
        {
            string connStr = "server=sql6.freesqldatabase.com;user=sql6415586;database=sql6415586;port=3306;password=tCncIXNIB3";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                MessageBox.Show("ENter");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public static void Delete(string query)
        {
            string connStr = "server=sql6.freesqldatabase.com;user=sql6415586;database=sql6415586;port=3306;password=tCncIXNIB3";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            conn.Close();
        }
        public static void Update(string query)
        {
            string connStr = "server=sql6.freesqldatabase.com;user=sql6415586;database=sql6415586;port=3306;password=tCncIXNIB3";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            conn.Close();
        }
    }
}
