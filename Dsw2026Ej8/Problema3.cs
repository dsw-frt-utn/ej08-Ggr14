using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public String CompararCopias(int originalValue, Product product)
        {
            int valor=originalValue;
            valor++;
            Product productvalor= product;
            productvalor.Modificar("modificado");
            return $"{originalValue}-{valor}-{productvalor.Descripcion}";
        }
    }
}
