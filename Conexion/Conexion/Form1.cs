using System;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conexión = new NpgsqlConnectionNpgsqlConnection();
        string cadenaConexion;
        public Form1()
        {
            InitializeComponent();
            cadenaConexion = " Server =  127.0.0.1; Port=5432; Database=parkboat;";
            cadenaConexion += " User Id =admin; "; " 
            cadenaConexion += "; Password = lavall2c";
            conexion.ConnectionString = cadenaConexion;
            try
            {
                conexion.Open();
            }
            catch
            {
                MessageBox.Show ("User or parssword incorrect");
                conexion.Close();
            }
            if(conexion.state.ToString()=="open")
                {
                MessageBox.Show("Connection relized succesfuly");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
