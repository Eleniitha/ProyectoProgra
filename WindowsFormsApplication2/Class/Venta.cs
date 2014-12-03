using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Class
{
    class Venta
    {
                  public int Folio { get; set; }
            public string Producto { get; set; }
            public int Canprodu { get; set; }
            public decimal Total { get; set; }
            public string Le_atendio { get; set; }

            public Venta() { }

            public Venta(int pFolio, string pProducto, int pCanprodu, decimal pTotal, string pLe_atendio)
            {
                this.Folio = pFolio;
                this.Producto = pProducto;
                this.Canprodu = pCanprodu;
                this.Total = pTotal;
                this.Le_atendio = pLe_atendio;
           
            }

        



    }
}
