using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Forms
{
    public partial class Edicion_invent : Form
    {
        public Edicion_invent()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Class.inventario pinventario = new Class.inventario();
            pinventario.Descripcion = textBox1.Text.Trim();
            pinventario.Nombre = textBox2.Text.Trim();
            pinventario.Clave =  textBox3.Text.Trim();
            pinventario.Costo = textBox4.Text.Trim();
            pinventario.Total = textBox5.Text.Trim();
            pinventario.Codigo = textBox6.Text.Trim();
            pinventario.Ubicacion = textBox7.Text.Trim();



            int resultado = Class.inventariodal.Agregar(pinventario);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void CARGAR_DATOS_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                             "Database = tiendacsharp; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT * FROM inventario", cnn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            Grid1.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Nombre = textBox9.Text;
            int retorno = 0;
            MySqlConnection conexion = Class.BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From inventario where nombre =" + "'" + Nombre + "'"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                Grid1.DataSource = Class.inventariodal.Buscar(textBox8.Text);

            }
        }
    }
}
