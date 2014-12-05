using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Class
{
    class ventadal
    {

        public static int Agregar(Venta pventa )
        {
            
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format(
                "Insert into Venta (Folio, borrado, Producto, Canprodu, Cantidadpagar, Le_Atendio) values ('{0}','{1}', '{2}' , '{3}', '{4}', '{5}' )",
             pventa.Folio,  pventa.borrado, pventa.Producto, pventa.Canprodu, pventa.Total, pventa.Le_atendio),

                BdComun.ObtenerConexion());

            MySqlCommand comando2 = new MySqlCommand(string.Format(
             "Insert into Venta_dia (Foliod, Productod, Canprodud, Cantidadpagard, Le_Atendiod) values ('{0}','{1}','{2}', '{3}' , '{4}' )",
             pventa.Folio, pventa.Producto, pventa.Canprodu, pventa.Total, pventa.Le_atendio),

             BdComun.ObtenerConexion());

            retorno = comando2.ExecuteNonQuery();
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public usuario usuarioactual { get; set; }



        public static int Borrar()
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From Venta;"), BdComun.ObtenerConexion());
                


                

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Borrarv()
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From Venta_dia;"), BdComun.ObtenerConexion());





            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static int acatualizar()
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE Venta set borrado = 0 where borrado = 1 ;"), BdComun.ObtenerConexion());





            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        



    }
}
