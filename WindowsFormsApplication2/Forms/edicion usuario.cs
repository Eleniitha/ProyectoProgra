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
    public partial class edicion_usuario : Form
    {
        MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                                 "Database = tiendacsharp; Port = 3306");
        MySqlCommand cmd = new MySqlCommand();
   
        public edicion_usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class.usuario pusuario = new Class.usuario();
            pusuario.Nombre     = textBox1.Text.Trim();
            pusuario.Contraseña = textBox2.Text.Trim();
            pusuario.codigo =    Convert.ToInt32(textBox3.Text.Trim());
            pusuario.ocupacion  = textBox4.Text.Trim();
            pusuario.telefono   = textBox6.Text.Trim();


            int resultado = Class.usuariosdal.Agregar(pusuario);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Guardado.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                       "Database = tiendacsharp; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT * FROM usuarios", cnn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            datagrid.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            cnn.Close();

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagrid.DataSource = Class.usuariosdal.Buscar(textBox5.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Nombre = textBox7.Text;
           int retorno = 0;
            MySqlConnection conexion = Class.BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From usuarios where nombre ="+"'"+Nombre+"'"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            
            
        }
    }
}
