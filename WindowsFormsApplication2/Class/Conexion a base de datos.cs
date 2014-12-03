using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsFormsApplication2.Class
{
    class Conexion_a_base_de_datos
    {

 static MySqlConnection Conex = new MySqlConnection();
 static string serv = "Server=localhost;";
 static string db = "Database=tiendacshar;";
 static string usuario = "UID=root;";
 static string pwd = "Password =;";
 string CadenaDeConexion = serv + db + usuario + pwd; 
 static MySqlCommand Comando = new MySqlCommand();
 static MySqlDataAdapter Adaptador = new MySqlDataAdapter();
 
 public void Conectar()
 {
 try
 {
 Conex.ConnectionString = CadenaDeConexion;
 Conex.Open();
 //MessageBox.Show("La BD esta ahora coenctada");
 }
 catch (Exception)
 {
 //MessageBox.Show("Ocurrio un error al conectar a la BD");
 throw;
 } 
 }
 public void Desconectar()
 {
 Conex.Close();
 } 
 
 public void insertaDatosventas(int Folio, string Fecha, string Vendedor,float Total, int Id_caja, int Id_cliente)
{ 
 string strSQL = "INSERT INTO alumnos VALUES ('" + Folio + "','" + Fecha + "'," + Vendedor + "','" + Total + "'," + Id_caja + "','" + Id_cliente + ");";
 Comando.CommandText = strSQL;
 Comando.Connection = Conex;
 
 }
 
 }

    }

