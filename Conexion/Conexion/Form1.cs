using Npgsql;
using System;
using System.Windows.Forms;

namespace Conexion
{
  public partial class Form1 : Form
  {

    string cadenaConexion;
    public Form1()
    {
      InitializeComponent();            
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
      using (NpgsqlConnection conexion = new NpgsqlConnection())
      {
        cadenaConexion = " Server =  127.0.0.1; Port=5432; Database=parkboat;";
        cadenaConexion += " User Id =admin; ";
            cadenaConexion += "; Password = lavall2c";
        conexion.ConnectionString = cadenaConexion;
        try
        {
          conexion.Open();
        }
        catch
        {
          MessageBox.Show("User or parssword incorrect");
          conexion.Close();
        }
        if (conexion.State.ToString() == "open")
        {
          MessageBox.Show("Connection relized succesfuly");
        }
      }
    }
  }
}
