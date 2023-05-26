using Proyecto_POO;

internal class Program
{
    private static void Main(string[] args)
    {

        string opciones = "0";
        Console.WriteLine("====================================================================\n " +
               "  B I E N V E N I D O  A  T E C N O +\n" +
               "\n\t\tVenta de componentes para computadoras\n" +
               "====================================================================\n");
        Console.WriteLine("Ingrese su nombre por favor ");
        Datospersonales.nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su Apellido ");
        Datospersonales.apellido = Console.ReadLine();
        Console.WriteLine("Ingrese su numero telefonico ");
        Datospersonales.telefono = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su numero de cedula ");
        Datospersonales.cedula = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su correo electrónico, por favor ");
        Datospersonales.correo = Console.ReadLine();

       
         do
        {
            Console.Clear();
            Console.WriteLine("===============Catálogo de Componentes===============\n\n" +
            "Digite el número de la opción que desea  elegir:\n" +
            "\n1.- mouse" +
            "\n2.- parlante" +
            "\n3.- teclado" +
            "\n4.- camara" +
            "\n5.- Mostrar factura" +
            "\n0.- Salir\n");
            opciones = Console.ReadLine();
            Console.Clear();
            switch (opciones)

            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("El Valor del mouse es de $15");
                    Detalless.Menu(opciones);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("El Valor del parlante es de $20");
                    Detalless.Menu(opciones);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("El valor del teclado es de $17");
                    Detalless.Menu(opciones);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("El valor de la camara es de $10");
                    Detalless.Menu(opciones);
                    break;
                case "5":
                    Console.Clear();
                    Factura facturafi = new Factura();
                    Console.WriteLine("Mostrar factura.");

                    facturafi.FacturaFinal();
                    Console.ReadKey();
                    break;
                case "0":
                    Console.WriteLine("Gracias por su visita, Hasta pronto");

                    break;
                default:
                    Console.WriteLine("Este dato es incorrecto, vuelva a intentarlo");
                    Console.ReadKey();
                    break;
            }

        } while (opciones != "0");
    }

}
