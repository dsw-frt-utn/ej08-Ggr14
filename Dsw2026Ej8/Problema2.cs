using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public String CrearResumenVenta(long productCode, String productDescription, int quantity, decimal unitPrice)
        {
            decimal total;
            if (quantity <= 0) {
                total = 0;
            }
            else
            {
                total = quantity * unitPrice;
            }
            var aux = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };
            return $"{aux.Code}-{aux.Description}-{aux.Total}";

        }
    }
}
