//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOOTASHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web;

    public partial class womenTable
    {
        public int ID { get; set; }
        public string productID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }

        [DisplayName("Upload File")]
        public string ImagePath { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
    }
}
