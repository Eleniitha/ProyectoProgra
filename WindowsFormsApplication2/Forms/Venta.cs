using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApplication2.Forms
{
    public partial class Venta : Form
    {
        
        
       



        public Venta()
        {
            InitializeComponent();


        }

        private void Venta_Load(object sender, EventArgs e)
        {
            
            MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                       "Database = tiendacsharp; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();
            DataTable dtDatos2 = new DataTable();


            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT nombre, costo FROM inventario", cnn);
            MySqlDataAdapter mdaDatos2 = new MySqlDataAdapter("SELECT * FROM Venta", cnn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);
            mdaDatos2.Fill(dtDatos2);


            // Se asigna el DataTable como origen de datos del DataGridView
            datagrid.DataSource = dtDatos;
            datagrid2.DataSource = dtDatos2;


            // Se cierra la conexión a la base de datos
            cnn.Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          decimal  precio = Convert.ToDecimal(textBox7.Text);
          decimal canridad = Convert.ToDecimal(textBox3.Text);



            Class.Venta pventa = new Class.Venta();

            pventa.Folio    = Convert.ToInt32(textBox1.Text.Trim());
            pventa.Producto = textBox2.Text.Trim();
            pventa.Canprodu = Convert.ToInt32(textBox3.Text.Trim());
            pventa.Total = canridad * precio;
            pventa.Le_atendio = textBox5.Text.Trim();


            int resultado = Class.ventadal.Agregar(pventa);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Guardado.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                       "Database = tiendacsharp; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos2 = new DataTable();


            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos2 = new MySqlDataAdapter("SELECT * FROM Venta", cnn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos2.Fill(dtDatos2);


            // Se asigna el DataTable como origen de datos del DataGridView
            datagrid2.DataSource = dtDatos2;


            // Se cierra la conexión a la base de datos
            cnn.Close();





        }

        private void nombrepre_ColumnDefaultCellStyleChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            int resultado = Class.ventadal.Borrar();
            if (resultado > 0)
            {
                MessageBox.Show("Venta ha sido vaciado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Vaciar Venta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            base.Dispose();
            
              

    }

        private void button4_Click(object sender, EventArgs e)
        {

            {
                datagrid.DataSource = Class.inventariodal.Buscar(textBox6.Text);

            }

            //if (datagrid.SelectedRows.Count == 1)
            //{
              //  int Nombre = Convert.ToInt32(datagrid.CurrentRow.Cells[0].Value);
                //ClienteSelecionado = Class.inventariodal.Obtenerinventario(Nombre);

                //this.Close();
            //}
            //else
              //  MessageBox.Show("debe de seleccionar una fila");



        }

        private void button5_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection("Server = localhost; Uid = root; Password =;" +
                                      "Database = tiendacsharp; Port = 3306");
            MySqlCommand cmd = new MySqlCommand();

            cnn.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();


            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT  nombre, costo FROM inventario", cnn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);


            // Se asigna el DataTable como origen de datos del DataGridView
            datagrid.DataSource = dtDatos;


            // Se cierra la conexión a la base de datos
            cnn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(datagrid2, myPaintArgs);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= datagrid.RowCount - 1; i++)
            {
                for (j = 0; j <= datagrid.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = datagrid[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("Venta.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created");

        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
