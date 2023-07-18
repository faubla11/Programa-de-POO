using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
     class Cpendrive:IMostraraFactura
    {
        //Variable de referencia hacia quien decoramos
        private IMostraraFactura decoramosA;

        //Pasamos al objeto que va ha ser decorado
        public Cpendrive(IMostraraFactura pmostraraFactura)
        {
            decoramosA = pmostraraFactura;
        }

        public override string ToString()
        {
            return "El regalo es \r\n"+ decoramosA.ToString();

        }

        //Metodod de la interfaz
        public string regalo()
        {
            return decoramosA.regalo() + ", Pendrive regalado";

        }

        public void facturaFinal()
        {

        }
    }
}
