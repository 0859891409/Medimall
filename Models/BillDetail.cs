//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medimall.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillDetail
    {
        public int BillDetailId { get; set; }
        public Nullable<int> BillId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> VoucherId { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Billing Billing { get; set; }
        public virtual Product Product { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}
