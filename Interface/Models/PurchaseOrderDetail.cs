//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interface.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderDetail
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
