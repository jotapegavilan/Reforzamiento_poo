using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reforzamiento_poo.Clases
{
    class Cliente : Usuario
    {
        public string Fono { get; set; }
        public Cliente(int id, string nombres, string apellidos, string rut, string clave, string fono) 
            : base(id, nombres, apellidos, rut, clave)
        {
            Fono = fono;
        }

        public void SolicitarCompra()
        {
            Console.WriteLine("El cliente "+this.Nombres + " "+this.Apellidos + " solicito compra.");
        }
    }
}
