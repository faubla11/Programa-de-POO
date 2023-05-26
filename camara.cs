using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    internal class camara : IMostraraFactura
    {
        public virtual void facturaFinal()
        {
            Console.WriteLine("camara");
        }
    }
}
