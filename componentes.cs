using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    internal class componentes : Datospersonales
    {

        public int mouse, parlante, teclado, camara, resultado;

        public void SumarFactura(int cantidad, string eleccion)
        {

            if (eleccion == "1")
            {
                mouse += cantidad;
                resultado += cantidad * 15;
            }
            else if (eleccion == "2")
            {
                parlante += cantidad;
                resultado += cantidad * 20;
            }
            else if (eleccion == "3")
            {
                teclado += cantidad;
                resultado += cantidad * 17;
            }
            else if (eleccion == "4")
            {
                camara += cantidad;
                resultado += cantidad * 10;
            }


        }
    }
}
