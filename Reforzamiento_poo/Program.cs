using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reforzamiento_poo.Clases;

namespace Reforzamiento_poo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Cliente
            //Console.WriteLine("Ingresa tus nombres por favor.");
            //string name = Console.ReadLine();

            Cliente cliente1 = new Cliente(100, "Jorge Manuel" ,"Parra Toledo","18.147.258-9","123","+56965585451");

            cliente1.VerProductosDisponibles();
            cliente1.SolicitarCompra();
            
            

            // Administrador 

            Administrador administrador1 = new Administrador(1,"Jorge","Alveal","12.345.654-7","admin");
            administrador1.VerProductosDisponibles();
            administrador1.AgregarProducto();
            administrador1.ModificarProducto();
            administrador1.EliminarProducto();
            administrador1.VerTodosLosProductos();


            Console.ReadKey();
        }
    }
}
