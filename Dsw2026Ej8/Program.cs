namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper v1= new ProductHelper();
            string resultado = v1.ObtenerEtiquetaProducto(1, "pepsi", 2000m);
            Console.WriteLine(resultado);
            Problema2 v2 = new Problema2();
            String resulado2 = v2.CrearResumenVenta(1111L, "monster", 12, 1200m);
            Console.WriteLine(resulado2);
            Problema3 v3= new Problema3();
            Product product = new Product("descripcion");
            String resultado3 = v3.CompararCopias(5, product);
            Console.WriteLine(resultado3);
            Problema4 v4= new Problema4();
            double resultado4= v4.CalcularPromedio(10,10,10);
            Console.WriteLine(resultado4);
            Problema5 v5 = new Problema5();
            RetailSale sale= new RetailSale(100m);
            WholesaleSale wholesale = new WholesaleSale(100m);
            Console.WriteLine(v5.ObtenerImporteFinal(sale));
            Console.WriteLine(v5.ObtenerImporteFinal(wholesale));
            Problema6 v6 = new Problema6();
            Console.WriteLine(v6.NormalizarCodigoProducto(null));
            Console.WriteLine(v6.NormalizarCodigoProducto("xd 12 z"));

        }
    }
}
