using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reforzamiento_poo.Clases
{
    //- usuarios(id, nombres, apellidos, rut, clave, id_rol)
    class Usuario
    {

        public Usuario(int id, string nombres, string apellidos, string rut, string clave )
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Rut = rut;
            Clave = clave;
        }
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Rut { get; set; }
        public string Clave { get; set; }

        public void VerProductosDisponibles()
        {
            Console.WriteLine("Ver todos los productos disponibles:");
            Console.WriteLine("-Pizza");
            Console.WriteLine("-Sandwich");
        }
    }
}
