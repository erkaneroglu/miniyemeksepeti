using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YemekSepetiProjesi.Models.Entity;

namespace YemekSepetiProjesi.Models
{
    public class MultiModel
    {
        public TBLKategoriler kategoriModel { get; set; }
        public TBLYemekler urunModel { get; set; }
        public TBLSatislar satisModel { get; set; }
        public TBLMusteriler musteriModel { get; set; }

    }
}