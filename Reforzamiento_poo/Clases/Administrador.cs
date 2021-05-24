using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reforzamiento_poo.Clases
{
    class Administrador : Usuario , IAdministrador
    {
        public Administrador(int id, string nombres, string apellidos, string rut, string clave) 
            : base(id, nombres, apellidos, rut, clave)
        {
        }

        public void AgregarProducto()
        {
            Console.WriteLine("El administrador "+this.Nombres+" está agregando un producto");
        }

        public void EliminarProducto()
        {
            Console.WriteLine("El administrador " + this.Nombres + " está eliminando un producto");
        }

        public void ModificarProducto()
        {
            Console.WriteLine("El administrador " + this.Nombres + " está modificando un producto");
        }

        public void VerTodosLosProductos()
        {
            Console.WriteLine("Ver todos los productos :");
            Console.WriteLine("-Pizza");
            Console.WriteLine("-Sandwich");
            Console.WriteLine("-Completos");
            Console.WriteLine("-Empanadas");
        }
    }
}
