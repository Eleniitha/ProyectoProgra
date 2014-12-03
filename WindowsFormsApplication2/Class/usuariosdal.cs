using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Class
{
    class usuariosdal
    {


        public static int Agregar(usuario pUsuario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into usuarios (nombre, contraseña, codigo, ocupacion, telefono) values ('{0}','{1}','{2}', '{3}' , '{4}' )",
                pUsuario.Nombre, pUsuario.Contraseña, pUsuario.codigo, pUsuario.ocupacion, pUsuario.telefono), 
                
                BdComun.ObtenerConexion());

               retorno = comando.ExecuteNonQuery();
            return retorno;
        }



        public static List<usuario> Buscar(string pNombre)
        {
            List<usuario> _lista = new List<usuario>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT nombre FROM usuarios where Nombre ='{0}' ", pNombre), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                usuario pCliente = new usuario();
                pCliente.Nombre = _reader.GetString(0);
                //pCliente.Costo = _reader.GetString(1);


                _lista.Add(pCliente);
            }

            return _lista;
        }

        public static usuario Obtenerinventario(int nombre)
        {
            usuario pusuario = new usuario();
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Nombre FROM usuarios where Nombre ={0}", nombre), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pusuario.Nombre = _reader.GetString(0);
                //pinventario.Costo = _reader.GetString(1);

            }

            conexion.Close();
            return pusuario;

        }

        public static int Eliminar(string Nombre)
        {

            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From clientes where nombre={0}", Nombre), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }



    }
}
