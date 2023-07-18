using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    internal class Detalless : componentes
    {
        public static void Menu(string opcion)
        {

            Factura nuevafactura = new Factura();
            if (opcion == "1")
            {

                int opciones;
                int cantidad = 0;
                do
                {
                    Console.WriteLine("¿Cuantos desea?");
                    cantidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Se ha agregado  " + cantidad + "mouse(s) a su pedido\n");


                    Console.WriteLine("Escriba el número de la opción que desea elegir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                        nuevafactura.FacturaFinal();
                        nuevafactura.regalo();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }
            else if (opcion == "2")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Se Ha agregado  " + cantidad + "parlante(s) a su pedido\n");
                do
                {
                    Console.WriteLine("Escriba el número de la opción que desea elegir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                        nuevafactura.FacturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }
            else if (opcion == "3")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Se Ha agregado " + cantidad + " teclado(s) a su carrito\n");
                do
                {
                    Console.WriteLine("Escriba el número de la opción que desea elegir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                        nuevafactura.FacturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }
            else if (opcion == "4")
            {
                int opciones;
                int cantidad = 0;
                Console.WriteLine("¿Cuantos desea?");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Se ah agregado " + cantidad + " camara(s) a su carrito\n");
                do
                {
                    Console.WriteLine("Escriba el número de la opcion que desea elegir" +
                    "\n1. Seguir comprando." +
                    "\n2. Finalizar compra.");
                    opciones = int.Parse(Console.ReadLine());
                    if (opciones == 1)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                    }
                    else if (opciones == 2)
                    {
                        nuevafactura.SumarAfactura(cantidad, opcion);
                        nuevafactura.FacturaFinal();
                    }
                    else if (opciones > 2 || opciones < 1)
                    {
                        Console.WriteLine("La opción ingresada (" + opciones + ") no existe, por favor, intente nuevamente.\n");
                    }
                } while (opciones > 2 || opciones < 1);
            }
        }
    }
}
