using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reforzamiento_poo.Clases
{
    interface IAdministrador
    {
        //los que no están disponibles, agregar nuevos productos, modificar productos o eliminar.
        void VerTodosLosProductos();

        void AgregarProducto();

        void ModificarProducto();

        void EliminarProducto();
    }
}
