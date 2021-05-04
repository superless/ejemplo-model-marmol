using System;

namespace ejemplo_model
{
    /// <summary>
    /// Trato realizado entre el vendedor y el cliente.
    /// </summary>
    public class TratoProducto {

        /// <summary>
        /// identificador
        /// </summary>
        public string id { get; set; }
        
        /// <summary>
        /// Fecha en que se añadió el producto a un trato.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// identificador del producto
        /// </summary>
        public string IdProducto { get; set; }

        /// <summary>
        /// cantidad
        /// </summary>
        public int Cantidad { get; set; }

    }
    
}
