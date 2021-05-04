using System;
using System.Collections.Generic;

namespace ejemplo_model
{
    public class Trato
    {
        public DateTime Fecha { get; set; }

        // TratoProducto
        public List<string> Productos { get; set; } = new List<string>();



    }
    
}
