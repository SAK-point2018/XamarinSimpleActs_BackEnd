//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleActBackEnd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAKtblImage
    {
        public int tblImagesID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Size { get; set; }
        public byte[] ImageData { get; set; }
    }
}
