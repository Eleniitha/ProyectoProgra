using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;



namespace WindowsFormsApplication2.Forms
{
    public partial class inventario : Form
    {

        

        public inventario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
 MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT * FROM inventario",cnn);
 
 // Con la información del adaptador se rellena el DataTable
 mdaDatos.Fill(dtDatos);
 
 // Se asigna el DataTable como origen de datos del DataGridView
       Grid1.DataSource = dtDatos;
 
 // Se cierra la conexión a la base de datos
 cnn.Close();
 //Crear un objeto ReportDocument 
//ReportDocument reporte = new ReportDocument();
//Cargar el Reporte
//reporte.Load(@".\CrystalReport1.rpt");
//Asignarle al Reporte el DataSet
//reporte.SetDataSource(dtDatos);
//Asignarle al CrystalReportViewer el ReportDocument 
//myViewer.ReportSource = reporte; 
 //this.myViewer.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
               printDocument1.Print();
        }
       


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Grid1.Width, this.Grid1.Height);
            Grid1.DrawToBitmap(bm, new Rectangle(0, 0, this.Grid1.Width, this.Grid1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                        Excel.Application xlApp ;
            Excel.Workbook xlWorkBook ;
            Excel.Worksheet xlWorkSheet ;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0; 

            for (i = 0; i <= Grid1.RowCount  - 1; i++)
            {
                for (j = 0; j <= Grid1.ColumnCount  - 1; j++)
                {
                    DataGridViewCell cell = Grid1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("inventario.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
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
      
    }
}
