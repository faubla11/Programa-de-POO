using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    internal class parlante : IMostraraFactura
    {
        //Metodos de la interfaz
        public virtual void facturaFinal()
        {
            Console.WriteLine("parlante");
        }
        public string regalo()
        {
            return " Pendrive regalado ";
        }
    }
}
