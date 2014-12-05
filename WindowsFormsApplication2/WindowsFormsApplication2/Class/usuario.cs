using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Class
{
    class usuario
    {
      
            public string Nombre { get; set; }
            public string Contraseña { get; set; }
            public int codigo { get; set; }
            public string ocupacion { get; set; }
            public string telefono { get; set; }

            public usuario() { }

            public usuario(string pNombre, string pContraseña, int pcodigo, string pocupacion, string ptelefono)
            {
                this.Nombre = pNombre;
                this.Contraseña = pContraseña;
                this.codigo = pcodigo;
                this.ocupacion = pocupacion;
                this.telefono = ptelefono;
           
            }

        }
    
}
