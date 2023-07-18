using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    internal class mouse : IMostraraFactura
    {
        //Metodos de la interfaz
        public virtual void facturaFinal()
        {
            Console.WriteLine("interfaze");
        }

        public string regalo()
        {
            return " Pendrive regalado ";
        }
    }
}
