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
                cadenaConexion += " User Id =postgres; ";
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

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            string cadenaComando;
            cadenaComando = "INSERT INTO parkboat.userregistration (id,username,password,email,phonenumber)";
            cadenaComando += "VALUES(@id, @username, @password,@email, @phonenumber);";
            cmd.CommandText = cadenaComando;
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = TextBoxid.Text;
            cmd.Parameters.Add("@username",NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = TextBoxusername.Text;
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = TextBoxpassword.Text;
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = TextBoxemail.Text;
            cmd.Parameters.Add("@phonenumber", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = TextBoxphonenumber.Text;

            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                MessageBox.Show("Information correctly upload");
            else
                MessageBox.Show("Information not uploaded to DB");
            cmd.Parameters.Clear();
            TextBoxid.Text = "";
            TextBoxusername.Text = "";
            TextBoxpassword.Text = "";
            TextBoxemail.Text = "";
            TextBoxphonenumber.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String sql = ("SELECT *FROM userregistration ORDER BY ID");
            using (NpgsqlComand comand = new NpgsqlCommand(sql, conexion));
            {
                NpgsqlDataReader reader = comand.ExecuteReader();
                int 1 = 0;
                while (reader.Read())
                {
                    listView1.Items.Add(reader[0].ToString());
                    listView1.Items.[1].SubItems.Add(reader[1].ToString());
                    listView1.Items.[1].SubItems.Add(reader[2].ToString());
                    listView1.Items.[1].SubItems.Add(reader[3].ToString());
                    listView1.Items.[1].SubItems.Add(reader[4].ToString());
                    listView1.Update();
                    1++;
                }
                reader.Close();
            }

        }
    }
}