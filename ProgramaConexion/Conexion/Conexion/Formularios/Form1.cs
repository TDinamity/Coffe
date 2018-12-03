using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conexion
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server = "+txt_Host.Text+"; database = "+txt_DB.Text+"; uid = "+txt_User.Text+"; pwd ="+txt_Pass.Text+";";
            MessageBox.Show(conexion.ConnectionString);
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Dispose();
                    MessageBox.Show("Desconectado");
                }
                else
                {
                    MessageBox.Show("No seas wey aun no la conectas");  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
