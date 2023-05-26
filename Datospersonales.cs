using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Proyecto_POO

{

    internal class Datospersonales

    {

        //public  String nombre;

        //public  String apellido;

        //public  int telefono;

        //public  float cedula;

        //public  String correo;

        public static String nombre;

        public static String apellido;

        public static int telefono;

        public static float cedula;

        public static String correo;

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public int Telefono { get => telefono; set => telefono = value; }

        public float Cedula { get => cedula; set => cedula = value; }

        public string Correo { get => correo; set => correo = value; }

    }

}
