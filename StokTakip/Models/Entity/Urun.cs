//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.Satıslar = new HashSet<Satıslar>();
        }
    
        public short Id { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string Fotograf { get; set; }
        public Nullable<short> urnKat { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satıslar> Satıslar { get; set; }
    }
}
