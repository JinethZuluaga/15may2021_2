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
    using System.ComponentModel.DataAnnotations;

    public partial class usuariorol
    {
        [Required(ErrorMessage = "El id no puede ir vacio")]
        public int id { get; set; }
        [Required(ErrorMessage = "El idUsuario no puede ir vacio")]
        [StringLength(20, ErrorMessage = "supero el limite de 20 caracteres")]
        public int idUsuario { get; set; }
        [Required(ErrorMessage = "El idRol no puede ir vacio")]
        public int idRol { get; set; }
    
        public virtual roles roles { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
