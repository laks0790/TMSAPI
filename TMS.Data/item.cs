//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public item()
        {
            this.invoicedetails = new HashSet<invoicedetail>();
            this.voucherdetails = new HashSet<voucherdetail>();
        }
    
        public System.Guid itemkey { get; set; }
        public string itemid { get; set; }
        public string description { get; set; }
        public Nullable<short> itemtype { get; set; }
        public Nullable<decimal> unitprice { get; set; }
        public Nullable<decimal> unitcost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoicedetail> invoicedetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<voucherdetail> voucherdetails { get; set; }
    }
}