using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal importe): base(importe) { }
        public override decimal CalculateTotal()
        {
            return Importe;
        }
    }
}
