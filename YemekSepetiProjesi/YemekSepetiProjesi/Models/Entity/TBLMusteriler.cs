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
    using System.ComponentModel.DataAnnotations;


    public partial class TBLMusteriler
    {
        public TBLMusteriler()
        {
            this.TBLSatislar = new HashSet<TBLSatislar>();
        }

        public int MusteriId { get; set; }
        [Required(ErrorMessage = "Bu alan bo� ge�ilemez")]
        [StringLength(50, ErrorMessage = "Girilen de�er 50 karakteri ge�emez.")]
        public string MusteriAdi { get; set; }
        [Required(ErrorMessage = "Bu alan bo� ge�ilemez")]
        [StringLength(50, ErrorMessage = "Girilen de�er 50 karakteri ge�emez.")]
        public string MusteriSoyad { get; set; }

        public virtual ICollection<TBLSatislar> TBLSatislar { get; set; }
    }
}