using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        public String ObtenerEtiquetaProducto(long code, String descripcion, decimal price)
        {
            String precioformat = FormatoMoneda(price);
            return $"[{code}] {descripcion} - {precioformat}";
        }
    }
}
