//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EczaneOtomasyonEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stok_biten_ilaclar
    {
        public string ilac_ismi { get; set; }
        public string tur_ismi { get; set; }
        public System.DateTime uretim_tarihi { get; set; }
        public System.DateTime tuketim_tarihi { get; set; }
        public double fiyat { get; set; }
        public int stok { get; set; }
        public int tur_id { get; set; }
    }
}