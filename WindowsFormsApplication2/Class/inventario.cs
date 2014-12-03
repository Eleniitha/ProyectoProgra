using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Class
{
    class inventario
    {
         public string Descripcion { get; set; }
            public string Nombre { get; set; }
            public string Clave { get; set; }
            public string Costo { get; set; }
            public string Total { get; set; }
            public string Codigo{get; set;}
            public string Ubicacion{get; set;}

            public inventario() { }

            public inventario(string pDescripcion, string pNombre, string pClave, string pCosto, string pTotal, 
                                                   string pCodigo, string pUbicacion)
            {
                this.Descripcion = pDescripcion;
                this.Nombre = pNombre;
                this.Clave = pClave;
                this.Costo = pCosto;
                this.Total = pTotal;
                this.Codigo = pCodigo;
                this.Ubicacion = pUbicacion;
            }

    }
}
