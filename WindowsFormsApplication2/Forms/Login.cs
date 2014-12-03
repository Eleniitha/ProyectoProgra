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
using MySql.Data;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form 
    {
        
        MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                                 "Database = tiendacsharp; Port = 3306");
        MySqlCommand cmd = new MySqlCommand();
   

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd.Connection = cnn;

            try
            {
                cmd.CommandText = "select COUNT(*) from usuarios where nombre = '" + nomusu.Text + "'and contraseña = '" + passbox.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                //Comparamos si el valor recibido es 1 entonces existe si no NO
                if (valor == 1)
                {
                    WindowsFormsApplication2.Forms.Bienvenido hola = new WindowsFormsApplication2.Forms.Bienvenido();
                    hola.ShowDialog();

                    label1.Text = "Usuario Existe";

                    base.Dispose();
                   
                   
                }
                else { label1.Text = "Usuario No Existe"; }
            }
            catch (Exception ex)
            {
                label1.Text = "error siguiente" + ex;
            }

          
            cnn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
