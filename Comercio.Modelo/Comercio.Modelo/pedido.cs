//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comercio.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedido()
        {
            this.entrega = new HashSet<entrega>();
        }
    
        public int IDPedido { get; set; }
        public int IDCliente { get; set; }
        public byte Quantidade { get; set; }
        public short IDProduto { get; set; }
        public byte IDVendedor { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrega> entrega { get; set; }
        public virtual produto produto { get; set; }
        public virtual vendedor vendedor { get; set; }
    }
}
