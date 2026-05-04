using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        public string Descripcion { get; set; }
        public Product (string descripcion)
        {
            Descripcion=descripcion;
        }
        public void Modificar (string nuevaDescripcion)
        {
            Descripcion = nuevaDescripcion; 
        }
    }
}
