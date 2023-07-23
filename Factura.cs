using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    internal class Factura : Datospersonales
    {

        public int mouse, parlante, teclado, camara, TotalF;
        public void SumarAfactura(int cantidad, string eleccion)
        {

            if (eleccion == "1")
            {
                mouse += cantidad;
                TotalF += cantidad * 15;
            }
            if (eleccion == "2")
            {
                parlante += cantidad;
                TotalF += cantidad * 20;
            }
            if (eleccion == "3")
            {
                teclado += cantidad;
                TotalF += cantidad * 17;
            }
            if (eleccion == "4")
            {
                camara += cantidad;
                TotalF += cantidad * 10;
            }

        }

        public void FacturaFinal()
        {
            Console.Clear();
            Console.WriteLine("\n\tNombres: " + nombre + " " + apellido + "       " + "Numero telefonico: " + telefono);
            Console.WriteLine("\tCI: " + cedula + "                       " + "Correo: " + correo);
            Console.WriteLine("\n\t-----------------------------Detalles de la factura----------------------------\n");
            Console.WriteLine("\tItem              Precio por c/u              Cantidad      Subtotal\n");
            


            if (mouse > 0)
            {
                int subtotal = 0;
                subtotal += mouse * 15;

                Console.WriteLine("\tmouse                 $15                         " + mouse + "            $" + subtotal);

                Console.WriteLine("\tPendrive regalado");

            }
            if (parlante > 0)
            {
                int subtotal = 0;
                subtotal += parlante * 20;

                Console.WriteLine("\tparlante               $20                         " + parlante + "           $" + subtotal);

            }
            if (teclado > 0)
            {
                int subtotal = 0;
                subtotal += teclado * 17;

                Console.WriteLine("\tteclado              $17                         " + teclado + "          $" + subtotal);

            }
            if (camara > 0)
            {
                int subtotal = 0;
                subtotal += camara * 10;

                Console.WriteLine("\tcamara                  $10                          " + camara + "             $" + subtotal);

            }
            Console.WriteLine("\t--------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\n        TOTAL:                                                                 $" + TotalF);
            Console.WriteLine("\t\n\n\nOprime un tecla para retroceder...");

            Console.ReadKey();

        }
        public string regalo()
        {
            return " Pendrive regalado ";
        }
    }
}
