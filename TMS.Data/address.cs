
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;


public partial class address
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public address()
    {

        this.companies = new HashSet<company>();

        this.userinfoes = new HashSet<userinfo>();

    }


    public System.Guid addrkey { get; set; }

    public string addrname { get; set; }

    public string address1 { get; set; }

    public string address2 { get; set; }

    public string city { get; set; }

    public string state { get; set; }

    public string zipcode { get; set; }

    public string country { get; set; }

    public string website { get; set; }

    public string phone { get; set; }

    public string email { get; set; }

    public string fax { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<company> companies { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<userinfo> userinfoes { get; set; }

}
