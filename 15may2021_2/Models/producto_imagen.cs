//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _15may2021_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto_imagen
    {
        public int id { get; set; }
        public string imagen { get; set; }
        public int id_producto { get; set; }
    
        public virtual producto producto { get; set; }
    }
}
