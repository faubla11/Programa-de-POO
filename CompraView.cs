public class CompraView
{
    // Metodos para mostrar los detalles de los componentes que dispone el catalogo en la pantalla
    public static void MostrarComponentes()
    {
        Console.WriteLine("Componentes Disponibles");
        var catalogosDisponibles =  CompraData.Catalogos.Where(a => a.Libre).ToList();
        foreach (var catalogo in catalogosDisponibles)
        {
            Console.WriteLine($"Id: {catalogo.Id}, Componentes: {catalogo.Componentes}");

        }

    }

    //Metodo para mostrar los detalles hecho de la compra por pantalla

    public static void MostrarCompras()
    {
        Console.WriteLine("Compras Disponibles");
        foreach (var compra in CompraData.Compras)
        {
            var catalogo = CompraData.Catalogos.FirstOrDefault(a=> a.Id == compra.CatalogoId);
            Console.WriteLine($"Id: {compra.Id}, Componentes: {catalogo.Componentes}, Fecha Inicio:{compra.FechaInicioCompra}");

        }
    }
}