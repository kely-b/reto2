using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto2
{
    internal class Trabajador
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Rol Roles { get; set; }
        public string sucursal { get; set; } 

        
 

        
        public Trabajador(string nombre, string usuario, string contraseña, string sucursal, Rol role)
        {
            Nombre = nombre;
            Usuario = usuario;
            Contraseña = contraseña;
            Roles = role;
            sucursal = sucursal;

        }
        public enum Rol {despachador, domiciliario }
        public enum Sucursal {Banano, Naranja, Mango, Mora, Guineo, Auyama }


    }
}
