using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace Conexion.Clases
{
    class Conection
    {
        public static Conection sharedInstance { get; set; }
        MySqlConnection con = new MySqlConnection();

        public Conection()
        {
            sharedInstance = this;
        }

        
        public bool conectar()
        {
            try
            {
               
                con = new MySqlConnection();
                con.ConnectionString = Properties.Settings.Default.cadena_conexion;
                con.Open();
                return true;
            }
            catch (Exception r)
            {
                return false;
            }

        }
        
        public bool ejecutarQuery(string query)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable consultarTabla(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
