//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A.H.M.O._2018.Models
{
    using System;
    using System.Collections.Generic;
    

    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Reserva = new HashSet<Reserva>();
        }
    
        public int IdU { get; set; }


        
        public int Rut { get; set; }


      
        public string Nombres { get; set; }


      
        public string ApellidoPaterno { get; set; }


        public string ApellidoMaterno { get; set; }


        public string Direccion { get; set; }



        public string Email { get; set; }


        public string Clave { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
