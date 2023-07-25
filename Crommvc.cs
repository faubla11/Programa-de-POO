internal class Program
{
    private static void Main(string[] args)
    {
        // Se crea el Modelo
        CompraData.Catalogos.Add(new Catalogo{Id = 1, Componentes = "Mouse", Libre = true});
        CompraData.Catalogos.Add(new Catalogo{Id = 2, Componentes = "Parlante", Libre = true});
        CompraData.Catalogos.Add(new Catalogo{Id = 3, Componentes = "Teclado", Libre = true});
        CompraData.Catalogos.Add(new Catalogo{Id = 4, Componentes = "Camara", Libre = true});

        //Se muestra los componentes del catalogo
        CompraView.MostrarComponentes();
        //Muestra los detalles realizados de la compra y la fecha en que se realizo la compra
        CompraController.RealizarCompra(4, DateTime.Now, DateTime.Now.AddDays(7));
        // Se muestra los detalles de las compras
        CompraView.MostrarCompras();
    }
}
