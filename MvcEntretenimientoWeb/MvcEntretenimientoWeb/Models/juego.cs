//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcEntretenimientoWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class juego
    {
        public juego()
        {
            this.detalle_dia_campo = new HashSet<detalle_dia_campo>();
            this.material = new HashSet<material>();
        }
    
        public long CoJuego { get; set; }
        public string NoJuego { get; set; }
        public string TxtDescripcion { get; set; }
        public string TxtImagen { get; set; }
        public Nullable<decimal> SsPrecio { get; set; }
        public Nullable<int> FlEstado { get; set; }
    
        public virtual ICollection<detalle_dia_campo> detalle_dia_campo { get; set; }
        public virtual ICollection<material> material { get; set; }
    }
}
