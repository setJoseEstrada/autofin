//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace autofin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_detalleFactura
    {
        public int idDetalle { get; set; }
        public Nullable<int> idFactura { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> Cantidad { get; set; }
    
        public virtual t_facturas t_facturas { get; set; }
        public virtual t_productos t_productos { get; set; }
    }
}
