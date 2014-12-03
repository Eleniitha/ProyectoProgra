using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Class
{
    class inventariodal
    {

        public static int Agregar(inventario pinventario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into inventario (descripcion, nombre, codigo, clave, costo, total, ubicacion) values ('{0}','{1}','{2}', '{3}' , '{4}', '{5}', '{6}' )",
                pinventario.Descripcion, pinventario.Nombre, pinventario.Codigo, pinventario.Clave, pinventario.Costo, pinventario.Total, pinventario.Ubicacion),

                BdComun.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<inventario> Buscar(string pNombre)
        {
            List<inventario> _lista = new List<inventario>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Nombre, costo FROM inventario  where Nombre ='{0}' ", pNombre), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                inventario pCliente = new inventario();
                pCliente.Nombre = _reader.GetString(0);
                pCliente.Costo = _reader.GetString(1);


                _lista.Add(pCliente);
            }

            return _lista;
        }

        public static inventario Obtenerinventario(int pId)
        {
            inventario pinventario = new inventario();
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Nombre, costo FROM clientes where Nombre ={0}", pId), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pinventario.Nombre = _reader.GetString(0);
                pinventario.Costo = _reader.GetString(1);

            }

            conexion.Close();
            return pinventario;

        }



    }
}
