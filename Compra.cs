public class Compra
{
    //Variables para almacenar los datos de la compra
    public int Id{get; set;}
    public int CatalogoId{get; set;}
    public DateTime FechaInicioCompra{get; set;}
    public DateTime FechaFinalCompra{get; set;}
    public int Cantidad{get; set;}


   // Clase de datos simulada para almacenar componentes del catalogo y sus compras.
   // reemplazar por una base de datos real en una aplicacion real

   public static class CompraData
   {
    public static List<Catalogo> Componentes {get;set;} = new List<Catalogo>();

    public static List<Compra> Compras {get; set;} = new List<Compra>();
   }

}