//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekSepetiProjesi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLYemekler
    {
        public TBLYemekler()
        {
            this.TBLSatislar = new HashSet<TBLSatislar>();
            this.ImageURL = "place.jpg";
        }
    
        public int YemekID { get; set; }
        public string YemekAdi { get; set; }
        public Nullable<short> YemekKategori { get; set; }
        public Nullable<decimal> YemekFiyat { get; set; }
        public Nullable<byte> Stok { get; set; }
        public string ImageURL { get; set; }
    
        public virtual TBLKategoriler TBLKategoriler { get; set; }
        public virtual ICollection<TBLSatislar> TBLSatislar { get; set; }
    }
}